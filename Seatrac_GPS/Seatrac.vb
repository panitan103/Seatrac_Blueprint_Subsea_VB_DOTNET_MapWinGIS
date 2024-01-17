Imports System
Imports System.Security.Cryptography
Imports System.Buffer
Imports System.Text
Imports System.Convert
Imports System.Net.NetworkInformation

Module Seatrac
    Public Function check_valut_to_key(ByVal dict_command As Dictionary(Of String, String), ByVal data As String) As String
        Return (dict_command.ToDictionary(Function(x) x.Value, Function(x) x.Key))(data)
    End Function

    Public Function CalculateCRC16(data As String) As String
        Dim offset As Integer = 0
        Dim lengh As Integer = data.Length / 2
        Dim data_byte As Byte() = GetBytesFromHexString(data)
        Dim crc As UInt16 = &H0
        For i As UInt16 = 0 To lengh - 1
            crc = crc Xor data_byte(i)
            For j As UInt16 = 0 To 7
                If (crc And &H1) > 0 Then
                    crc = (crc >> 1) Xor &HA001
                Else
                    crc = (crc >> 1)
                End If
            Next
        Next

        Return ConvertEndianness(Hex(crc))
    End Function
    Public Function GetHexString(Source As String) As String
        Dim b As Byte() = System.Text.Encoding.UTF8.GetBytes(Source)
        Return BitConverter.ToString(b).Replace("-", "")
    End Function
    Private Function GetBytesFromHexString(hexString As String) As Byte()
        Dim bytes As Byte() = New Byte(hexString.Length \ 2 - 1) {}
        For i As Integer = 0 To hexString.Length - 1 Step 2
            bytes(i \ 2) = ToByte(hexString.Substring(i, 2), 16)
        Next
        Return bytes
    End Function

    Private Function ConvertEndianness(hexString As String) As String
        Dim output As String = ""
        For i As Integer = hexString.Length - 2 To 0 Step -2
            output &= hexString.Substring(i, 2)
        Next
        Return output
    End Function

    Public Function HextoInt(s As String, types As Boolean) As String


        If s = "" Then
            s = "00"
        Else
            s = s
        End If
        Dim input As String = s
        Dim output As String = ConvertEndianness(input)
        Dim integerValue As Double = Convert.ToInt32(output, 16)

        Dim bit As Integer = Len(input) * 4
        Dim half_bit As Double = 2 ^ bit / 2
        If integerValue >= half_bit AndAlso CBool(types) Then
            integerValue = integerValue - 2 ^ bit
        End If
        Return integerValue

    End Function
    Public Function HextoStr(s As String) As String

        Dim hexString As String = s
        Dim hexAsBytes As Byte() = New Byte(hexString.Length \ 2 - 1) {}
        For i As Integer = 0 To hexAsBytes.Length - 1
            hexAsBytes(i) = Convert.ToByte(hexString.Substring(i * 2, 2), 16)
        Next
        Dim text As String = System.Text.Encoding.UTF8.GetString(hexAsBytes)

        Return text
    End Function
    Private Function encrypt_Seatrac(command As String) As String
        Return ("#" + command + CalculateCRC16(command))
    End Function
    Public Function ping_command(ping_type As String, id As String, acoutic As String) As String
        Dim ping As String = Seatrac_Command.CID(ping_type) + Seatrac_Command.BID(id) + Seatrac_Command.AMSG(acoutic)
        Dim ping_encrypt As String = encrypt_Seatrac(ping)
        Return ping_encrypt
    End Function

    Public Function send_data_command(id As String, input As String)
        Dim hexString As String = String.Empty
        For Each b As Byte In Encoding.UTF8.GetBytes(input)
            hexString += b.ToString("X2")
        Next
        Dim input_size As String = input.Length.ToString("X")
        If input.Length < 16 Then
            input_size = "0" + input_size
        Else
            input_size = input_size
        End If
        Dim data As String = Seatrac_Command.CID("ST_CID_NAV_STATUS_SEND") + Seatrac_Command.BID(id) + input_size + hexString
        Dim data_encrypt As String = encrypt_Seatrac(data)
        Return data_encrypt
    End Function
    Public Function Seatrac_Command() As (CID As Dictionary(Of String, String), CST As Dictionary(Of String, String), BID As Dictionary(Of String, String), AMSG As Dictionary(Of String, String), APLOAD As Dictionary(Of String, String), STB As Dictionary(Of String, String))
        Dim CID As New Dictionary(Of String, String) From {
        {"ST_CID_INVALID", "00"},
        {"ST_CID_SYS_ALIVE", "01"},                           ' Command sent To receive a simple alive message from the beacon.  
        {"ST_CID_SYS_INFO", "02"},                        ' Command sent to receive hardware & firmware identification information.  
        {"ST_CID_SYS_REBOOT", "03"},                          ' Command sent to soft reboot the beacon.  
        {"ST_CID_SYS_ENGINEERING", "04"},                 ' Command sent to perform engineering actions.  
        {"ST_CID_PROG_INIT", "0D"},                       ' Command sent to initialise a firmware programming sequence.  
        {"ST_CID_PROG_BLOCK", "0E "},                     ' Command sent to transfer a firmware programming block.  
        {"ST_CID_PROG_UPDATE", "0F"},                     ' Command sent to update the firmware once program transfer has completed.  
        {"ST_CID_STATUS", "10"},                          ' Command sent to request the current system status (AHRS   Depth   Temp   etc).  
        {"ST_CID_STATUS_CFG_GET", "11"},                      ' Command sent to retrieve the configuration of the status system (message content And auto-output interval).  
        {"ST_CID_STATUS_CFG_SET", "12"},                  ' Command sent to set the configuration of the status system (message content And auto-output interval).  
        {"ST_CID_SETTINGS_GET", "15"},                        ' Command sent to retrieve the working settings in use on the beacon.  
        {"ST_CID_SETTINGS_SET", "16"},                          ' Command sent to set the working settings and apply them. They are NOT saved to permanent memory until ST_CID_ SETTINGS_SAVE is issued. The device will need to be rebooted after this to apply some of the changes.  
        {"ST_CID_SETTINGS_LOAD", "17"},                       ' Command sent to load the working settings from permanent storage and apply them. Not all settings can be loaded and applied as they only affect the device on start-up.  
        {"ST_CID_SETTINGS_SAVE", "18"},                       ' Command sent to save the working settings into permanent storage.  
        {"ST_CID_SETTINGS_RESET", "19"},                      ' Command sent to restore the working settings to defaults   store them into permanent memory And apply them.  
        {"ST_CID_CAL_ACTION", "20"},                          ' Command sent to perform specific calibration actions.  
        {"ST_CID_CAL_AHRS_GET", "21"},                        ' Command sent to retrieve the current AHRS calibration.  
        {"ST_CID_CAL_AHRS_SET", "22"},                        ' Command sent to set the contents of the current AHRS calibration (And store to memory)  
        {"ST_CID_XCVR_ANALYSE", "30"},                       ' Command sent to instruct the receiver to perform a noise analysis And report the results.  
        {"ST_CID_XCVR_TX_MSG", "31"},                         ' Message sent when the transceiver transmits a message.  
        {"ST_CID_XCVR_RX_ERR", "32"},                         ' Message sent when the transceiver receiver encounters an error.  
        {"ST_CID_XCVR_RX_MSG", "33"},                         ' Message sent when the transceiver receives a message (Not requiring a response).  
        {"ST_CID_XCVR_RX_REQ", "34"},                         ' Message sent when the transceiver receives a request (requiring a response).  
        {"ST_CID_XCVR_RX_RESP", "35"},                        ' Message sent when the transceiver receives a response (to a transmitted request).  
        {"ST_CID_XCVR_RX_UNHANDLED", "37"},                   ' Message sent when a message has been received but Not handled by the protocol stack.  
        {"ST_CID_XCVR_USBL", "38"},                           ' Message sent when a USBL signal Is decoded into an angular bearing.  
        {"ST_CID_XCVR_FIX", "39"},                        ' Message sent when the transceiver gets a position/range fix on a beacon from a request/response.  
        {"ST_CID_XCVR_STATUS", "3A"},                     ' Message sent to query the current transceiver state.  
        {"ST_CID_PING_SEND", "40"},                          ' Command sent to transmit a PING message.  
        {"ST_CID_PING_REQ", "41"},                            ' Message sent when a PING request Is received.  
        {"ST_CID_PING_RESP", "42"},                           ' Message sent when a PING response Is received   Or timeout occurs   with the echo response data.  
        {"ST_CID_PING_ERROR", "43"},                          ' Message sent when a PING response error/timeout occurs.  
        {"ST_CID_ECHO_SEND", "48"},                          ' Command sent to transmit an ECHO message.  
        {"ST_CID_ECHO_REQ", "49"},                            ' Message sent when an ECHO request Is received.  
        {"ST_CID_ECHO_RESP", "4A"},                           ' Message sent when an ECHO response Is received   Or timeout occurs   with the echo response data.  
        {"ST_CID_ECHO_ERROR", "4B"},                          ' Message sent when an ECHO response error/timeout occurs.  
        {"ST_CID_NAV_QUERY_SEND", "50"},                    ' Message sent to query navigation information from a remote beacon.  
        {"ST_CID_NAV_QUERY_REQ", "51"},                      ' Message sent from a beacon that receives a NAV_QUERY.  
        {"ST_CID_NAV_QUERY_RESP", "52"},
        {"ST_CID_NAV_ERROR", "53"},
        {"ST_CID_NAV_QUEUE_SET", "58"},
        {"ST_CID_NAV_QUEUE_CLR", "59"},
        {"ST_CID_NAV_QUEUE_STATUS", "5A"},
        {"ST_CID_NAV_STATUS_SEND", "5B"},
        {"ST_CID_NAV_STATUS_RECEIVE", "5C"},
        {"ST_CID_DAT_SEND", "60"},
        {"ST_CID_DAT_RECEIVE", "61"},
        {"ST_CID_DAT_ERROR", "63"},
        {"ST_CID_DAT_QUEUE_SET", "64"},
        {"ST_CID_DAT_QUEUE_CLR", "65"},
        {"ST_CID_DAT_QUEUE_STATUS", "66"}
        }
        Dim CST As New Dictionary(Of String, String) From {
        {"ST_CST_OK", "00"},                                   ' Returned if a command Or operation Is completed successful without error.  '
        {"ST_CST_FAIL", "01"},                                  ' Returned if a command Or operation cannot be completed.  '
        {"ST_CST_EEPROM_ERROR", "03"},                         ' Returned if an error occurs while reading Or writing EEPROM data.  '      
        {"ST_CST_CMD_PARAM_MISSING", "04"},                   ' Returned if a command message Is given that does Not have enough defined fields for the specified CID code.  '
        {"ST_CST_CMD_PARAM_INVALID", "05"},                     ' Returned if a data field in a message does Not contain a valid Or expected value.  '
        {"ST_CST_PROG_FLASH_ERROR", "0A"},                    ' Returned if an error occurs while writing data into the processors flash memory.  '
        {"ST_CST_PROG_FIRMWARE_ERROR", "0B"},                   ' Returned if firmware cannot be programmed due to incorrect firmware credentials Or signature.  '
        {"ST_CST_PROG_SECTION_ERROR", "0C"},                   ' Returned if the firmware cannot be programmed into the specified memory section.  '
        {"ST_CST_PROG_LENGTH_ERROR", "0D"},                    ' Returned if the firmware length Is too large to fit into the specified memory section   Or Not what the current operation Is expecting.  '
        {"ST_CST_PROG_DATA_ERROR", "0E"},                      ' Returned if there Is an error decoding data in a firmware block.  '
        {"ST_CST_PROG_CHECKSUM_ERROR", "0F"},                  ' Returned if the specified checksum for the firmware does Not match the checksum computed prior to performing the update.  '
        {"ST_CST_XCVR_BUSY", "30"},                           ' Returned if the transceiver cannot perform a requested action as it Is currently busy (i.e. transmitting a message).  '
        {"ST_CST_XCVR_ID_REJECTED", "31"},                      ' Returned if the received message did Not match the specified transceiver ID (And wasn't a Sent-To-All)   and the message has been rejected.  '
        {"ST_CST_XCVR_CSUM_ERROR", "32"},                      ' Returned if received acoustic message's checksum was invalid   and the message has been rejected.  '
        {"ST_CST_XCVR_LENGTH_ERROR", "33"},                    ' Returned if an error occurred with message framing   meaning the end of the message has Not been received within the expected time.  '
        {"ST_CST_XCVR_RESP_TIMEOUT", "34"},                    ' Returned if the transceiver has sent a request message to a beacon   but no response has been returned within the allotted waiting period.  '
        {"ST_CST_XCVR_RESP_ERROR", "35"},                      ' Returned if the transceiver has send a request message to a beacon   but an error occurred while receiving the response.  '
        {"ST_CST_XCVR_RESP_WRONG", "36"},                      ' Returned if the transceiver has sent a request message to a beacon   but received an unexpected response from another beacon while waiting.  '
        {"ST_CST_XCVR_PLOAD_ERROR", "37"},                     ' Returned by protocol payload decoders   if the payload can't be parsed correctly.  '
        {"ST_CST_XCVR_STATE_STOPPED", "3A"},                   ' Indicates the transceiver Is in a stopped state.  '
        {"ST_CST_XCVR_STATE_IDLE", "3B"},                      ' Indicates the transceiver Is in an idle state waiting for reception Or transmission to start.  '
        {"ST_CST_XCVR_STATE_TX", "3C"},                        ' Indicates the transceiver Is in a transmitting states.  '
        {"ST_CST_XCVR_STATE_REQ", "3D"},                       ' Indicates the transceiver Is in a requesting state   having transmitted a message And Is waiting for a response to be received.  '
        {"ST_CST_XCVR_STATE_RX", "3E"},                        ' Indicates the transceiver Is in a receiving state.  '
        {"ST_CST_XCVR_STATE_RESP", "3F"},                      ' Indicates the transceiver Is in a responding state   where a message Is being composed And the “response time” period Is being observed.  '
        {"ST_CST_DEX_SOCKET_ERROR", "70"},                    ' Returned by the DEX protocol handler if an error occurred trying to open   close Or access a specified socket ID.  '
        {"ST_CST_DEX_RX_SYNC", "71"},                           ' Returned by the DEX protocol handler when receiver synchronisation has occurred with the socket master And data transfer Is ready to commence.  '
        {"ST_CST_DEX_RX_DATA", "72"},                          ' Returned by the DEX protocol handler when data has been received through a socket.  '
        {"ST_CST_DEX_RX_SEQ_ERROR", "73"},                     ' Returned by the DEX protocol handler when data transfer synchronisation has been lost with the socket master.  '
        {"ST_CST_DEX_RX_MSG_ERROR", "74"},                     ' Returned by the DEX protocol handler to indicate an unexpected acoustic message type with the DEX protocol has been received And cannot be processed.  '
        {"ST_CST_DEX_REQ_ERROR", "75"},                        ' Returned by the DEX protocol handler to indicate a error has occurred while responding to a request (i.e. lack of data).  '
        {"ST_CST_DEX_RESP_TMO_ERROR", "76"},                   ' Returned by the DEX protocol handler to indicate a timeout has occurred while waiting for a response back from a remote beacon with requested data.  '
        {"ST_CST_DEX_RESP_MSG_ERROR", "77"},                   ' Returned by the DEX protocol handler to indicate an error has occurred while receiving response back from a remote beacon.  '
        {"ST_CST_DEX_RESP_REMOTE_ERROR", "78"}
        }
        Dim BID As New Dictionary(Of String, String) From {
        {"beacon_id_00", "00"},
        {"beacon_id_01", "01"},
        {"beacon_id_02", "02"},
        {"beacon_id_03", "03"},
        {"beacon_id_04", "04"},
        {"beacon_id_05", "05"},
        {"beacon_id_06", "06"},
        {"beacon_id_07", "07"},
        {"beacon_id_08", "08"},
        {"beacon_id_09", "09"},
        {"beacon_id_10", "0A"},
        {"beacon_id_11", "0B"},
        {"beacon_id_12", "0C"},
        {"beacon_id_13", "0D"},
        {"beacon_id_14", "0E"},
        {"beacon_id_15", "0F"}
        }
        Dim AMSG As New Dictionary(Of String, String) From {
        {"ST_AMSG_OWAY", "00"},                               ' Indicates an acoustic message Is sent One-Way, And does Not require a response. One-Way messages may also be broadcast to all beacons if required. No USBL information Is sent.  ,
        {"ST_AMSG_OWAYU", "01"},                                 ' Indicates an acoustic message is sent One-Way, and does not require a response. One-Way messages may also be broadcast to all beacons if required. Additionally, the message is sent with USBL acoustic information allowing an incoming bearing to be determined by USBL receivers, although range cannot be provided.  ,
        {"ST_AMSG_REQ", "02"},                                   ' Indicates an acoustic message is sent as a Request type. This requires the receiver to generate and return a Response (MSG_RESP) message. No USBL information is requested.  ,
        {"ST_AMSG_RESP", "03"},                                ' Indicates an acoustic message Is sent as a Response to a previous Request message (MSG_REQ). No USBL information Is returned.  ,
        {"ST_AMSG_REQU", "04"},                                 ' Indicates an acoustic message is sent as a Request type. This requires the receiver to generate and return a Response (MSG_RESP) message. Additionally, the Response message should be returned with USBL acoustic information allowing a position fix to be computed by USBL receivers through the range and incoming signal angle.  ,
        {"ST_AMSG_RESPU", "05"},                                ' Indicates an acoustic message is sent as a Response to a previous Request message (MSG_REQ). Additionally, the message is sent with USBL acoustic information allowing the position of the sender to be determined through the range and incoming signal angle.  ,
        {"ST_AMSG_REQX", "06"},                                 ' Indicates an acoustic message is sent as a Request type. This requires the receiver to generate and return a Response (MSG_RESP) message. Additionally, the Response message should be returned with extended Depth and USBL acoustic information allowing a more accurate position fix to be computed by USBL receivers through the range, remote depth and incoming signal angle.  ,
        {"ST_AMSG_RESPX", "07"},                                ' Indicates an acoustic message is sent as a Response to a previous Request message (MSG_REQ). Additionally, the message is sent with extended depth and USBL acoustic information allowing a more accurate position of the sender to be determined through the range, remote depth and incoming signal angle.  ,
        {"ST_AMSG_UNKNOWN", "FF"}
        }
        Dim APLOAD As New Dictionary(Of String, String) From {
        {"ST_APLOAD_PING", "00"},                             ' Specified an acoustic message payload should be interpreted by the PING protocol handler. PING messages provide the simplest (And quickest) method of validating the presence of a beacon, And determining its position.  '
        {"ST_APLOAD_ECHO", "01"},                                ' Specified an acoustic message payload should be interpreted by the ECHO protocol handler. ECHO messages allow the function And reliability of a beacon to be tested, by requesting the payload contents of the message be returned back to the sender.  '
        {"ST_APLOAD_NAV", "02"},                             ' Specified an acoustic message payload should be interpreted by the NAV (Navigation) protocol handler. NAV messages allow tracking and navigation systems to be built that use enhanced positioning and allow remote parameters of beacons (such as heading, attitude, water temperature etc) to be queried.  '
        {"ST_APLOAD_DAT", "03"},                                 ' Specified an acoustic message payload should be interpreted by the DAT (Datagram) protocol handler. DAT messages for the simplest method of data exchange between beacons, And provide a method of acknowledging data reception.  '
        {"ST_APLOAD_DEX", "04"},                                 ' Specified an acoustic message payload should be interpreted by the DEX (Data Exchange) protocol handler. DEX messages implement a protocol that allows robust bi-directional socket based data exchange with timeouts, acknowledgments And retry schemes.  '
        {"ST_APLOAD_UNKNOWN", "FF"}
        }
        Dim STB As New Dictionary(Of String, String) From {
        {"AHRS_COMP_DATA", "05"},
        {"AHRS_RAW_DATA", "04"},
        {"ACC_CAL", "03"},
        {"MAG_CAL", "02"},
        {"ATTITUDE", "01"},
        {"ENVIRONMENT", "00"}
        }

        Return (CID, CST, BID, AMSG, APLOAD, STB)

    End Function
    Public Function Seatrac_Decode(Flag As String, data As String) As (status_encrypt As Dictionary(Of String, String), status_decrypt As Dictionary(Of String, String))
        Dim status_encrypt As New Dictionary(Of String, String)
        Dim status_decrypt As New Dictionary(Of String, String)
        data = data.Remove(data.Length - 4)
        Dim data_check As String = data.Substring(1, 2)
        If Flag = "Status" Then
            If data_check = Seatrac_Command.CID("ST_CID_STATUS") Then

                status_encrypt = New Dictionary(Of String, String) From
                    {
                      {"CmdId", data_check},
                      {"STATUS_OUTPUT", data.Substring(3, 2)},
                      {"TIMESTAMP", data.Substring(5, 16)},
                      {"ENV_SUPPLY", data.Substring(21, 4)},
                      {"ENV_TEMP", data.Substring(25, 4)},
                      {"ENV_PRESSURE", data.Substring(29, 8)},
                      {"ENV_DEPTH", data.Substring(37, 8)},
                      {"ENV_VOS", data.Substring(45, 4)},
                      {"ATT_YAW", data.Substring(49, 4)},
                      {"ATT_PITCH", data.Substring(53, 4)},
                      {"ATT_ROLL", data.Substring(57, 4)},
                      {"MAG_CAL_BUF", data.Substring(61, 2)},
                      {"MAG_CAL_VALID", data.Substring(63, 2)},
                      {"MAG_CAL_AGE", data.Substring(65, 8)},
                      {"MAG_CAL_FIT", data.Substring(73, 2)}
                      }
                '{"ACC_LIM_MIN_X", data.Substring(75, 4)},
                '{"ACC_LIM_MIN_Y", data.Substring(79, 4)},
                '{"ACC_LIM_MIN_Z", data.Substring(83, 4)},
                '{"ACC_LIM_MAX_X", data.Substring(87, 4)},
                '{"ACC_LIM_MAX_Y", data.Substring(91, 4)},
                '{"ACC_LIM_MAX_Z", data.Substring(95, 4)},
                '{"AHRS_RAW_ACC_X", data.Substring(99, 4)},
                '{"AHRS_RAW_ACC_Y", data.Substring(103, 4)},
                '{"AHRS_RAW_ACC_Z", data.Substring(107, 4)},
                '{"AHRS_RAW_MAG_X", data.Substring(111, 4)},
                '{"AHRS_RAW_MAG_Y", data.Substring(115, 4)},
                '{"AHRS_RAW_MAG_Z", data.Substring(119, 4)},
                '{"AHRS_RAW_GYRO_X", data.Substring(123, 4)},
                '{"AHRS_RAW_GYRO_Y", data.Substring(127, 4)},
                '{"AHRS_RAW_GYRO_Z", data.Substring(131, 4)}

                status_decrypt = New Dictionary(Of String, String) From
                    {
                        {"CmdId", check_valut_to_key(Seatrac_Command.CID, status_encrypt("CmdId"))},
                        {"STATUS_OUTPUT", HextoInt(status_encrypt("STATUS_OUTPUT"), True)},
                        {"TIMESTAMP", HextoInt(status_encrypt("TIMESTAMP"), False) / 1000},
                        {"ENV_SUPPLY", HextoInt(status_encrypt("ENV_SUPPLY"), True) / 1000},
                        {"ENV_TEMP", HextoInt(status_encrypt("ENV_TEMP"), True) / 10},
                        {"ENV_PRESSURE", HextoInt(status_encrypt("ENV_PRESSURE"), True) / 1000},
                        {"ENV_DEPTH", HextoInt(status_encrypt("ENV_DEPTH"), True) / 10},
                        {"ENV_VOS", HextoInt(status_encrypt("ENV_VOS"), True) / 10},
                        {"ATT_YAW", HextoInt(status_encrypt("ATT_YAW"), True) / 10},
                        {"ATT_PITCH", HextoInt(status_encrypt("ATT_PITCH"), True) / 10},
                        {"ATT_ROLL", HextoInt(status_encrypt("ATT_ROLL"), True) / 10},
                        {"MAG_CAL_BUF", HextoInt(status_encrypt("MAG_CAL_BUF"), True)},
                        {"MAG_CAL_VALID", data.Substring(63, 2)},
                        {"MAG_CAL_AGE", HextoInt(status_encrypt("MAG_CAL_AGE"), True)},
                        {"MAG_CAL_FIT", HextoInt(status_encrypt("MAG_CAL_FIT"), True) / 100}}
                '{"ACC_LIM_MIN_X", HextoInt(status_encrypt("ACC_LIM_MIN_X"), True)},
                '{"ACC_LIM_MIN_Y", HextoInt(status_encrypt("ACC_LIM_MIN_Y"), True)},
                '{"ACC_LIM_MIN_Z", HextoInt(status_encrypt("ACC_LIM_MIN_Z"), True)},
                '{"ACC_LIM_MAX_X", HextoInt(status_encrypt("ACC_LIM_MAX_X"), True)},
                '{"ACC_LIM_MAX_Y", HextoInt(status_encrypt("ACC_LIM_MAX_Y"), True)},
                '{"ACC_LIM_MAX_Z", HextoInt(status_encrypt("ACC_LIM_MAX_Z"), True)},
                '{"AHRS_RAW_ACC_X", HextoInt(status_encrypt("AHRS_RAW_ACC_X"), True)},
                '{"AHRS_RAW_ACC_Y", HextoInt(status_encrypt("AHRS_RAW_ACC_Y"), True)},
                '{"AHRS_RAW_ACC_Z", HextoInt(status_encrypt("AHRS_RAW_ACC_Z"), True)},
                '{"AHRS_RAW_MAG_X", HextoInt(status_encrypt("AHRS_RAW_MAG_X"), True)},
                '{"AHRS_RAW_MAG_Y", HextoInt(status_encrypt("AHRS_RAW_MAG_Y"), True)},
                '{"AHRS_RAW_MAG_Z", HextoInt(status_encrypt("AHRS_RAW_MAG_Z"), True)},
                '{"AHRS_RAW_GYRO_X", HextoInt(status_encrypt("AHRS_RAW_GYRO_X"), True)},
                '{"AHRS_RAW_GYRO_Y", HextoInt(status_encrypt("AHRS_RAW_GYRO_Y"), True)},
                '{"AHRS_RAW_GYRO_Z", HextoInt(status_encrypt("AHRS_RAW_GYRO_Z"), True)}

            End If
        ElseIf Flag = "Feedback" Then
            If data_check = Seatrac_Command.CID("ST_CID_PING_RESP") Or data_check = Seatrac_Command.CID("ST_CID_XCVR_FIX") Then
                status_encrypt = New Dictionary(Of String, String) From
                    {
                      {"CmdId", data_check},
                      {"DEST_ID", data.Substring(3, 2)},
                      {"SRC_ID", data.Substring(5, 2)},
                      {"FLAGS", data.Substring(7, 2)},
                      {"MSG_TYPE", data.Substring(9, 2)},
                      {"ATTITUDE_YAW", data.Substring(11, 4)},
                      {"ATTITUDE_PITCH", data.Substring(15, 4)},
                      {"ATTITUDE_ROLL", data.Substring(19, 4)},
                      {"DEPTH_LOCAL", data.Substring(23, 4)},
                      {"VOS", data.Substring(27, 4)},
                      {"RSSI", data.Substring(31, 4)},
                      {"RANGE_COUNT", data.Substring(35, 8)},
                      {"RANGE_TIME", data.Substring(43, 8)},
                      {"RANGE_DIST", data.Substring(51, 4)},
                      {"USBL_CHANNELS", data.Substring(55, 2)},
                      {"USBL_RSSI_1", data.Substring(57, 4)},
                      {"USBL_RSSI_2", data.Substring(61, 4)},
                      {"USBL_RSSI_3", data.Substring(65, 4)},
                      {"USBL_RSSI_4", data.Substring(69, 4)},
                      {"USBL_AZIMUTH", data.Substring(73, 4)},
                      {"USBL_ELEVATION", data.Substring(77, 4)},
                      {"USBL_FIT_ERROR", data.Substring(81, 4)},
                      {"POSITION_EASTING", data.Substring(85, 4)},
                      {"POSITION_NORTHING", data.Substring(89, 4)},
                      {"POSITION_DEPTH", data.Substring(93, 4)}
                    }
                status_decrypt = New Dictionary(Of String, String) From
                    {
                      {"CmdId", check_valut_to_key(Seatrac_Command.CID, status_encrypt("CmdId"))},
                      {"DEST_ID", HextoInt(status_encrypt("DEST_ID"), True)},
                      {"SRC_ID", HextoInt(status_encrypt("SRC_ID"), True)},
                      {"FLAGS", data.Substring(7, 2)},
                      {"MSG_TYPE", HextoInt(status_encrypt("MSG_TYPE"), True)},
                      {"ATTITUDE_YAW", HextoInt(status_encrypt("ATTITUDE_YAW"), True) / 10},
                      {"ATTITUDE_PITCH", HextoInt(status_encrypt("ATTITUDE_PITCH"), True) / 10},
                      {"ATTITUDE_ROLL", HextoInt(status_encrypt("ATTITUDE_ROLL"), True) / 10},
                      {"DEPTH_LOCAL", HextoInt(status_encrypt("DEPTH_LOCAL"), True) / 10},
                      {"VOS", HextoInt(status_encrypt("VOS"), True) / 10},
                      {"RSSI", HextoInt(status_encrypt("RSSI"), True) / 10},
                      {"RANGE_COUNT", HextoInt(status_encrypt("RANGE_COUNT"), True)},
                      {"RANGE_TIME", HextoInt(status_encrypt("RANGE_TIME"), True) / 10000000},
                      {"RANGE_DIST", HextoInt(status_encrypt("RANGE_DIST"), True) / 10},
                      {"USBL_CHANNELS", HextoInt(status_encrypt("USBL_CHANNELS"), True) / 10},
                      {"USBL_RSSI_1", HextoInt(status_encrypt("USBL_RSSI_1"), True) / 10},
                      {"USBL_RSSI_2", HextoInt(status_encrypt("USBL_RSSI_2"), True) / 10},
                      {"USBL_RSSI_3", HextoInt(status_encrypt("USBL_RSSI_3"), True) / 10},
                      {"USBL_RSSI_4", HextoInt(status_encrypt("USBL_RSSI_4"), True) / 10},
                      {"USBL_AZIMUTH", HextoInt(status_encrypt("USBL_AZIMUTH"), True) / 10},
                      {"USBL_ELEVATION", HextoInt(status_encrypt("USBL_ELEVATION"), True) / 10},
                      {"USBL_FIT_ERROR", HextoInt(status_encrypt("USBL_FIT_ERROR"), True) / 100},
                      {"POSITION_EASTING", HextoInt(status_encrypt("POSITION_EASTING"), True) / 10},
                      {"POSITION_NORTHING", HextoInt(status_encrypt("POSITION_NORTHING"), True) / 10},
                      {"POSITION_DEPTH", HextoInt(status_encrypt("POSITION_DEPTH"), True) / 10}
                    }
            ElseIf data_check = Seatrac_Command.CID("ST_CID_XCVR_TX_MSG") Then

                status_encrypt = New Dictionary(Of String, String) From
                    {
                        {"CmdId", data_check},
                        {"DEST_ID", data.Substring(3, 2)},
                        {"SRC_ID", data.Substring(5, 2)},
                        {"MSG_TYPE", data.Substring(7, 2)}
                        }


                status_decrypt = New Dictionary(Of String, String) From
                    {
                        {"CmdId", check_valut_to_key(Seatrac_Command.CID, status_encrypt("CmdId"))},
                        {"DEST_ID", HextoInt(status_encrypt("DEST_ID"), True)},
                        {"SRC_ID", HextoInt(status_encrypt("SRC_ID"), True)},
                        {"MSG_TYPE", HextoInt(status_encrypt("MSG_TYPE"), True)}
                        }


            ElseIf data_check = Seatrac_Command.CID("ST_CID_XCVR_RX_RESP") Then
                status_encrypt = New Dictionary(Of String, String) From
                        {
                          {"CmdId", data_check},
                          {"DEST_ID", data.Substring(3, 2)},
                          {"SRC_ID", data.Substring(5, 2)},
                          {"FLAGS", data.Substring(7, 2)},
                          {"HDR_MSG_TYPE", data.Substring(9, 2)},
                          {"ATTITUDE_YAW", data.Substring(11, 4)},
                          {"ATTITUDE_PITCH", data.Substring(15, 4)},
                          {"ATTITUDE_ROLL", data.Substring(19, 4)},
                          {"DEPTH_LOCAL", data.Substring(23, 4)},
                          {"VOS", data.Substring(27, 4)},
                          {"RSSI", data.Substring(31, 4)},
                          {"RANGE_COUNT", data.Substring(35, 8)},
                          {"RANGE_TIME", data.Substring(43, 8)},
                          {"RANGE_DIST", data.Substring(51, 4)},
                          {"USBL_CHANNELS", data.Substring(55, 2)},
                          {"USBL_RSSI_1", data.Substring(57, 4)},
                          {"USBL_RSSI_2", data.Substring(61, 4)},
                          {"USBL_RSSI_3", data.Substring(65, 4)},
                          {"USBL_RSSI_4", data.Substring(69, 4)},
                          {"USBL_AZIMUTH", data.Substring(73, 4)},
                          {"USBL_ELEVATION", data.Substring(77, 4)},
                          {"USBL_FIT_ERROR", data.Substring(81, 4)},
                          {"POSITION_EASTING", data.Substring(85, 4)},
                          {"POSITION_NORTHING", data.Substring(89, 4)},
                          {"POSITION_DEPTH", data.Substring(93, 4)},
                          {"MSG_DEST_ID", data.Substring(97, 2)},
                          {"MSG_SRC_ID", data.Substring(99, 2)},
                          {"MSG_TYPE", data.Substring(101, 2)},
                          {"MSG_DEPTH", data.Substring(103, 4)},
                          {"MSG_PAYLOAD_ID", data.Substring(107, 2)},
                          {"MSG_PAYLOAD_LEN", data.Substring(109, 2)},
                          {"MSG_PAYLOAD", data.Substring(111)}
                        }
                status_decrypt = New Dictionary(Of String, String) From
                        {
                          {"CmdId", check_valut_to_key(Seatrac_Command.CID, status_encrypt("CmdId"))},
                          {"DEST_ID", HextoInt(status_encrypt("DEST_ID"), True)},
                          {"SRC_ID", HextoInt(status_encrypt("SRC_ID"), True)},
                          {"FLAGS", data.Substring(7, 2)},
                          {"HDR_MSG_TYPE", HextoInt(status_encrypt("HDR_MSG_TYPE"), True)},
                          {"ATTITUDE_YAW", HextoInt(status_encrypt("ATTITUDE_YAW"), True) / 10},
                          {"ATTITUDE_PITCH", HextoInt(status_encrypt("ATTITUDE_PITCH"), True) / 10},
                          {"ATTITUDE_ROLL", HextoInt(status_encrypt("ATTITUDE_ROLL"), True) / 10},
                          {"DEPTH_LOCAL", HextoInt(status_encrypt("DEPTH_LOCAL"), True) / 10},
                          {"VOS", HextoInt(status_encrypt("VOS"), True) / 10},
                          {"RSSI", HextoInt(status_encrypt("RSSI"), True) / 10},
                          {"RANGE_COUNT", HextoInt(status_encrypt("RANGE_COUNT"), True)},
                          {"RANGE_TIME", HextoInt(status_encrypt("RANGE_TIME"), True) / 10000000},
                          {"RANGE_DIST", HextoInt(status_encrypt("RANGE_DIST"), True) / 10},
                          {"USBL_CHANNELS", HextoInt(status_encrypt("USBL_CHANNELS"), True) / 10},
                          {"USBL_RSSI_1", HextoInt(status_encrypt("USBL_RSSI_1"), True) / 10},
                          {"USBL_RSSI_2", HextoInt(status_encrypt("USBL_RSSI_2"), True) / 10},
                          {"USBL_RSSI_3", HextoInt(status_encrypt("USBL_RSSI_3"), True) / 10},
                          {"USBL_RSSI_4", HextoInt(status_encrypt("USBL_RSSI_4"), True) / 10},
                          {"USBL_AZIMUTH", HextoInt(status_encrypt("USBL_AZIMUTH"), True) / 10},
                          {"USBL_ELEVATION", HextoInt(status_encrypt("USBL_ELEVATION"), True) / 10},
                          {"USBL_FIT_ERROR", HextoInt(status_encrypt("USBL_FIT_ERROR"), True) / 100},
                          {"POSITION_EASTING", HextoInt(status_encrypt("POSITION_EASTING"), True) / 10},
                          {"POSITION_NORTHING", HextoInt(status_encrypt("POSITION_NORTHING"), True) / 10},
                          {"POSITION_DEPTH", HextoInt(status_encrypt("POSITION_DEPTH"), True) / 10},
                          {"MSG_DEST_ID", HextoInt(status_encrypt("MSG_DEST_ID"), True)},
                          {"MSG_SRC_ID", HextoInt(status_encrypt("MSG_SRC_ID"), True)},
                          {"MSG_TYPE", data.Substring(101, 2)},
                          {"MSG_DEPTH", HextoInt(status_encrypt("MSG_DEPTH"), True) / 2},
                          {"MSG_PAYLOAD_ID", HextoInt(status_encrypt("MSG_PAYLOAD_ID"), True)},
                          {"MSG_PAYLOAD_LEN", HextoInt(status_encrypt("MSG_PAYLOAD_LEN"), True)},
                          {"MSG_PAYLOAD", HextoStr(status_encrypt("MSG_PAYLOAD"))}
                        }

            ElseIf data_check = Seatrac_Command.CID("ST_CID_SYS_ALIVE") Then
                status_encrypt = New Dictionary(Of String, String) From
                        {
                          {"CmdId", data_check},
                          {"MSG_PAYLOAD", data.Substring(3, 8)}
                        }
                status_decrypt = New Dictionary(Of String, String) From
                    {
                      {"CmdId", check_valut_to_key(Seatrac_Command.CID, status_encrypt("CmdId"))},
                      {"Timestamp", HextoStr(status_encrypt("MSG_PAYLOAD")) / 1000}
                }
            ElseIf data_check = Seatrac_Command.CID("ST_CID_XCVR_RX_REQ") Then
                status_encrypt = New Dictionary(Of String, String) From
                        {
                          {"CmdId", data_check},
                          {"DEST_ID", data.Substring(3, 2)},
                          {"SRC_ID", data.Substring(5, 2)},
                          {"FLAGS", data.Substring(7, 2)},
                          {"HDR_MSG_TYPE", data.Substring(9, 2)},
                          {"ATTITUDE_YAW", data.Substring(11, 4)},
                          {"ATTITUDE_PITCH", data.Substring(15, 4)},
                          {"ATTITUDE_ROLL", data.Substring(19, 4)},
                          {"DEPTH_LOCAL", data.Substring(23, 4)},
                          {"VOS", data.Substring(27, 4)},
                          {"RSSI", data.Substring(31, 4)},
                          {"RANGE_COUNT", data.Substring(35, 4)},
                          {"RANGE_TIME", data.Substring(39, 4)},
                          {"RANGE_DIST", data.Substring(43, 4)},
                          {"MSG_PAYLOAD_LEN", data.Substring(48, 2)},
                          {"MSG_PAYLOAD", data.Substring(49)}
                        }
                status_decrypt = New Dictionary(Of String, String) From
                        {
                          {"CmdId", check_valut_to_key(Seatrac_Command.CID, status_encrypt("CmdId"))},
                          {"DEST_ID", HextoInt(status_encrypt("DEST_ID"), True)},
                          {"SRC_ID", HextoInt(status_encrypt("SRC_ID"), True)},
                          {"FLAGS", data.Substring(7, 2)},
                          {"HDR_MSG_TYPE", HextoInt(status_encrypt("HDR_MSG_TYPE"), True)},
                          {"ATTITUDE_YAW", HextoInt(status_encrypt("ATTITUDE_YAW"), True) / 10},
                          {"ATTITUDE_PITCH", HextoInt(status_encrypt("ATTITUDE_PITCH"), True) / 10},
                          {"ATTITUDE_ROLL", HextoInt(status_encrypt("ATTITUDE_ROLL"), True) / 10},
                          {"DEPTH_LOCAL", HextoInt(status_encrypt("DEPTH_LOCAL"), True) / 10},
                          {"VOS", HextoInt(status_encrypt("VOS"), True) / 10},
                          {"RSSI", HextoInt(status_encrypt("RSSI"), True) / 10},
                          {"RANGE_COUNT", HextoInt(status_encrypt("RANGE_COUNT"), True)},
                          {"RANGE_TIME", HextoInt(status_encrypt("RANGE_TIME"), True) / 10000000},
                          {"MSG_PAYLOAD_LEN", HextoInt(status_encrypt("MSG_PAYLOAD_LEN"), True)},
                          {"MSG_PAYLOAD", HextoStr(status_encrypt("MSG_PAYLOAD"))}
                        }
            ElseIf data_check = Seatrac_Command.CID("ST_CID_PING_ERROR") Then
                status_encrypt = New Dictionary(Of String, String) From
                        {
                          {"CmdId", data_check}
                        }
                status_decrypt = New Dictionary(Of String, String) From
                        {
                          {"CmdId", check_valut_to_key(Seatrac_Command.CID, status_encrypt("CmdId"))}
                        }
            ElseIf data_check = Seatrac_Command.CID("ST_CID_PING_REQ") Then
                status_encrypt = New Dictionary(Of String, String) From
                        {
                          {"CmdId", data_check},
                          {"DEST_ID", data.Substring(3, 2)},
                          {"SRC_ID", data.Substring(5, 2)},
                          {"FLAGS", data.Substring(7, 2)},
                          {"HDR_MSG_TYPE", data.Substring(9, 2)},
                          {"ATTITUDE_YAW", data.Substring(11, 4)},
                          {"ATTITUDE_PITCH", data.Substring(15, 4)},
                          {"ATTITUDE_ROLL", data.Substring(19, 4)},
                          {"DEPTH_LOCAL", data.Substring(23, 4)},
                          {"VOS", data.Substring(27, 4)},
                          {"RSSI", data.Substring(31, 4)}
                        }
                status_decrypt = New Dictionary(Of String, String) From
                        {
                          {"CmdId", check_valut_to_key(Seatrac_Command.CID, status_encrypt("CmdId"))},
                          {"DEST_ID", HextoInt(status_encrypt("DEST_ID"), True)},
                          {"SRC_ID", HextoInt(status_encrypt("SRC_ID"), True)},
                          {"FLAGS", data.Substring(7, 2)},
                          {"HDR_MSG_TYPE", HextoInt(status_encrypt("HDR_MSG_TYPE"), True)},
                          {"ATTITUDE_YAW", HextoInt(status_encrypt("ATTITUDE_YAW"), True) / 10},
                          {"ATTITUDE_PITCH", HextoInt(status_encrypt("ATTITUDE_PITCH"), True) / 10},
                          {"ATTITUDE_ROLL", HextoInt(status_encrypt("ATTITUDE_ROLL"), True) / 10},
                          {"DEPTH_LOCAL", HextoInt(status_encrypt("DEPTH_LOCAL"), True) / 10},
                          {"VOS", HextoInt(status_encrypt("VOS"), True) / 10},
                          {"RSSI", HextoInt(status_encrypt("RSSI"), True) / 10}
                        }
            ElseIf data_check = Seatrac_Command.CID("ST_CID_NAV_STATUS_SEND") Then
                status_encrypt = New Dictionary(Of String, String) From
                        {
                          {"CmdId", data_check},
                          {"STATUS", data.Substring(3, 2)},
                          {"BEACON_ID", data.Substring(5, 2)}
                        }
                status_decrypt = New Dictionary(Of String, String) From
                        {
                          {"CmdId", check_valut_to_key(Seatrac_Command.CID, status_encrypt("CmdId"))},
                          {"STATUS", check_valut_to_key(Seatrac_Command.CID, status_encrypt("STATUS"))},
                          {"BEACON_ID", HextoInt(status_encrypt("BEACON_ID"), True)}
                        }
            ElseIf data_check = Seatrac_Command.CID("ST_CID_XCVR_RX_MSG") Then
                status_encrypt = New Dictionary(Of String, String) From
                        {
                          {"CmdId", data_check},
                          {"DEST_ID", data.Substring(3, 2)},
                          {"SRC_ID", data.Substring(5, 2)},
                          {"FLAGS", data.Substring(7, 2)},
                          {"HDR_MSG_TYPE", data.Substring(9, 2)},
                          {"ATTITUDE_YAW", data.Substring(11, 4)},
                          {"ATTITUDE_PITCH", data.Substring(15, 4)},
                          {"ATTITUDE_ROLL", data.Substring(19, 4)},
                          {"DEPTH_LOCAL", data.Substring(23, 4)},
                          {"VOS", data.Substring(27, 4)},
                          {"RSSI", data.Substring(31, 4)},
                          {"MSG_DEST_ID", data.Substring(35, 2)},
                          {"MSG_SRC_ID", data.Substring(37, 2)},
                          {"MSG_TYPE", data.Substring(39, 2)},
                          {"MSG_DEPTH", data.Substring(41, 4)},
                          {"MSG_PAYLOAD_ID", data.Substring(45, 2)},
                          {"MSG_PAYLOAD_LEN", data.Substring(47, 2)},
                          {"MSG_PAYLOAD", data.Substring(49)}
                        }

                status_decrypt = New Dictionary(Of String, String) From
                        {
                          {"CmdId", check_valut_to_key(Seatrac_Command.CID, status_encrypt("CmdId"))},
                          {"DEST_ID", HextoInt(status_encrypt("DEST_ID"), True)},
                          {"SRC_ID", HextoInt(status_encrypt("SRC_ID"), True)},
                          {"FLAGS", data.Substring(7, 2)},
                          {"HDR_MSG_TYPE", HextoInt(status_encrypt("HDR_MSG_TYPE"), True)},
                          {"ATTITUDE_YAW", HextoInt(status_encrypt("ATTITUDE_YAW"), True) / 10},
                          {"ATTITUDE_PITCH", HextoInt(status_encrypt("ATTITUDE_PITCH"), True) / 10},
                          {"ATTITUDE_ROLL", HextoInt(status_encrypt("ATTITUDE_ROLL"), True) / 10},
                          {"DEPTH_LOCAL", HextoInt(status_encrypt("DEPTH_LOCAL"), True) / 10},
                          {"VOS", HextoInt(status_encrypt("VOS"), True) / 10},
                          {"RSSI", HextoInt(status_encrypt("RSSI"), True) / 10},
                          {"MSG_DEST_ID", HextoInt(status_encrypt("MSG_DEST_ID"), True)},
                          {"MSG_SRC_ID", HextoInt(status_encrypt("MSG_SRC_ID"), True)},
                          {"MSG_TYPE", data.Substring(101, 2)},
                          {"MSG_DEPTH", HextoInt(status_encrypt("MSG_DEPTH"), True) / 2},
                          {"MSG_PAYLOAD_ID", HextoInt(status_encrypt("MSG_PAYLOAD_ID"), True)},
                          {"MSG_PAYLOAD_LEN", HextoInt(status_encrypt("MSG_PAYLOAD_LEN"), True)},
                          {"MSG_PAYLOAD", HextoStr(status_encrypt("MSG_PAYLOAD"))}
                        }
            ElseIf data_check = Seatrac_Command.CID("ST_CID_NAV_STATUS_RECEIVE") Then
                data = data.Remove(data.Length - 2)
                status_encrypt = New Dictionary(Of String, String) From
                        {
                          {"CmdId", data_check},
                          {"DEST_ID", data.Substring(3, 2)},
                          {"SRC_ID", data.Substring(5, 2)},
                          {"FLAGS", data.Substring(7, 2)},
                          {"HDR_MSG_TYPE", data.Substring(9, 2)},
                          {"ATTITUDE_YAW", data.Substring(11, 4)},
                          {"ATTITUDE_PITCH", data.Substring(15, 4)},
                          {"ATTITUDE_ROLL", data.Substring(19, 4)},
                          {"DEPTH_LOCAL", data.Substring(23, 4)},
                          {"VOS", data.Substring(27, 4)},
                          {"RSSI", data.Substring(31, 4)},
                          {"BEACON_ID", data.Substring(35, 2)},
                          {"MSG_PAYLOAD_LEN", data.Substring(37, 2)},
                          {"MSG_PAYLOAD", data.Substring(39)}
                        }
                status_decrypt = New Dictionary(Of String, String) From
                        {
                          {"CmdId", check_valut_to_key(Seatrac_Command.CID, status_encrypt("CmdId"))},
                          {"DEST_ID", HextoInt(status_encrypt("DEST_ID"), True)},
                          {"SRC_ID", HextoInt(status_encrypt("SRC_ID"), True)},
                          {"FLAGS", data.Substring(7, 2)},
                          {"HDR_MSG_TYPE", HextoInt(status_encrypt("HDR_MSG_TYPE"), True)},
                          {"ATTITUDE_YAW", HextoInt(status_encrypt("ATTITUDE_YAW"), True) / 10},
                          {"ATTITUDE_PITCH", HextoInt(status_encrypt("ATTITUDE_PITCH"), True) / 10},
                          {"ATTITUDE_ROLL", HextoInt(status_encrypt("ATTITUDE_ROLL"), True) / 10},
                          {"DEPTH_LOCAL", HextoInt(status_encrypt("DEPTH_LOCAL"), True) / 10},
                          {"VOS", HextoInt(status_encrypt("VOS"), True) / 10},
                          {"RSSI", HextoInt(status_encrypt("RSSI"), True) / 10},
                          {"BEACON_ID", HextoInt(status_encrypt("BEACON_ID"), True)},
                          {"MSG_PAYLOAD_LEN", HextoInt(status_encrypt("MSG_PAYLOAD_LEN"), True)},
                          {"MSG_PAYLOAD", HextoStr(status_encrypt("MSG_PAYLOAD"))}
                        }
            End If
        End If

        Return (status_encrypt, status_decrypt)

    End Function

End Module

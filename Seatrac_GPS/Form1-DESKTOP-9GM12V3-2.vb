Imports System
Imports MapWinGIS
Imports AxMapWinGIS
Imports System.IO.Ports
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Threading
Imports System.ComponentModel
Imports System.Security.Cryptography
Imports System.Timers
Imports Microsoft.VisualBasic.Logging
Imports System.Text

Public Class Form1


    Dim handle_Seatrac As Integer = 1
    Dim handle_Pin As Integer

    Dim sf_GPS As New Shapefile()
    Dim GPS_layer As Integer

    Dim utils As New Utils()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tab_SeatracNavigate.Enabled = False
        AxMap1.Latitude = 13.8218784
        AxMap1.Longitude = 100.512833
        AxMap1.CurrentZoom = 5
        AxMap1.GrabProjectionFromData = True
        handle_Seatrac = AxMap1.NewDrawing(tkDrawReferenceList.dlSpatiallyReferencedList)

        Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
        Try
            cmb_GPSPort.Items.AddRange(IO.Ports.SerialPort.GetPortNames())
            cmb_GPSPort.SelectedIndex = 0
            cmb_GPSBaud.SelectedItem = "4800"

            cmb_SeatracPort.Items.AddRange(IO.Ports.SerialPort.GetPortNames())
            cmb_SeatracPort.SelectedIndex = 1
            cmb_SeatracBaud.SelectedItem = "115200"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'Map_Point_marker(13.8218784, 100.512833)

        'Dim text As String = "$390F018F07540A68014FF900002B3CEA04E1030000905000000F0004EA04DC043A050D0558026201B902F8FFF3FF0000EFC4"
        'Received_Seatrac(text)

    End Sub

    Private Sub btn_GPS_Connect_Click(sender As Object, e As EventArgs) Handles btn_GPS_Connect.Click
        If btn_GPS_Connect.Text = "Connect" Then
            port_GPS.BaudRate = Val(cmb_GPSBaud.SelectedItem)
            port_GPS.PortName = cmb_GPSPort.SelectedItem
            Try
                port_GPS.Open()

                btn_GPS_Connect.Text = "Disconnect"
                cmb_GPSPort.Enabled = False
                cmb_GPSBaud.Enabled = False
                go_GPS.Enabled = True
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            Try
                port_GPS.Close()
                txt_OffsetX.Text = 0
                txt_OffsetY.Text = 0

                cmb_GPSPort.Enabled = True
                cmb_GPSBaud.Enabled = True
                go_GPS.Enabled = False
                btn_GPS_Connect.Text = "Connect"

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub


    Private Sub port_GPS_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles port_GPS.DataReceived
        Try
            Dim text As String = port_GPS.ReadLine()
            Received_GPS(text)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        'Thread.Sleep(3000)
    End Sub
    Private Sub Received_GPS(ByVal [text] As String)

        NMEA_decode(text)

        Dim result_gps As String = "Satellites : " + GPGGA_data.Satellites + vbCrLf +
                                    "Latitude   : " + GPGGA_data.Latitude_Decimal + vbCrLf +
                                    "Longitude  : " + GPGGA_data.Longitude_Decimal

        RichTextBox1.Text = result_gps

        'handle_GPS = AxMap1.NewDrawing(tkDrawReferenceList.dlSpatiallyReferencedList)
        Dim offset_X As Double = txt_OffsetX.Text
        Dim offset_Y As Double = txt_OffsetY.Text

        Calc_robot_position(GPGGA_data.Latitude_Decimal, GPGGA_data.Longitude_Decimal, offset_Y, offset_X)
        Dim mercator = DecimalTometer(robot_lat, robot_long)
        'Dim mercator = DecimalTometer(GPGGA_data.Latitude_Decimal, GPGGA_data.Longitude_Decimal)
        'AxMap1.DrawLabelEx(handle_GPS, "GPS", mercator.x, mercator.y, 0)
        'AxMap1.DrawCircleEx(handle_GPS, mercator.x, mercator.y, 2, 100, True)

        Dim img As New Image()

        img.Open(Application.StartupPath + "\blu-blank.png", ImageType.USE_FILE_EXTENSION)
        Dim reasult As Boolean = sf_GPS.CreateNew("", ShpfileType.SHP_POINT)
        sf_GPS.DefaultDrawingOptions.PointType = tkPointSymbolType.ptSymbolPicture
        sf_GPS.DefaultDrawingOptions.Picture = img


        Dim shp As New Shape()
        shp.Create(ShpfileType.SHP_POINT)
        shp.AddPoint(mercator.x, mercator.y)
        sf_GPS.EditAddShape(shp)
        GPS_layer = AxMap1.AddLayer(sf_GPS, True)
        'AxMap1.get_LayerName(sf_GPS)

    End Sub
    Private Sub btn_Seatrac_Connect_Click(sender As Object, e As EventArgs) Handles btn_Seatrac_Connect.Click
        If btn_Seatrac_Connect.Text = "Connect" Then
            port_Seatrac.BaudRate = Val(cmb_SeatracBaud.SelectedItem)
            port_Seatrac.PortName = cmb_SeatracPort.SelectedItem

            Try
                port_Seatrac.Open()
                btn_Seatrac_Connect.Text = "Disconnect"
                cmb_SeatracPort.Enabled = False
                cmb_SeatracBaud.Enabled = False
                btn_Ping.Enabled = True
                tab_SeatracNavigate.Enabled = True

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        Else

            port_Seatrac.Close()

            'GroupBox1.Enabled = False
            cmb_SeatracBaud.Enabled = True
            cmb_SeatracPort.Enabled = True
            btn_Ping.Enabled = False
            tab_SeatracNavigate.Enabled = False
            btn_Seatrac_Connect.Text = "Connect"

        End If
    End Sub

    Private Sub port_Seatrac_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles port_Seatrac.DataReceived
        Dim text As String = port_Seatrac.ReadLine()
        Dim text_sub As String = text
        If text <> "" Then
            Debug.Print("Serial text : " & text)
            Debug.Print("Lengh text : " & text.Length())



            If text_sub.Substring(0, 3) = "$42" And text.Length() > 100 Then
                Dim result As (status_encrypt As Dictionary(Of String, String), status_decrypt As Dictionary(Of String, String)) = Seatrac_Decode("Feedback", text)
                Dim status_encrypt As Dictionary(Of String, String) = result.status_encrypt
                Dim status_decrypt As Dictionary(Of String, String) = result.status_decrypt
                Debug.Print("Test")
                Read_ping_data(status_decrypt)
            End If
            If text_sub.Substring(0, 3) = "$5C" Then
                Dim result As (status_encrypt As Dictionary(Of String, String), status_decrypt As Dictionary(Of String, String)) = Seatrac_Decode("Feedback", text)
                Dim status_encrypt As Dictionary(Of String, String) = result.status_encrypt
                Dim status_decrypt As Dictionary(Of String, String) = result.status_decrypt
                Read_Feedback_Data(status_decrypt)

            End If
        End If
    End Sub
    Dim count As Integer = 0
    Private Sub Read_ping_data(ByVal status_decrypt As Dictionary(Of String, String))
        'text = "$390F018F07540A68014FF900002B3CEA04E1030000905000000F0004EA04DC043A050D0558026201B902F8FFF3FF0000EFC4"

        'Dim text As String = "$101F901A3E0000000000DF5CFA000000000000000000F03B98FFACFE880332FFE50F00005EFAFEDDFEB7FF5F002801B800D4FFFF00D4FF8FFE19008F0076000B00FCFFFD5D"
        'MessageBox.Show(text)
        'Debug.Print("Serial input = " & text)

        If status_decrypt.ContainsKey("POSITION_NORTHING") And status_decrypt.ContainsKey("POSITION_EASTING") And status_decrypt.ContainsKey("POSITION_DEPTH") Then
            'If True Then
            'MessageBox.Show(GPGGA_data.Latitude_Decimal + GPGGA_data.Longitude_Decimal)
            'count = count + 1
            Dim GPGGA_data_Latitude As Double
            Dim GPGGA_data_Longitude As Double
            Double.TryParse(GPGGA_data.Latitude_Decimal, GPGGA_data_Latitude)
            Double.TryParse(GPGGA_data.Longitude_Decimal, GPGGA_data_Longitude)
            Dim offset_X As Double = txt_OffsetX.Text
            Dim offset_Y As Double = txt_OffsetY.Text

            'Calc_robot_position(GPGGA_data_Latitude, GPGGA_data_Longitude, status_decrypt("POSITION_NORTHING") + offset_Y, status_decrypt("POSITION_EASTING") + offset_X)
            Calc_robot_position_yaw_depth(GPGGA_data_Latitude, GPGGA_data_Longitude, status_decrypt("POSITION_NORTHING") + offset_Y, status_decrypt("POSITION_EASTING") + offset_X, status_decrypt("ATTITUDE_YAW"), status_decrypt("POSITION_DEPTH"))
            Dim position As New Dictionary(Of String, String) From {
            {"EASTING", status_decrypt("POSITION_EASTING")},
            {"NORTHING", status_decrypt("POSITION_NORTHING")},
            {"DEPTH", status_decrypt("POSITION_DEPTH")},
            {"ATTITUDE_YAW", status_decrypt("ATTITUDE_YAW")},
            {"LATITUDE", robot_lat},
            {"LONGTITUDE", robot_long},
            {"LATITUDE_TRANS", robot_lat_trans},
            {"LONGTITUDE_TRANS", robot_long_trans},
            {" ", " "}
            }

            For Each kvp In position.Select(Function(x, i) New With {i, x})
                Dim item As New ListViewItem(kvp.x.Key)
                item.SubItems.Add(kvp.x.Value)
                ListView1.Items.Add(item)

            Next

            port_Seatrac.Write(send_data_command("beacon_id_01", robot_lat_trans.ToString + " " + robot_long_trans.ToString) & vbCr)

            'Debug.Print(GetHexString(robot_lat_trans) + "," + GetHexString(robot_long_trans))
            Dim mercator = DecimalTometer(position("LATITUDE"), position("LONGTITUDE"))
            Dim mercator_trans = DecimalTometer(position("LATITUDE_TRANS"), position("LONGTITUDE_TRANS"))
            AxMap1.DrawCircleEx(handle_Seatrac, mercator.x, mercator.y, 2, &HFF00, True)
            AxMap1.DrawCircleEx(handle_Seatrac, mercator_trans.x, mercator_trans.y, 2, &H5317E8, True)

        End If

    End Sub

    Private Sub Read_Feedback_Data(ByVal status_decrypt As Dictionary(Of String, String))

        If status_decrypt.ContainsKey("MSG_PAYLOAD") Then

            If status_decrypt("MSG_PAYLOAD") = "Received" Then
                MessageBox.Show("X010 confirm received data")
            End If
        End If
    End Sub
    Private Sub btn_MoveMap_Click(sender As Object, e As EventArgs) Handles btn_MoveMap.Click
        AxMap1.CursorMode = MapWinGIS.tkCursorMode.cmPan

    End Sub

    Private Sub btn_ZoomOutMap_Click(sender As Object, e As EventArgs) Handles btn_ZoomOutMap.Click
        AxMap1.CursorMode = MapWinGIS.tkCursorMode.cmZoomOut
    End Sub
    Private Sub btn_ZoomInMap_Click(sender As Object, e As EventArgs) Handles btn_ZoomInMap.Click
        AxMap1.CursorMode = MapWinGIS.tkCursorMode.cmZoomIn
    End Sub
    Private Sub bnt_MeasureMap_Click(sender As Object, e As EventArgs) Handles bnt_MeasureMap.Click
        AxMap1.CursorMode = MapWinGIS.tkCursorMode.cmMeasure
    End Sub

    Private Sub btn_AreaMap_Click(sender As Object, e As EventArgs) Handles btn_AreaMap.Click
        AxMap1.CursorMode = MapWinGIS.tkCursorMode.cmMeasure
        AxMap1.Measuring.MeasuringType = MapWinGIS.tkMeasuringType.MeasureArea
    End Sub
    Private Sub map_OpenStreetMap_Click(sender As Object, e As EventArgs) Handles map_OpenStreetMap.Click
        AxMap1.TileProvider = MapWinGIS.tkTileProvider.OpenStreetMap
    End Sub

    Private Sub map_OpenHumanitarianMap_Click(sender As Object, e As EventArgs) Handles map_OpenHumanitarianMap.Click
        AxMap1.TileProvider = MapWinGIS.tkTileProvider.OpenHumanitarianMap
    End Sub
    Private Sub go_KMUTNB_Click(sender As Object, e As EventArgs) Handles go_KMUTNB.Click
        AxMap1.Latitude = 13.8218784
        AxMap1.Longitude = 100.512833
        AxMap1.CurrentZoom = 17
    End Sub

    Private Sub btn_ClearDrawing_Click(sender As Object, e As EventArgs) Handles btn_ClearSeatrac.Click
        'AxMap1.ClearDrawings()
        AxMap1.ClearDrawing(handle_Seatrac)
        'AxMap1.Redraw()
        handle_Seatrac = AxMap1.NewDrawing(tkDrawReferenceList.dlSpatiallyReferencedList)
    End Sub
    Private Sub btn_ClearGPS_Click(sender As Object, e As EventArgs) Handles btn_ClearGPS.Click
        AxMap1.RemoveLayer(GPS_layer)
    End Sub
    Private Sub btn_ClearPin_Click(sender As Object, e As EventArgs) Handles btn_ClearPin.Click
        AxMap1.ClearDrawing(handle_Pin)
        ListView2.Items.Clear()
    End Sub

    Private Sub go_GPS_Click(sender As Object, e As EventArgs) Handles go_GPS.Click
        Dim offset_X As Double = txt_OffsetX.Text
        Dim offset_Y As Double = txt_OffsetY.Text
        Calc_robot_position(GPGGA_data.Latitude_Decimal, GPGGA_data.Longitude_Decimal, offset_Y, offset_X)
        AxMap1.Latitude = robot_lat
        AxMap1.Longitude = robot_long
        AxMap1.CurrentZoom = 19
    End Sub

    Private Sub txt_OffsetX_TextChanged(sender As Object, e As EventArgs)
        If Not IsNumeric(txt_OffsetX.Text) And txt_OffsetX.Text IsNot "" Then
            txt_OffsetX.Text = "0"
            'txt_Radius.ForeColor = Color.Gray
        ElseIf txt_OffsetX.Text Is "" Then
            txt_OffsetX.Text = "0"
        End If

    End Sub

    Private Sub txt_OffsetY_TextChanged(sender As Object, e As EventArgs)
        If Not IsNumeric(txt_OffsetY.Text) And txt_OffsetY.Text IsNot "" Then
            txt_OffsetY.Text = "0"
            'txt_Radius.ForeColor = Color.Gray
        ElseIf txt_OffsetY.Text Is "" Then
            txt_OffsetY.Text = "0"
        End If

    End Sub

    Private Sub btn_Ping_Click(sender As Object, e As EventArgs) Handles btn_Ping.Click
        If btn_Ping.Text = "Ping" Then
            'Dim timer As New Timer()

            btn_Seatrac_Connect.Enabled = False
            btn_GPS_Connect.Enabled = False
            If Not IsNumeric(txt_PingInterval.Text) And txt_PingInterval.Text IsNot "" Then
                Timer1.Interval = 5 * 1000
            ElseIf txt_PingInterval.Text Is "" Then
                Timer1.Interval = 5 * 1000
            Else
                Timer1.Interval = txt_PingInterval.Text * 1000
            End If


            Timer1.Start()
            btn_Ping.Text = "Stop"

        ElseIf btn_Ping.Text = "Stop" Then
            Timer1.Stop()
            btn_Seatrac_Connect.Enabled = True
            btn_GPS_Connect.Enabled = True
            btn_Ping.Text = "Ping"
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If btn_Ping.Text = "Stop" Then
            Try
                port_Seatrac.Write(ping_command("ST_CID_PING_SEND", "beacon_id_01", "ST_AMSG_REQX") & vbCr)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            port_Seatrac.Write(send_data_command("beacon_id_01", txt_SeatracData.Text) & vbCr)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub AxMap1_MouseDownEvent(sender As Object, e As _DMapEvents_MouseDownEvent) Handles AxMap1.MouseDownEvent
        Dim Pin_Location As New Dictionary(Of String, String)

        If e.button = 1 And btn_SeatracPin.Text = "Stop" Then
            Dim mouse_x As Double
            Dim mouse_y As Double
            Dim mouse_lat_degree As Double
            Dim mouse_lon_degree As Double
            Dim shp As New Shape()
            shp.Create(ShpfileType.SHP_POINT)

            AxMap1.PixelToProj(e.x, e.y, mouse_x, mouse_y)

            AxMap1.DrawCircleEx(handle_Pin, mouse_x, mouse_y, 2, &H870FF, True)
            'Debug.Print(utils.ColorByName(tkMapColor.Blue))
            AxMap1.ProjToDegrees(mouse_x, mouse_y, mouse_lon_degree, mouse_lat_degree)
            Pin_Location.Add(Math.Round(mouse_lat_degree, 8), Math.Round(mouse_lon_degree, 8))
            'ListView2.Clear()

            For Each kvp In Pin_Location.Select(Function(x, i) New With {i, x})
                Dim item As New ListViewItem(kvp.x.Key)
                item.SubItems.Add(kvp.x.Value)
                ListView2.Items.Add(item)

            Next
        End If
    End Sub

    Private Sub btn_SeatracPin_Click(sender As Object, e As EventArgs) Handles btn_SeatracPin.Click
        If btn_SeatracPin.Text = "Stop" Then
            AxMap1.CursorMode = tkCursorMode.cmPan
            btn_SeatracPin.Text = "Pin"

        Else
            btn_SeatracPin.Text = "Stop"
            AxMap1.CursorMode = tkCursorMode.cmMeasure
        End If
    End Sub

    Private Sub btn_SeatracSendPin_Click(sender As Object, e As EventArgs) Handles btn_SeatracSendPin.Click
        'Debug.Print(ListView2.Items(0).SubItems(0).Text)
        'Debug.Print(ListView2.Items(0).SubItems(1).Text)
        If ListView2.Items.Count > 0 Then
            'Debug.Print(ListView2.Items.Count)
            port_Seatrac.Write(send_data_command("beacon_id_01", "Start") & vbCr)
            Thread.Sleep(3000)
            Dim Lat_Lon_Pin As New StringBuilder()
            For i As Integer = 0 To ListView2.Items.Count - 1
                For j As Integer = 0 To ListView2.Items(i).SubItems.Count - 1
                    'Debug.Print(ListView2.Items(i).SubItems(j).Text)
                    Lat_Lon_Pin.Append(ListView2.Items(i).SubItems(j).Text & " ")

                    port_Seatrac.Write(send_data_command("beacon_id_01", ListView2.Items(i).SubItems(j).Text) & vbCr)

                    Thread.Sleep(3000)
                Next


            Next
            'Debug.Print(Lat_Lon_Pin.ToString)
            port_Seatrac.Write(send_data_command("beacon_id_01", "End") & vbCr)
            Thread.Sleep(3000)
            'MessageBox.Show("complete Sending pin data From X150 to X010")
        End If
    End Sub


    Private Sub txt_GotToLat_TextChanged(sender As Object, e As EventArgs) Handles txt_GotToLat.TextChanged
        'If Not IsNumeric(txt_GotToLat.Text) And txt_GotToLat.Text IsNot "" And txt_GotToLat.Text IsNot "Latitude" Then
        '    txt_GotToLat.Text = ""
        'End If
    End Sub

    Private Sub txt_GoToLon_TextChanged(sender As Object, e As EventArgs) Handles txt_GoToLon.TextChanged
        'If Not IsNumeric(txt_GoToLon.Text) And txt_GoToLon.Text IsNot "" And txt_GoToLon.Text IsNot "Lontitude" Then
        '    txt_GoToLon.Text = ""
        'End If
    End Sub

    Private Sub txt_GotToLat_Enter(sender As Object, e As EventArgs) Handles txt_GotToLat.Enter
        If txt_GotToLat.ForeColor = Color.Black Then
            Return
        End If

        txt_GotToLat.Text = ""
        txt_GotToLat.ForeColor = Color.Black

    End Sub

    Private Sub txt_GoToLon_Enter(sender As Object, e As EventArgs) Handles txt_GoToLon.Enter
        If txt_GoToLon.ForeColor = Color.Black Then
            Return
        End If
        If Not IsNumeric(txt_GoToLon.Text) Then
            txt_GoToLon.Text = ""
            txt_GoToLon.ForeColor = Color.Black
        End If

    End Sub

    Private Sub txt_GotToLat_Leave(sender As Object, e As EventArgs) Handles txt_GotToLat.Leave
        If txt_GotToLat.Text.Trim() = "" Then
            txt_GotToLat.Text = "Latitude"
            txt_GotToLat.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub txt_GoToLon_Leave(sender As Object, e As EventArgs) Handles txt_GoToLon.Leave
        If txt_GoToLon.Text.Trim() = "" Then
            txt_GoToLon.Text = "Lontitude"
            txt_GoToLon.ForeColor = Color.Gray
        End If
    End Sub
End Class

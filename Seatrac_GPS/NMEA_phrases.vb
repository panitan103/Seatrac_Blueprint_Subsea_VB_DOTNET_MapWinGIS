Imports Microsoft.VisualBasic.Logging
Imports System.Math
Module NMEA_phrases
    Public GPGGA_data As GPGGA

    Public robot_lat As Double
    Public robot_long As Double
    Public robot_lat_trans As Double
    Public robot_long_trans As Double

    Public Structure GPGGA
        Public Universal_Time As String
        Public Latitude As String
        Public Latitude_Hemisphere As String
        Public Longitude As String
        Public Longitude_Hemisphere As String
        Public Position_Fix As String
        Public Satellites As String
        Public HDOP As String
        Public Altitude As String
        Public Units As String
        Public Latitude_Decimal As String
        Public Longitude_Decimal As String
    End Structure

    Private Function toDecimal(ByVal Pos As String) As Double
        Dim PosDb As Double
        Dim Deg As Double
        Dim DecPos As Double
        If Pos <> "" Then
            PosDb = CDbl(Pos)
            Deg = Math.Floor(PosDb / 100)
            DecPos = Math.Round(Deg + ((PosDb - (Deg * 100)) / 60), 6)
        End If

        Return DecPos
    End Function


    Public Sub NMEA_decode(ByVal read_data As String)
        Dim delimiterChars As Char() = {","c}  '{" "c, ","c, "."c, ":"c, vbTab}
        Dim ReadMatSplit() As String
        ReadMatSplit = read_data.Split(delimiterChars)
        'MessageBox.Show(ReadMatSplit(1))

        If ReadMatSplit(0) = "$GPGGA" Then
            GPGGA_data.Universal_Time = ReadMatSplit(1)
            GPGGA_data.Latitude = ReadMatSplit(2)
            GPGGA_data.Latitude_Hemisphere = ReadMatSplit(3)
            GPGGA_data.Longitude = ReadMatSplit(4)
            GPGGA_data.Longitude_Hemisphere = ReadMatSplit(5)
            GPGGA_data.Position_Fix = ReadMatSplit(6)
            GPGGA_data.Satellites = (Int(ReadMatSplit(7))).ToString
            GPGGA_data.HDOP = ReadMatSplit(8)
            GPGGA_data.Altitude = ReadMatSplit(9)
            GPGGA_data.Units = ReadMatSplit(10)
            GPGGA_data.Latitude_Decimal = toDecimal(ReadMatSplit(2))
            GPGGA_data.Longitude_Decimal = toDecimal(ReadMatSplit(4))

            'Dim result_gps As String = "GPGGA Message" + vbCrLf +
            '                          "Universal Time       : " + GPGGA_data.Universal_Time + vbCrLf +
            '                          "Latitude             : " + GPGGA_data.Latitude + vbCrLf +
            ''                         "Latitude Hemisphere  : " + GPGGA_data.Latitude_Hemisphere + vbCrLf +
            '                         "Longitude            : " + GPGGA_data.Longitude + vbCrLf +
            '                         "Longitude Hemisphere : " + GPGGA_data.Longitude_Hemisphere + vbCrLf +
            '                         "Position Fix         : " + GPGGA_data.Position_Fix + vbCrLf +
            '                         "Satellites           : " + GPGGA_data.Satellites + vbCrLf +
            '                        "HDOP                 : " + GPGGA_data.HDOP + vbCrLf +
            '                        "Altitude             : " + GPGGA_data.Altitude + vbCrLf +
            '                        "Units                : " + GPGGA_data.Units + vbCrLf +
            '                        "Decimal Latitude     : " + GPGGA_data.Latitude_Decimal + vbCrLf +
            '                        "Decimal Longitude    : " + GPGGA_data.Longitude_Decimal

            'Form1.RichTextBox1.Text = result_gps
        End If

    End Sub

    'Calculate the distance between two coordinates
    'I found an article On codeproject.com by Gary Dryden, written In C#.
    'Remember to convert your position to Decimals first.
    'I converted it To VB.NET Like so
    'Returns distance In Kilometers.
    'Example: MyDistance = Calc(56.0176,12.19302,56.0176,12.19301)
    Sub Calc_robot_position(ByVal Lat1 As Double, ByVal Long1 As Double, ByVal Lat2_m As Double, ByVal Long2_m As Double)
        Dim dif_lat As Double = ((Lat2_m / 1000) / 6376.5) * (180 / Math.PI)
        Dim dif_long As Double = ((Long2_m / 1000) / 6376.5) * (180 / Math.PI)


        robot_lat = (Lat1 + dif_lat)
        robot_long = (Long1 + dif_long)

    End Sub

    Sub Calc_robot_position_yaw_depth(ByVal Lat1 As Double, ByVal Long1 As Double, ByVal Lat2_m As Double, ByVal Long2_m As Double, ByVal yaw As String, ByVal depth As String)

        Dim yaw_trans As Double
        Dim depth_trans As Double
        Dim Lat2_m_trans As Double
        Dim Long2_m_trans As Double
        Double.TryParse(yaw, yaw_trans)
        Double.TryParse(depth, depth_trans)
        If (Lat2_m) >= 0 Then


            Lat2_m_trans = Math.Sqrt(Math.Pow((Lat2_m) * Math.Cos(yaw_trans * (Math.PI / 180)), 2) - Math.Pow(depth_trans, 2))
        ElseIf (Lat2_m) < 0 Then

            Lat2_m_trans = Math.Sqrt(Math.Pow((Lat2_m) * Math.Cos(yaw_trans * (Math.PI / 180)), 2) - Math.Pow(depth_trans, 2)) * -1
        End If

        If (Long2_m) >= 0 Then

            Long2_m_trans = Math.Sqrt(Math.Pow((Long2_m) * Math.Cos(yaw_trans * (Math.PI / 180)), 2) - Math.Pow(depth_trans, 2))
        ElseIf (Long2_m) < 0 Then

            Long2_m_trans = Math.Sqrt(Math.Pow((Long2_m) * Math.Cos(yaw_trans * (Math.PI / 180)), 2) - Math.Pow(depth_trans, 2)) * -1
        End If

        Dim dif_lat As Double = ((Lat2_m / 1000) / 6376.5) * (180 / Math.PI)
        Dim dif_long As Double = ((Long2_m / 1000) / 6376.5) * (180 / Math.PI)
        robot_lat = Lat1 + dif_lat
        robot_long = Long1 + dif_long

        Dim dif_lat_trans As Double = ((Lat2_m_trans / 1000) / 6376.5) * (180 / Math.PI)
        Dim dif_long_trans As Double = ((Long2_m_trans / 1000) / 6376.5) * (180 / Math.PI)
        robot_lat_trans = Math.Round(Lat1 + dif_lat_trans, 8)
        robot_long_trans = Math.Round(Long1 + dif_long_trans, 8)

    End Sub
    Public Function Calc_lat_lon_dist(ByVal Lat1 As Double, ByVal Long1 As Double, ByVal Lat2 As Double, ByVal Long2 As Double) As Double
        Dim dDistance As Double = Double.MinValue
        Dim dLat1InRad As Double = Lat1 * (Math.PI / 180)
        Dim dLong1InRad As Double = Long1 * (Math.PI / 180)
        Dim dLat2InRad As Double = Lat2 * (Math.PI / 180)
        Dim dLong2InRad As Double = Long2 * (Math.PI / 180)
        Dim dLongitude As Double = dLong2InRad - dLong1InRad
        Dim dLatitude As Double = dLat2InRad - dLat1InRad
        Dim a As Double = Math.Pow(Math.Sin(dLatitude / 2), 2) + Math.Cos(dLat1InRad) * Math.Cos(dLat2InRad) * Math.Pow(Math.Sin(dLongitude / 2), 2)
        Dim c As Double = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a))
        Const kEarthRadiusKms As Double = 6376.5
        dDistance = kEarthRadiusKms * c
        Return dDistance
    End Function
    Public Function Calc_lat_lon_North_East(ByVal Lat1 As Double, ByVal Long1 As Double, ByVal Lat2 As Double, ByVal Long2 As Double) As (north As Integer, east As Integer)
        Dim dDistance As Double = Double.MinValue
        Dim dLat1InRad As Double = Lat1 * (Math.PI / 180)
        Dim dLong1InRad As Double = Long1 * (Math.PI / 180)
        Dim dLat2InRad As Double = Lat2 * (Math.PI / 180)
        Dim dLong2InRad As Double = Long2 * (Math.PI / 180)
        Dim dLongitude As Double = dLong2InRad - dLong1InRad
        Dim dLatitude As Double = dLat2InRad - dLat1InRad
        Dim a As Double = Math.Pow(Math.Sin(dLatitude / 2), 2) + Math.Cos(dLat1InRad) * Math.Cos(dLat2InRad) * Math.Pow(Math.Sin(dLongitude / 2), 2)
        Dim c As Double = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a))
        Const kEarthRadiusKms As Double = 6376.5
        dDistance = kEarthRadiusKms * c
        'Dim degree As Double = Math.Atan2(Math.Sin(dLongitude) * Math.Cos(Lat2), Math.Cos(Lat1) * Math.Sin(Lat2) - Math.Sin(Lat1) * Math.Cos(Lat2) * Math.Cos(dLongitude))
        Dim degree As Double = Math.Abs(Math.Atan(dLongitude / dLatitude))
        'Debug.Print("dDistance : " & dDistance)
        'Debug.Print("degree : " & degree)

        Dim north As Double = 0
        Dim east As Double = 0
        north = dDistance * Math.Cos(degree) * 1000
        east = dDistance * Math.Sin(degree) * 1000
        'Debug.Print("degree : " & degree * 180 / Math.PI)
        'Debug.Print("north : " & north)
        'Debug.Print("east : " & east)

        If (Lat2 < Lat1) Then
            north = north * -1
            'degree = degree + 1.5708
        End If
        If (Long2 < Long1) Then
            east = east * -1
            'degree = degree * -1
        End If

        'Return (Convert.ToInt32(north * 100), Convert.ToInt32(east * 100))
        Return (Convert.ToInt32(north * 10), Convert.ToInt32(east * 10))

    End Function


    'Calculate direction In degrees between two coordinates
    'This code was by far the hardest To dig up, but thanks To Jim Mischel And his fantastic article On informit.com it came To work.
    'Copy code into a form containing a Button1.
    'Edit values In Button1_Click:
    'Source.lat
    'Source.lon
    'Destination.lat
    'Destination.lon

    Structure wptType
        Dim lat As Double
        Dim lon As Double
        Dim ele As Double
    End Structure
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Distance As Double = 0
        Dim Course As Double = 0
        Dim Source As wptType
        Dim Destination As wptType
        Source.lat = 56
        Source.lon = 12
        Destination.lat = 56
        Destination.lon = 11
        GetCourseAndDistance(Source, Destination, Course, Distance)
        MsgBox(Course)
    End Sub
    Sub GetCourseAndDistance(ByVal pt1 As wptType, ByVal pt2 As wptType, ByRef course As Double, ByRef dist As Double)
        ' convert latitude and longitude to radians
        Dim lat1 As Double = DegreesToRadians(CDbl(pt1.lat))
        Dim lon1 As Double = DegreesToRadians(CDbl(pt1.lon))
        Dim lat2 As Double = DegreesToRadians(CDbl(pt2.lat))
        Dim lon2 As Double = DegreesToRadians(CDbl(pt2.lon))

        ' compute latitude and longitude differences
        Dim dlat As Double = lat2 - lat1
        Dim dlon As Double = lon2 - lon1

        Dim distanceNorth As Double = dlat
        Dim distanceEast As Double = dlon * Math.Cos(lat1)

        ' compute the distance in radians
        dist = Math.Sqrt(distanceNorth * distanceNorth + distanceEast * distanceEast)

        ' and convert the radians to meters
        dist = RadiansToMeters(dist)

        ' add the elevation difference to the calculation
        Dim dele As Double = CDbl(pt2.ele - pt1.ele)
        dist = Math.Sqrt(dist * dist + dele * dele)

        ' compute the course
        course = Math.Atan2(distanceEast, distanceNorth) Mod (2 * Math.PI)
        course = RadiansToDegrees(course)
        If course < 0 Then
            course += 360
        End If
    End Sub
    Function DegreesToRadians(ByVal degrees As Double) As Double
        Return degrees * Math.PI / 180.0
    End Function

    Function RadiansToDegrees(ByVal radians As Double) As Double
        Return radians * 180.0 / Math.PI
    End Function

    Function RadiansToNauticalMiles(ByVal radians As Double) As Double
        ' There are 60 nautical miles for each degree
        Return radians * 60 * 180 / Math.PI
    End Function

    Function RadiansToMeters(ByVal radians As Double) As Double
        ' there are 1852 meters in a nautical mile
        Return 1852 * RadiansToNauticalMiles(radians)
    End Function

    Function DecimalTometer(lat As Double, lon As Double) As (x As Double, y As Double)
        Dim x As Double = lon * 20037508.34 / 180
        Dim y As Double = Math.Log(Math.Tan((90 + lat) * Math.PI / 360)) / (Math.PI / 180)
        y = y * 20037508.34 / 180
        Return (x, y)
    End Function

    'Convert decimal location to NMEA/WGS-84 format.
    'You can get the return value in two different formats.
    'NMEA = 01211.3487,N
    'WithSigns = 56°1"3.18'N
    Public Enum enumLongLat
        Latitude = 1
        Longitude = 2
    End Enum
    Public Enum enumReturnformat
        WithSigns = 0
        NMEA = 1
    End Enum

    Public Function DecimalPosToDegrees(ByVal Decimalpos As Double, ByVal Type As enumLongLat, ByVal Outputformat As enumReturnformat, Optional ByVal SecondResolution As Integer = 2) As String
        Dim Deg As Integer = 0
        Dim Min As Double = 0
        Dim Sec As Double = 0
        Dim Dir As String = ""
        Dim tmpPos As Double = Decimalpos
        If tmpPos < 0 Then tmpPos = Decimalpos * -1 'Always do math on positive values

        Deg = CType(Math.Floor(tmpPos), Integer)
        Min = (tmpPos - Deg) * 60
        Sec = (Min - Math.Floor(Min)) * 60
        Min = Math.Floor(Min)
        Sec = Math.Round(Sec, SecondResolution)

        Select Case Type
            Case enumLongLat.Latitude '=1
                If Decimalpos < 0 Then
                    Dir = "S"
                Else
                    Dir = "N"
                End If
            Case enumLongLat.Longitude '=2
                If Decimalpos < 0 Then
                    Dir = "W"
                Else
                    Dir = "E"
                End If
        End Select
        Select Case Outputformat
            Case enumReturnformat.NMEA
                Return AddZeros(Deg, 3) & AddZeros(Min, 2) & AddZeros(Sec, 2)
            Case enumReturnformat.WithSigns
                Return Deg & "°" & Min & """" & Sec & "'" & Dir
            Case Else
                Return ""
        End Select
    End Function


    Public Function AddZeros(ByVal Value As Double, ByVal Zeros As Integer) As String
        If Math.Floor(Value).ToString.Length < Zeros Then
            Return Value.ToString.PadLeft(Zeros, CType("0", Char))
        Else
            Return Value.ToString
        End If
    End Function



End Module

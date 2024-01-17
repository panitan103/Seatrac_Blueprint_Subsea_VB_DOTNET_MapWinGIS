<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tab_Map = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.map_OpenHumanitarianMap = New System.Windows.Forms.Button()
        Me.map_OpenStreetMap = New System.Windows.Forms.Button()
        Me.btn_BingHybrid = New System.Windows.Forms.Button()
        Me.btn_BingMap = New System.Windows.Forms.Button()
        Me.btn_BingSatelliteMap = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.go_KMUTNB = New System.Windows.Forms.Button()
        Me.btn_GoToCoordinate = New System.Windows.Forms.Button()
        Me.txt_GotToLat = New System.Windows.Forms.TextBox()
        Me.txt_GoToLon = New System.Windows.Forms.TextBox()
        Me.tab_Seatrac = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_GPSBaud = New System.Windows.Forms.ComboBox()
        Me.cmb_GPSPort = New System.Windows.Forms.ComboBox()
        Me.go_GPS = New System.Windows.Forms.Button()
        Me.btn_GPS_Connect = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel9 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_Ping = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_SeatracBaud = New System.Windows.Forms.ComboBox()
        Me.cmb_SeatracPort = New System.Windows.Forms.ComboBox()
        Me.btn_Seatrac_Connect = New System.Windows.Forms.Button()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.list_Data = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.List_Value = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TableLayoutPanel13 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_ClearGPS = New System.Windows.Forms.Button()
        Me.btn_ClearSeatrac = New System.Windows.Forms.Button()
        Me.tab_SeatracNavigate = New System.Windows.Forms.TabPage()
        Me.SplitContainer5 = New System.Windows.Forms.SplitContainer()
        Me.TableLayoutPanel14 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_ClearPin = New System.Windows.Forms.Button()
        Me.btn_SeatracPin = New System.Windows.Forms.Button()
        Me.btn_SeatracSendPin = New System.Windows.Forms.Button()
        Me.btn_SendPinTag = New System.Windows.Forms.Button()
        Me.txt_PositionDepth = New System.Windows.Forms.NumericUpDown()
        Me.txt_PositionYaw = New System.Windows.Forms.NumericUpDown()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.list_Latitude = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.list_Longtitude = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.list_Depth = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.list_Yaw = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tab_Setting = New System.Windows.Forms.TabPage()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel11 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_OffsetX = New System.Windows.Forms.NumericUpDown()
        Me.txt_OffsetY = New System.Windows.Forms.NumericUpDown()
        Me.grp_SettingSeatrac = New System.Windows.Forms.GroupBox()
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
        Me.TableLayoutPanel12 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_SeatracSendData = New System.Windows.Forms.Button()
        Me.txt_SeatracData = New System.Windows.Forms.RichTextBox()
        Me.btn_PingTest = New System.Windows.Forms.Button()
        Me.txt_PingInterval = New System.Windows.Forms.NumericUpDown()
        Me.txt_PingTestCount = New System.Windows.Forms.NumericUpDown()
        Me.ListView3 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TableLayoutPanel10 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_ZoomInMap = New System.Windows.Forms.Button()
        Me.btn_MoveMap = New System.Windows.Forms.Button()
        Me.btn_AreaMap = New System.Windows.Forms.Button()
        Me.bnt_MeasureMap = New System.Windows.Forms.Button()
        Me.btn_ZoomOutMap = New System.Windows.Forms.Button()
        Me.AxMap1 = New AxMapWinGIS.AxMap()
        Me.port_GPS = New System.IO.Ports.SerialPort(Me.components)
        Me.port_Seatrac = New System.IO.Ports.SerialPort(Me.components)
        Me.tmr_SeatracPingInterval = New System.Windows.Forms.Timer(Me.components)
        Me.tmr_SeatracStatusUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.btn_Nav = New System.Windows.Forms.Button()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tab_Map.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.tab_Seatrac.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.TableLayoutPanel9.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.TableLayoutPanel13.SuspendLayout()
        Me.tab_SeatracNavigate.SuspendLayout()
        CType(Me.SplitContainer5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer5.Panel1.SuspendLayout()
        Me.SplitContainer5.Panel2.SuspendLayout()
        Me.SplitContainer5.SuspendLayout()
        Me.TableLayoutPanel14.SuspendLayout()
        CType(Me.txt_PositionDepth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_PositionYaw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_Setting.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.TableLayoutPanel11.SuspendLayout()
        CType(Me.txt_OffsetX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_OffsetY, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_SettingSeatrac.SuspendLayout()
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.Panel2.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        Me.TableLayoutPanel12.SuspendLayout()
        CType(Me.txt_PingInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_PingTestCount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel10.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.AxMap1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TabControl1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TableLayoutPanel10)
        Me.SplitContainer1.Size = New System.Drawing.Size(1071, 661)
        Me.SplitContainer1.SplitterDistance = 238
        Me.SplitContainer1.TabIndex = 1
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tab_Map)
        Me.TabControl1.Controls.Add(Me.tab_Seatrac)
        Me.TabControl1.Controls.Add(Me.tab_SeatracNavigate)
        Me.TabControl1.Controls.Add(Me.tab_Setting)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(238, 661)
        Me.TabControl1.TabIndex = 0
        '
        'tab_Map
        '
        Me.tab_Map.Controls.Add(Me.TableLayoutPanel1)
        Me.tab_Map.Location = New System.Drawing.Point(4, 22)
        Me.tab_Map.Name = "tab_Map"
        Me.tab_Map.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_Map.Size = New System.Drawing.Size(230, 635)
        Me.tab_Map.TabIndex = 0
        Me.tab_Map.Text = "Map"
        Me.tab_Map.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox2, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(224, 629)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(218, 308)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Map"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.map_OpenHumanitarianMap, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.map_OpenStreetMap, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.btn_BingHybrid, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btn_BingMap, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.btn_BingSatelliteMap, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 5
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(212, 289)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'map_OpenHumanitarianMap
        '
        Me.TableLayoutPanel2.SetColumnSpan(Me.map_OpenHumanitarianMap, 2)
        Me.map_OpenHumanitarianMap.Dock = System.Windows.Forms.DockStyle.Fill
        Me.map_OpenHumanitarianMap.Location = New System.Drawing.Point(2, 230)
        Me.map_OpenHumanitarianMap.Margin = New System.Windows.Forms.Padding(2)
        Me.map_OpenHumanitarianMap.Name = "map_OpenHumanitarianMap"
        Me.map_OpenHumanitarianMap.Size = New System.Drawing.Size(208, 57)
        Me.map_OpenHumanitarianMap.TabIndex = 1
        Me.map_OpenHumanitarianMap.Text = "OpenHumanitarianMap"
        Me.map_OpenHumanitarianMap.UseVisualStyleBackColor = True
        '
        'map_OpenStreetMap
        '
        Me.TableLayoutPanel2.SetColumnSpan(Me.map_OpenStreetMap, 2)
        Me.map_OpenStreetMap.Dock = System.Windows.Forms.DockStyle.Fill
        Me.map_OpenStreetMap.Location = New System.Drawing.Point(2, 173)
        Me.map_OpenStreetMap.Margin = New System.Windows.Forms.Padding(2)
        Me.map_OpenStreetMap.Name = "map_OpenStreetMap"
        Me.map_OpenStreetMap.Size = New System.Drawing.Size(208, 53)
        Me.map_OpenStreetMap.TabIndex = 0
        Me.map_OpenStreetMap.Text = "OpenStreetMap"
        Me.map_OpenStreetMap.UseVisualStyleBackColor = True
        '
        'btn_BingHybrid
        '
        Me.TableLayoutPanel2.SetColumnSpan(Me.btn_BingHybrid, 2)
        Me.btn_BingHybrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_BingHybrid.Location = New System.Drawing.Point(3, 3)
        Me.btn_BingHybrid.Name = "btn_BingHybrid"
        Me.btn_BingHybrid.Size = New System.Drawing.Size(206, 51)
        Me.btn_BingHybrid.TabIndex = 4
        Me.btn_BingHybrid.Text = "Bing Hybrid Map"
        Me.btn_BingHybrid.UseVisualStyleBackColor = True
        '
        'btn_BingMap
        '
        Me.TableLayoutPanel2.SetColumnSpan(Me.btn_BingMap, 2)
        Me.btn_BingMap.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_BingMap.Location = New System.Drawing.Point(3, 117)
        Me.btn_BingMap.Name = "btn_BingMap"
        Me.btn_BingMap.Size = New System.Drawing.Size(206, 51)
        Me.btn_BingMap.TabIndex = 3
        Me.btn_BingMap.Text = "Bing Map"
        Me.btn_BingMap.UseVisualStyleBackColor = True
        '
        'btn_BingSatelliteMap
        '
        Me.TableLayoutPanel2.SetColumnSpan(Me.btn_BingSatelliteMap, 2)
        Me.btn_BingSatelliteMap.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_BingSatelliteMap.Location = New System.Drawing.Point(3, 60)
        Me.btn_BingSatelliteMap.Name = "btn_BingSatelliteMap"
        Me.btn_BingSatelliteMap.Size = New System.Drawing.Size(206, 51)
        Me.btn_BingSatelliteMap.TabIndex = 2
        Me.btn_BingSatelliteMap.Text = "Bing Satellite Map"
        Me.btn_BingSatelliteMap.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TableLayoutPanel3)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(3, 317)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(218, 309)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Go to"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.go_KMUTNB, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btn_GoToCoordinate, 0, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.txt_GotToLat, 0, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.txt_GoToLon, 1, 3)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 5
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(212, 290)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'go_KMUTNB
        '
        Me.TableLayoutPanel3.SetColumnSpan(Me.go_KMUTNB, 2)
        Me.go_KMUTNB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.go_KMUTNB.Location = New System.Drawing.Point(3, 3)
        Me.go_KMUTNB.Name = "go_KMUTNB"
        Me.go_KMUTNB.Size = New System.Drawing.Size(206, 52)
        Me.go_KMUTNB.TabIndex = 3
        Me.go_KMUTNB.Text = "KMUTNB"
        Me.go_KMUTNB.UseVisualStyleBackColor = True
        '
        'btn_GoToCoordinate
        '
        Me.TableLayoutPanel3.SetColumnSpan(Me.btn_GoToCoordinate, 2)
        Me.btn_GoToCoordinate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_GoToCoordinate.Location = New System.Drawing.Point(2, 234)
        Me.btn_GoToCoordinate.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_GoToCoordinate.Name = "btn_GoToCoordinate"
        Me.btn_GoToCoordinate.Size = New System.Drawing.Size(208, 54)
        Me.btn_GoToCoordinate.TabIndex = 4
        Me.btn_GoToCoordinate.Text = "Go to Coordinate"
        Me.btn_GoToCoordinate.UseVisualStyleBackColor = True
        '
        'txt_GotToLat
        '
        Me.txt_GotToLat.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_GotToLat.ForeColor = System.Drawing.SystemColors.GrayText
        Me.txt_GotToLat.Location = New System.Drawing.Point(2, 193)
        Me.txt_GotToLat.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_GotToLat.Name = "txt_GotToLat"
        Me.txt_GotToLat.Size = New System.Drawing.Size(102, 20)
        Me.txt_GotToLat.TabIndex = 5
        Me.txt_GotToLat.Text = "Latitude"
        '
        'txt_GoToLon
        '
        Me.txt_GoToLon.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_GoToLon.ForeColor = System.Drawing.SystemColors.GrayText
        Me.txt_GoToLon.Location = New System.Drawing.Point(108, 193)
        Me.txt_GoToLon.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_GoToLon.Name = "txt_GoToLon"
        Me.txt_GoToLon.Size = New System.Drawing.Size(102, 20)
        Me.txt_GoToLon.TabIndex = 6
        Me.txt_GoToLon.Text = "Lontitude"
        '
        'tab_Seatrac
        '
        Me.tab_Seatrac.Controls.Add(Me.TableLayoutPanel5)
        Me.tab_Seatrac.Location = New System.Drawing.Point(4, 22)
        Me.tab_Seatrac.Name = "tab_Seatrac"
        Me.tab_Seatrac.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_Seatrac.Size = New System.Drawing.Size(230, 635)
        Me.tab_Seatrac.TabIndex = 1
        Me.tab_Seatrac.Text = "Seatrac"
        Me.tab_Seatrac.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.SplitContainer2, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.TableLayoutPanel13, 0, 1)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel5.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 2
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(224, 629)
        Me.TableLayoutPanel5.TabIndex = 0
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(2, 2)
        Me.SplitContainer2.Margin = New System.Windows.Forms.Padding(2)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.GroupBox3)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.GroupBox4)
        Me.SplitContainer2.Size = New System.Drawing.Size(220, 584)
        Me.SplitContainer2.SplitterDistance = 253
        Me.SplitContainer2.SplitterWidth = 3
        Me.SplitContainer2.TabIndex = 2
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TableLayoutPanel6)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(220, 253)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GPS"
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 1
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.GroupBox5, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.GroupBox6, 0, 1)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(2, 15)
        Me.TableLayoutPanel6.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 2
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(216, 236)
        Me.TableLayoutPanel6.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.TableLayoutPanel8)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox5.Location = New System.Drawing.Point(2, 2)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox5.Size = New System.Drawing.Size(212, 114)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Connection"
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.ColumnCount = 2
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel8.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.cmb_GPSBaud, 1, 1)
        Me.TableLayoutPanel8.Controls.Add(Me.cmb_GPSPort, 1, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.go_GPS, 0, 2)
        Me.TableLayoutPanel8.Controls.Add(Me.btn_GPS_Connect, 1, 2)
        Me.TableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(2, 15)
        Me.TableLayoutPanel8.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 3
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(208, 97)
        Me.TableLayoutPanel8.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Baud Rate"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Select a port"
        '
        'cmb_GPSBaud
        '
        Me.cmb_GPSBaud.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_GPSBaud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_GPSBaud.FormattingEnabled = True
        Me.cmb_GPSBaud.Items.AddRange(New Object() {"300", "1200", "2400", "4800", "9600", "19200", "38400", "57600", "74880", "115200", "230400", "250000"})
        Me.cmb_GPSBaud.Location = New System.Drawing.Point(107, 37)
        Me.cmb_GPSBaud.Name = "cmb_GPSBaud"
        Me.cmb_GPSBaud.Size = New System.Drawing.Size(98, 21)
        Me.cmb_GPSBaud.TabIndex = 7
        '
        'cmb_GPSPort
        '
        Me.cmb_GPSPort.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_GPSPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_GPSPort.FormattingEnabled = True
        Me.cmb_GPSPort.Location = New System.Drawing.Point(107, 5)
        Me.cmb_GPSPort.Name = "cmb_GPSPort"
        Me.cmb_GPSPort.Size = New System.Drawing.Size(98, 21)
        Me.cmb_GPSPort.TabIndex = 6
        '
        'go_GPS
        '
        Me.go_GPS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.go_GPS.Enabled = False
        Me.go_GPS.Location = New System.Drawing.Point(3, 67)
        Me.go_GPS.Name = "go_GPS"
        Me.go_GPS.Size = New System.Drawing.Size(98, 27)
        Me.go_GPS.TabIndex = 10
        Me.go_GPS.Text = "GPS"
        Me.go_GPS.UseVisualStyleBackColor = True
        '
        'btn_GPS_Connect
        '
        Me.btn_GPS_Connect.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_GPS_Connect.Location = New System.Drawing.Point(107, 67)
        Me.btn_GPS_Connect.Name = "btn_GPS_Connect"
        Me.btn_GPS_Connect.Size = New System.Drawing.Size(98, 27)
        Me.btn_GPS_Connect.TabIndex = 9
        Me.btn_GPS_Connect.Text = "Connect"
        Me.btn_GPS_Connect.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.RichTextBox1)
        Me.GroupBox6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox6.Location = New System.Drawing.Point(2, 120)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox6.Size = New System.Drawing.Size(212, 114)
        Me.GroupBox6.TabIndex = 1
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Feedback"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Enabled = False
        Me.RichTextBox1.Location = New System.Drawing.Point(2, 15)
        Me.RichTextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(208, 97)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TableLayoutPanel7)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Size = New System.Drawing.Size(220, 328)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Seatrac"
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.ColumnCount = 1
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.GroupBox7, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.GroupBox8, 0, 1)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(2, 15)
        Me.TableLayoutPanel7.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 2
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(216, 311)
        Me.TableLayoutPanel7.TabIndex = 0
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.TableLayoutPanel9)
        Me.GroupBox7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox7.Location = New System.Drawing.Point(2, 2)
        Me.GroupBox7.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox7.Size = New System.Drawing.Size(212, 151)
        Me.GroupBox7.TabIndex = 0
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Connection"
        '
        'TableLayoutPanel9
        '
        Me.TableLayoutPanel9.ColumnCount = 2
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel9.Controls.Add(Me.btn_Ping, 0, 2)
        Me.TableLayoutPanel9.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel9.Controls.Add(Me.Label4, 0, 1)
        Me.TableLayoutPanel9.Controls.Add(Me.cmb_SeatracBaud, 1, 1)
        Me.TableLayoutPanel9.Controls.Add(Me.cmb_SeatracPort, 1, 0)
        Me.TableLayoutPanel9.Controls.Add(Me.btn_Seatrac_Connect, 1, 2)
        Me.TableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel9.Location = New System.Drawing.Point(2, 15)
        Me.TableLayoutPanel9.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel9.Name = "TableLayoutPanel9"
        Me.TableLayoutPanel9.RowCount = 3
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel9.Size = New System.Drawing.Size(208, 134)
        Me.TableLayoutPanel9.TabIndex = 0
        '
        'btn_Ping
        '
        Me.btn_Ping.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Ping.Enabled = False
        Me.btn_Ping.Location = New System.Drawing.Point(3, 91)
        Me.btn_Ping.Name = "btn_Ping"
        Me.btn_Ping.Size = New System.Drawing.Size(98, 40)
        Me.btn_Ping.TabIndex = 11
        Me.btn_Ping.Text = "Ping"
        Me.btn_Ping.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Select a port"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Baud Rate"
        '
        'cmb_SeatracBaud
        '
        Me.cmb_SeatracBaud.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_SeatracBaud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_SeatracBaud.FormattingEnabled = True
        Me.cmb_SeatracBaud.Items.AddRange(New Object() {"300", "1200", "2400", "4800", "9600", "19200", "38400", "57600", "74880", "115200", "230400", "250000"})
        Me.cmb_SeatracBaud.Location = New System.Drawing.Point(107, 55)
        Me.cmb_SeatracBaud.Name = "cmb_SeatracBaud"
        Me.cmb_SeatracBaud.Size = New System.Drawing.Size(98, 21)
        Me.cmb_SeatracBaud.TabIndex = 8
        '
        'cmb_SeatracPort
        '
        Me.cmb_SeatracPort.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_SeatracPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_SeatracPort.FormattingEnabled = True
        Me.cmb_SeatracPort.Location = New System.Drawing.Point(107, 11)
        Me.cmb_SeatracPort.Name = "cmb_SeatracPort"
        Me.cmb_SeatracPort.Size = New System.Drawing.Size(98, 21)
        Me.cmb_SeatracPort.TabIndex = 9
        '
        'btn_Seatrac_Connect
        '
        Me.btn_Seatrac_Connect.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Seatrac_Connect.Location = New System.Drawing.Point(107, 91)
        Me.btn_Seatrac_Connect.Name = "btn_Seatrac_Connect"
        Me.btn_Seatrac_Connect.Size = New System.Drawing.Size(98, 40)
        Me.btn_Seatrac_Connect.TabIndex = 10
        Me.btn_Seatrac_Connect.Text = "Connect"
        Me.btn_Seatrac_Connect.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.ListView1)
        Me.GroupBox8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox8.Location = New System.Drawing.Point(2, 157)
        Me.GroupBox8.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox8.Size = New System.Drawing.Size(212, 152)
        Me.GroupBox8.TabIndex = 1
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Feedback"
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.list_Data, Me.List_Value})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(2, 15)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(208, 135)
        Me.ListView1.TabIndex = 9
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'list_Data
        '
        Me.list_Data.Text = "Data"
        '
        'List_Value
        '
        Me.List_Value.Text = "Value"
        '
        'TableLayoutPanel13
        '
        Me.TableLayoutPanel13.ColumnCount = 2
        Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel13.Controls.Add(Me.btn_ClearGPS, 0, 0)
        Me.TableLayoutPanel13.Controls.Add(Me.btn_ClearSeatrac, 1, 0)
        Me.TableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel13.Location = New System.Drawing.Point(2, 590)
        Me.TableLayoutPanel13.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel13.Name = "TableLayoutPanel13"
        Me.TableLayoutPanel13.RowCount = 1
        Me.TableLayoutPanel13.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel13.Size = New System.Drawing.Size(220, 37)
        Me.TableLayoutPanel13.TabIndex = 3
        '
        'btn_ClearGPS
        '
        Me.btn_ClearGPS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_ClearGPS.Location = New System.Drawing.Point(2, 2)
        Me.btn_ClearGPS.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_ClearGPS.Name = "btn_ClearGPS"
        Me.btn_ClearGPS.Size = New System.Drawing.Size(106, 33)
        Me.btn_ClearGPS.TabIndex = 1
        Me.btn_ClearGPS.Text = "Clear GPS"
        Me.btn_ClearGPS.UseVisualStyleBackColor = True
        '
        'btn_ClearSeatrac
        '
        Me.btn_ClearSeatrac.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_ClearSeatrac.Location = New System.Drawing.Point(112, 2)
        Me.btn_ClearSeatrac.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_ClearSeatrac.Name = "btn_ClearSeatrac"
        Me.btn_ClearSeatrac.Size = New System.Drawing.Size(106, 33)
        Me.btn_ClearSeatrac.TabIndex = 0
        Me.btn_ClearSeatrac.Text = "Clear Seatrac"
        Me.btn_ClearSeatrac.UseVisualStyleBackColor = True
        '
        'tab_SeatracNavigate
        '
        Me.tab_SeatracNavigate.Controls.Add(Me.SplitContainer5)
        Me.tab_SeatracNavigate.Location = New System.Drawing.Point(4, 22)
        Me.tab_SeatracNavigate.Margin = New System.Windows.Forms.Padding(2)
        Me.tab_SeatracNavigate.Name = "tab_SeatracNavigate"
        Me.tab_SeatracNavigate.Size = New System.Drawing.Size(230, 635)
        Me.tab_SeatracNavigate.TabIndex = 3
        Me.tab_SeatracNavigate.Text = "Navigate"
        Me.tab_SeatracNavigate.UseVisualStyleBackColor = True
        '
        'SplitContainer5
        '
        Me.SplitContainer5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer5.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer5.Name = "SplitContainer5"
        Me.SplitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer5.Panel1
        '
        Me.SplitContainer5.Panel1.Controls.Add(Me.TableLayoutPanel14)
        '
        'SplitContainer5.Panel2
        '
        Me.SplitContainer5.Panel2.Controls.Add(Me.ListView2)
        Me.SplitContainer5.Size = New System.Drawing.Size(230, 635)
        Me.SplitContainer5.SplitterDistance = 107
        Me.SplitContainer5.TabIndex = 4
        '
        'TableLayoutPanel14
        '
        Me.TableLayoutPanel14.ColumnCount = 2
        Me.TableLayoutPanel14.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel14.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel14.Controls.Add(Me.btn_ClearPin, 1, 0)
        Me.TableLayoutPanel14.Controls.Add(Me.btn_SeatracPin, 0, 0)
        Me.TableLayoutPanel14.Controls.Add(Me.btn_SeatracSendPin, 0, 1)
        Me.TableLayoutPanel14.Controls.Add(Me.btn_SendPinTag, 1, 1)
        Me.TableLayoutPanel14.Controls.Add(Me.txt_PositionDepth, 0, 2)
        Me.TableLayoutPanel14.Controls.Add(Me.txt_PositionYaw, 1, 2)
        Me.TableLayoutPanel14.Controls.Add(Me.btn_Nav, 0, 3)
        Me.TableLayoutPanel14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel14.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel14.Name = "TableLayoutPanel14"
        Me.TableLayoutPanel14.RowCount = 4
        Me.TableLayoutPanel14.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel14.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel14.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel14.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel14.Size = New System.Drawing.Size(230, 107)
        Me.TableLayoutPanel14.TabIndex = 5
        '
        'btn_ClearPin
        '
        Me.btn_ClearPin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_ClearPin.Location = New System.Drawing.Point(117, 2)
        Me.btn_ClearPin.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_ClearPin.Name = "btn_ClearPin"
        Me.btn_ClearPin.Size = New System.Drawing.Size(111, 22)
        Me.btn_ClearPin.TabIndex = 1
        Me.btn_ClearPin.Text = "Clear Pin"
        Me.btn_ClearPin.UseVisualStyleBackColor = True
        '
        'btn_SeatracPin
        '
        Me.btn_SeatracPin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_SeatracPin.Location = New System.Drawing.Point(2, 2)
        Me.btn_SeatracPin.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_SeatracPin.Name = "btn_SeatracPin"
        Me.btn_SeatracPin.Size = New System.Drawing.Size(111, 22)
        Me.btn_SeatracPin.TabIndex = 0
        Me.btn_SeatracPin.Text = "Pin"
        Me.btn_SeatracPin.UseVisualStyleBackColor = True
        '
        'btn_SeatracSendPin
        '
        Me.btn_SeatracSendPin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_SeatracSendPin.Location = New System.Drawing.Point(2, 28)
        Me.btn_SeatracSendPin.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_SeatracSendPin.Name = "btn_SeatracSendPin"
        Me.btn_SeatracSendPin.Size = New System.Drawing.Size(111, 22)
        Me.btn_SeatracSendPin.TabIndex = 3
        Me.btn_SeatracSendPin.Text = "Send Pin"
        Me.btn_SeatracSendPin.UseVisualStyleBackColor = True
        '
        'btn_SendPinTag
        '
        Me.btn_SendPinTag.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_SendPinTag.Location = New System.Drawing.Point(118, 29)
        Me.btn_SendPinTag.Name = "btn_SendPinTag"
        Me.btn_SendPinTag.Size = New System.Drawing.Size(109, 20)
        Me.btn_SendPinTag.TabIndex = 4
        Me.btn_SendPinTag.Text = "USBL"
        Me.btn_SendPinTag.UseVisualStyleBackColor = True
        '
        'txt_PositionDepth
        '
        Me.txt_PositionDepth.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_PositionDepth.DecimalPlaces = 1
        Me.txt_PositionDepth.Location = New System.Drawing.Point(3, 55)
        Me.txt_PositionDepth.Name = "txt_PositionDepth"
        Me.txt_PositionDepth.Size = New System.Drawing.Size(109, 20)
        Me.txt_PositionDepth.TabIndex = 5
        '
        'txt_PositionYaw
        '
        Me.txt_PositionYaw.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_PositionYaw.Hexadecimal = True
        Me.txt_PositionYaw.Location = New System.Drawing.Point(118, 55)
        Me.txt_PositionYaw.Name = "txt_PositionYaw"
        Me.txt_PositionYaw.Size = New System.Drawing.Size(109, 20)
        Me.txt_PositionYaw.TabIndex = 6
        '
        'ListView2
        '
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.list_Latitude, Me.list_Longtitude, Me.list_Depth, Me.list_Yaw})
        Me.ListView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView2.HideSelection = False
        Me.ListView2.Location = New System.Drawing.Point(0, 0)
        Me.ListView2.Margin = New System.Windows.Forms.Padding(2)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(230, 524)
        Me.ListView2.TabIndex = 2
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'list_Latitude
        '
        Me.list_Latitude.Text = "Latitude"
        '
        'list_Longtitude
        '
        Me.list_Longtitude.Text = "Longtitude"
        Me.list_Longtitude.Width = 99
        '
        'list_Depth
        '
        Me.list_Depth.Text = "Depth"
        '
        'list_Yaw
        '
        Me.list_Yaw.Text = "Yaw"
        '
        'tab_Setting
        '
        Me.tab_Setting.Controls.Add(Me.SplitContainer3)
        Me.tab_Setting.Location = New System.Drawing.Point(4, 22)
        Me.tab_Setting.Name = "tab_Setting"
        Me.tab_Setting.Size = New System.Drawing.Size(230, 635)
        Me.tab_Setting.TabIndex = 2
        Me.tab_Setting.Text = "Setting"
        Me.tab_Setting.UseVisualStyleBackColor = True
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Margin = New System.Windows.Forms.Padding(2)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.GroupBox9)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.grp_SettingSeatrac)
        Me.SplitContainer3.Size = New System.Drawing.Size(230, 635)
        Me.SplitContainer3.SplitterDistance = 133
        Me.SplitContainer3.SplitterWidth = 3
        Me.SplitContainer3.TabIndex = 0
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.TableLayoutPanel11)
        Me.GroupBox9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox9.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox9.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox9.Size = New System.Drawing.Size(230, 133)
        Me.GroupBox9.TabIndex = 0
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "GPS"
        '
        'TableLayoutPanel11
        '
        Me.TableLayoutPanel11.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel11.ColumnCount = 2
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel11.Controls.Add(Me.Label5, 0, 0)
        Me.TableLayoutPanel11.Controls.Add(Me.Label6, 0, 1)
        Me.TableLayoutPanel11.Controls.Add(Me.txt_OffsetX, 1, 0)
        Me.TableLayoutPanel11.Controls.Add(Me.txt_OffsetY, 1, 1)
        Me.TableLayoutPanel11.Location = New System.Drawing.Point(26, 19)
        Me.TableLayoutPanel11.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel11.Name = "TableLayoutPanel11"
        Me.TableLayoutPanel11.RowCount = 2
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel11.Size = New System.Drawing.Size(148, 81)
        Me.TableLayoutPanel11.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(2, 13)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Off_X"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(2, 54)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Off_Y"
        '
        'txt_OffsetX
        '
        Me.txt_OffsetX.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_OffsetX.Location = New System.Drawing.Point(77, 10)
        Me.txt_OffsetX.Name = "txt_OffsetX"
        Me.txt_OffsetX.Size = New System.Drawing.Size(68, 20)
        Me.txt_OffsetX.TabIndex = 17
        '
        'txt_OffsetY
        '
        Me.txt_OffsetY.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_OffsetY.Location = New System.Drawing.Point(77, 50)
        Me.txt_OffsetY.Name = "txt_OffsetY"
        Me.txt_OffsetY.Size = New System.Drawing.Size(68, 20)
        Me.txt_OffsetY.TabIndex = 18
        '
        'grp_SettingSeatrac
        '
        Me.grp_SettingSeatrac.Controls.Add(Me.SplitContainer4)
        Me.grp_SettingSeatrac.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grp_SettingSeatrac.Enabled = False
        Me.grp_SettingSeatrac.Location = New System.Drawing.Point(0, 0)
        Me.grp_SettingSeatrac.Margin = New System.Windows.Forms.Padding(2)
        Me.grp_SettingSeatrac.Name = "grp_SettingSeatrac"
        Me.grp_SettingSeatrac.Padding = New System.Windows.Forms.Padding(2)
        Me.grp_SettingSeatrac.Size = New System.Drawing.Size(230, 499)
        Me.grp_SettingSeatrac.TabIndex = 0
        Me.grp_SettingSeatrac.TabStop = False
        Me.grp_SettingSeatrac.Text = "Seatrac"
        '
        'SplitContainer4
        '
        Me.SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer4.Location = New System.Drawing.Point(2, 15)
        Me.SplitContainer4.Margin = New System.Windows.Forms.Padding(2)
        Me.SplitContainer4.Name = "SplitContainer4"
        Me.SplitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer4.Panel1
        '
        Me.SplitContainer4.Panel1.Controls.Add(Me.TableLayoutPanel12)
        '
        'SplitContainer4.Panel2
        '
        Me.SplitContainer4.Panel2.Controls.Add(Me.ListView3)
        Me.SplitContainer4.Size = New System.Drawing.Size(226, 482)
        Me.SplitContainer4.SplitterDistance = 157
        Me.SplitContainer4.SplitterWidth = 3
        Me.SplitContainer4.TabIndex = 11
        '
        'TableLayoutPanel12
        '
        Me.TableLayoutPanel12.ColumnCount = 2
        Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel12.Controls.Add(Me.Label7, 0, 0)
        Me.TableLayoutPanel12.Controls.Add(Me.btn_SeatracSendData, 0, 2)
        Me.TableLayoutPanel12.Controls.Add(Me.txt_SeatracData, 1, 2)
        Me.TableLayoutPanel12.Controls.Add(Me.btn_PingTest, 0, 1)
        Me.TableLayoutPanel12.Controls.Add(Me.txt_PingInterval, 1, 0)
        Me.TableLayoutPanel12.Controls.Add(Me.txt_PingTestCount, 1, 1)
        Me.TableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel12.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel12.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel12.Name = "TableLayoutPanel12"
        Me.TableLayoutPanel12.RowCount = 3
        Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel12.Size = New System.Drawing.Size(226, 157)
        Me.TableLayoutPanel12.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(2, 19)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Ping Interval"
        '
        'btn_SeatracSendData
        '
        Me.btn_SeatracSendData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_SeatracSendData.Location = New System.Drawing.Point(2, 106)
        Me.btn_SeatracSendData.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_SeatracSendData.Name = "btn_SeatracSendData"
        Me.btn_SeatracSendData.Size = New System.Drawing.Size(109, 49)
        Me.btn_SeatracSendData.TabIndex = 4
        Me.btn_SeatracSendData.Text = "Send data"
        Me.btn_SeatracSendData.UseVisualStyleBackColor = True
        '
        'txt_SeatracData
        '
        Me.txt_SeatracData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_SeatracData.Location = New System.Drawing.Point(115, 106)
        Me.txt_SeatracData.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_SeatracData.Name = "txt_SeatracData"
        Me.txt_SeatracData.Size = New System.Drawing.Size(109, 49)
        Me.txt_SeatracData.TabIndex = 3
        Me.txt_SeatracData.Text = ""
        '
        'btn_PingTest
        '
        Me.btn_PingTest.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_PingTest.Location = New System.Drawing.Point(3, 55)
        Me.btn_PingTest.Name = "btn_PingTest"
        Me.btn_PingTest.Size = New System.Drawing.Size(107, 46)
        Me.btn_PingTest.TabIndex = 5
        Me.btn_PingTest.Text = "Ping test"
        Me.btn_PingTest.UseVisualStyleBackColor = True
        '
        'txt_PingInterval
        '
        Me.txt_PingInterval.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_PingInterval.Location = New System.Drawing.Point(116, 16)
        Me.txt_PingInterval.Name = "txt_PingInterval"
        Me.txt_PingInterval.Size = New System.Drawing.Size(107, 20)
        Me.txt_PingInterval.TabIndex = 7
        Me.txt_PingInterval.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'txt_PingTestCount
        '
        Me.txt_PingTestCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_PingTestCount.Location = New System.Drawing.Point(116, 68)
        Me.txt_PingTestCount.Name = "txt_PingTestCount"
        Me.txt_PingTestCount.Size = New System.Drawing.Size(107, 20)
        Me.txt_PingTestCount.TabIndex = 8
        Me.txt_PingTestCount.Value = New Decimal(New Integer() {30, 0, 0, 0})
        '
        'ListView3
        '
        Me.ListView3.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.ListView3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView3.HideSelection = False
        Me.ListView3.Location = New System.Drawing.Point(0, 0)
        Me.ListView3.Name = "ListView3"
        Me.ListView3.Size = New System.Drawing.Size(226, 322)
        Me.ListView3.TabIndex = 10
        Me.ListView3.UseCompatibleStateImageBehavior = False
        Me.ListView3.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Data"
        Me.ColumnHeader1.Width = 142
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Value"
        Me.ColumnHeader2.Width = 153
        '
        'TableLayoutPanel10
        '
        Me.TableLayoutPanel10.ColumnCount = 1
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel10.Controls.Add(Me.TableLayoutPanel4, 0, 1)
        Me.TableLayoutPanel10.Controls.Add(Me.AxMap1, 0, 0)
        Me.TableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel10.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel10.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel10.Name = "TableLayoutPanel10"
        Me.TableLayoutPanel10.RowCount = 2
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49.0!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.TableLayoutPanel10.Size = New System.Drawing.Size(829, 661)
        Me.TableLayoutPanel10.TabIndex = 1
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 5
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel4.Controls.Add(Me.btn_ZoomInMap, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.btn_MoveMap, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.btn_AreaMap, 4, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.bnt_MeasureMap, 3, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.btn_ZoomOutMap, 2, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 615)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(823, 43)
        Me.TableLayoutPanel4.TabIndex = 0
        '
        'btn_ZoomInMap
        '
        Me.btn_ZoomInMap.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_ZoomInMap.Location = New System.Drawing.Point(167, 3)
        Me.btn_ZoomInMap.Name = "btn_ZoomInMap"
        Me.btn_ZoomInMap.Size = New System.Drawing.Size(158, 37)
        Me.btn_ZoomInMap.TabIndex = 5
        Me.btn_ZoomInMap.Text = "Zoom In"
        Me.btn_ZoomInMap.UseVisualStyleBackColor = True
        '
        'btn_MoveMap
        '
        Me.btn_MoveMap.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_MoveMap.Location = New System.Drawing.Point(3, 3)
        Me.btn_MoveMap.Name = "btn_MoveMap"
        Me.btn_MoveMap.Size = New System.Drawing.Size(158, 37)
        Me.btn_MoveMap.TabIndex = 0
        Me.btn_MoveMap.Text = "Move"
        Me.btn_MoveMap.UseVisualStyleBackColor = True
        '
        'btn_AreaMap
        '
        Me.btn_AreaMap.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_AreaMap.Location = New System.Drawing.Point(659, 3)
        Me.btn_AreaMap.Name = "btn_AreaMap"
        Me.btn_AreaMap.Size = New System.Drawing.Size(161, 37)
        Me.btn_AreaMap.TabIndex = 3
        Me.btn_AreaMap.Text = "Area"
        Me.btn_AreaMap.UseVisualStyleBackColor = True
        '
        'bnt_MeasureMap
        '
        Me.bnt_MeasureMap.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bnt_MeasureMap.Location = New System.Drawing.Point(495, 3)
        Me.bnt_MeasureMap.Name = "bnt_MeasureMap"
        Me.bnt_MeasureMap.Size = New System.Drawing.Size(158, 37)
        Me.bnt_MeasureMap.TabIndex = 2
        Me.bnt_MeasureMap.Text = "Measure"
        Me.bnt_MeasureMap.UseVisualStyleBackColor = True
        '
        'btn_ZoomOutMap
        '
        Me.btn_ZoomOutMap.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_ZoomOutMap.Location = New System.Drawing.Point(331, 3)
        Me.btn_ZoomOutMap.Name = "btn_ZoomOutMap"
        Me.btn_ZoomOutMap.Size = New System.Drawing.Size(158, 37)
        Me.btn_ZoomOutMap.TabIndex = 1
        Me.btn_ZoomOutMap.Text = "Zoom Out"
        Me.btn_ZoomOutMap.UseVisualStyleBackColor = True
        '
        'AxMap1
        '
        Me.AxMap1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AxMap1.Enabled = True
        Me.AxMap1.Location = New System.Drawing.Point(3, 3)
        Me.AxMap1.Name = "AxMap1"
        Me.AxMap1.OcxState = CType(resources.GetObject("AxMap1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxMap1.Size = New System.Drawing.Size(823, 606)
        Me.AxMap1.TabIndex = 7
        '
        'port_GPS
        '
        '
        'port_Seatrac
        '
        '
        'tmr_SeatracPingInterval
        '
        Me.tmr_SeatracPingInterval.Interval = 5000
        '
        'tmr_SeatracStatusUpdate
        '
        Me.tmr_SeatracStatusUpdate.Interval = 1000
        '
        'btn_Nav
        '
        Me.btn_Nav.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Nav.Location = New System.Drawing.Point(3, 81)
        Me.btn_Nav.Name = "btn_Nav"
        Me.btn_Nav.Size = New System.Drawing.Size(109, 23)
        Me.btn_Nav.TabIndex = 7
        Me.btn_Nav.Text = "Navigate"
        Me.btn_Nav.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1071, 661)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.tab_Map.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.tab_Seatrac.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.TableLayoutPanel8.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.TableLayoutPanel9.ResumeLayout(False)
        Me.TableLayoutPanel9.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.TableLayoutPanel13.ResumeLayout(False)
        Me.tab_SeatracNavigate.ResumeLayout(False)
        Me.SplitContainer5.Panel1.ResumeLayout(False)
        Me.SplitContainer5.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer5.ResumeLayout(False)
        Me.TableLayoutPanel14.ResumeLayout(False)
        CType(Me.txt_PositionDepth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_PositionYaw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_Setting.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.TableLayoutPanel11.ResumeLayout(False)
        Me.TableLayoutPanel11.PerformLayout()
        CType(Me.txt_OffsetX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_OffsetY, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_SettingSeatrac.ResumeLayout(False)
        Me.SplitContainer4.Panel1.ResumeLayout(False)
        Me.SplitContainer4.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer4.ResumeLayout(False)
        Me.TableLayoutPanel12.ResumeLayout(False)
        Me.TableLayoutPanel12.PerformLayout()
        CType(Me.txt_PingInterval, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_PingTestCount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel10.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        CType(Me.AxMap1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tab_Map As TabPage
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents go_KMUTNB As Button
    Friend WithEvents tab_Setting As TabPage
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents btn_MoveMap As Button
    Friend WithEvents btn_ZoomOutMap As Button
    Friend WithEvents bnt_MeasureMap As Button
    Friend WithEvents btn_AreaMap As Button
    Friend WithEvents btn_ZoomInMap As Button
    Friend WithEvents tab_Seatrac As TabPage
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents cmb_GPSBaud As ComboBox
    Friend WithEvents cmb_GPSPort As ComboBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents TableLayoutPanel9 As TableLayoutPanel
    Friend WithEvents btn_Seatrac_Connect As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmb_SeatracBaud As ComboBox
    Friend WithEvents cmb_SeatracPort As ComboBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents list_Data As ColumnHeader
    Friend WithEvents List_Value As ColumnHeader
    Friend WithEvents port_GPS As IO.Ports.SerialPort
    Friend WithEvents port_Seatrac As IO.Ports.SerialPort
    Friend WithEvents TableLayoutPanel10 As TableLayoutPanel
    Friend WithEvents AxMap1 As AxMapWinGIS.AxMap
    Friend WithEvents btn_ClearSeatrac As Button
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents go_GPS As Button
    Friend WithEvents btn_GPS_Connect As Button
    Friend WithEvents SplitContainer3 As SplitContainer
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents grp_SettingSeatrac As GroupBox
    Friend WithEvents TableLayoutPanel11 As TableLayoutPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TableLayoutPanel12 As TableLayoutPanel
    Friend WithEvents Label7 As Label
    Friend WithEvents btn_Ping As Button
    Friend WithEvents tmr_SeatracPingInterval As Timer
    Friend WithEvents map_OpenStreetMap As Button
    Friend WithEvents map_OpenHumanitarianMap As Button
    Friend WithEvents TableLayoutPanel13 As TableLayoutPanel
    Friend WithEvents btn_ClearGPS As Button
    Friend WithEvents txt_SeatracData As RichTextBox
    Friend WithEvents btn_SeatracSendData As Button
    Friend WithEvents tab_SeatracNavigate As TabPage
    Friend WithEvents btn_SeatracPin As Button
    Friend WithEvents btn_ClearPin As Button
    Friend WithEvents ListView2 As ListView
    Friend WithEvents list_Latitude As ColumnHeader
    Friend WithEvents list_Longtitude As ColumnHeader
    Friend WithEvents btn_SeatracSendPin As Button
    Friend WithEvents btn_GoToCoordinate As Button
    Friend WithEvents txt_GotToLat As TextBox
    Friend WithEvents txt_GoToLon As TextBox
    Friend WithEvents btn_BingSatelliteMap As Button
    Friend WithEvents btn_BingHybrid As Button
    Friend WithEvents btn_BingMap As Button
    Friend WithEvents SplitContainer4 As SplitContainer
    Friend WithEvents ListView3 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents tmr_SeatracStatusUpdate As Timer
    Friend WithEvents btn_PingTest As Button
    Friend WithEvents SplitContainer5 As SplitContainer
    Friend WithEvents TableLayoutPanel14 As TableLayoutPanel
    Friend WithEvents btn_SendPinTag As Button
    Friend WithEvents txt_OffsetX As NumericUpDown
    Friend WithEvents txt_OffsetY As NumericUpDown
    Friend WithEvents txt_PingInterval As NumericUpDown
    Friend WithEvents txt_PingTestCount As NumericUpDown
    Friend WithEvents txt_PositionDepth As NumericUpDown
    Friend WithEvents txt_PositionYaw As NumericUpDown
    Friend WithEvents list_Depth As ColumnHeader
    Friend WithEvents list_Yaw As ColumnHeader
    Friend WithEvents btn_Nav As Button
End Class

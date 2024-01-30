<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoader
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLoader))
        lstVersions = New ListBox()
        Label1 = New Label()
        Label2 = New Label()
        btnReload = New Button()
        GroupBox1 = New GroupBox()
        lblName = New Label()
        chkAgreeEula = New CheckBox()
        LinkLabel1 = New LinkLabel()
        chkDisableGui = New CheckBox()
        chkChangeRamLimit = New CheckBox()
        tkbRamLow = New TrackBar()
        lblRamMin = New Label()
        Label4 = New Label()
        tkbRamMax = New TrackBar()
        lblRamMax = New Label()
        Label5 = New Label()
        Label3 = New Label()
        GroupBox2 = New GroupBox()
        txtProp = New TextBox()
        Label6 = New Label()
        GroupBox3 = New GroupBox()
        btnResetProp = New Button()
        btnRead = New Button()
        btnApply = New Button()
        btnReadProp = New Button()
        txtFilePath = New TextBox()
        Label7 = New Label()
        numSpawnProt = New NumericUpDown()
        numMaxView = New NumericUpDown()
        numPort = New NumericUpDown()
        numMaxPlayer = New NumericUpDown()
        cmbOnlineMode = New ComboBox()
        Label15 = New Label()
        cmbCmdBlock = New ComboBox()
        Label14 = New Label()
        cmbDifficutly = New ComboBox()
        Label13 = New Label()
        cmbMode = New ComboBox()
        Label12 = New Label()
        cmbPvp = New ComboBox()
        Label11 = New Label()
        txtMotd = New TextBox()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        lblPort = New Label()
        lbMaxPlayer = New Label()
        btnStart = New Button()
        chkDisableLog = New CheckBox()
        ToolTip1 = New ToolTip(components)
        ofdOpenProp = New OpenFileDialog()
        GroupBox1.SuspendLayout()
        CType(tkbRamLow, ComponentModel.ISupportInitialize).BeginInit()
        CType(tkbRamMax, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        CType(numSpawnProt, ComponentModel.ISupportInitialize).BeginInit()
        CType(numMaxView, ComponentModel.ISupportInitialize).BeginInit()
        CType(numPort, ComponentModel.ISupportInitialize).BeginInit()
        CType(numMaxPlayer, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lstVersions
        ' 
        lstVersions.Font = New Font("Microsoft YaHei UI", 9F)
        lstVersions.FormattingEnabled = True
        lstVersions.ItemHeight = 17
        lstVersions.Location = New Point(12, 29)
        lstVersions.Name = "lstVersions"
        lstVersions.Size = New Size(219, 310)
        lstVersions.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft YaHei UI", 9F)
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(120, 17)
        Label1.TabIndex = 1
        Label1.Text = "選擇伺服器版本(&V)："
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Microsoft YaHei UI", 9F)
        Label2.Location = New Point(12, 384)
        Label2.Name = "Label2"
        Label2.Size = New Size(219, 57)
        Label2.TabIndex = 2
        Label2.Text = "請將所有可用版本置放於與程式二進位檔案同目錄下後點按""重載入""按鈕以檢查。" & vbCrLf & "該檔案須為Jar格式文件！" & vbCrLf
        ' 
        ' btnReload
        ' 
        btnReload.Font = New Font("Microsoft YaHei UI", 9F)
        btnReload.Location = New Point(133, 353)
        btnReload.Name = "btnReload"
        btnReload.Size = New Size(98, 28)
        btnReload.TabIndex = 3
        btnReload.Text = "重新載入(&R)"
        btnReload.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(lblName)
        GroupBox1.Location = New Point(237, 9)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(260, 45)
        GroupBox1.TabIndex = 5
        GroupBox1.TabStop = False
        GroupBox1.Text = "Jar資料"
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(6, 19)
        lblName.Name = "lblName"
        lblName.Size = New Size(67, 15)
        lblName.TabIndex = 5
        lblName.Text = "檔案名稱："
        ' 
        ' chkAgreeEula
        ' 
        chkAgreeEula.AutoSize = True
        chkAgreeEula.Location = New Point(6, 22)
        chkAgreeEula.Name = "chkAgreeEula"
        chkAgreeEula.Size = New Size(158, 19)
        chkAgreeEula.TabIndex = 0
        chkAgreeEula.Text = "我同意Minecraft的EULA"
        chkAgreeEula.UseVisualStyleBackColor = True
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Location = New Point(193, 22)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(61, 15)
        LinkLabel1.TabIndex = 1
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "檢視EULA"
        ' 
        ' chkDisableGui
        ' 
        chkDisableGui.AutoSize = True
        chkDisableGui.Location = New Point(6, 47)
        chkDisableGui.Name = "chkDisableGui"
        chkDisableGui.Size = New Size(136, 19)
        chkDisableGui.TabIndex = 2
        chkDisableGui.Text = "禁用GUI管理介面(&G)"
        chkDisableGui.UseVisualStyleBackColor = True
        ' 
        ' chkChangeRamLimit
        ' 
        chkChangeRamLimit.AutoSize = True
        chkChangeRamLimit.Location = New Point(6, 72)
        chkChangeRamLimit.Name = "chkChangeRamLimit"
        chkChangeRamLimit.Size = New Size(126, 19)
        chkChangeRamLimit.TabIndex = 3
        chkChangeRamLimit.Text = "更改記憶體限制(&R)"
        chkChangeRamLimit.UseVisualStyleBackColor = True
        ' 
        ' tkbRamLow
        ' 
        tkbRamLow.Enabled = False
        tkbRamLow.LargeChange = 1024
        tkbRamLow.Location = New Point(29, 112)
        tkbRamLow.Maximum = 16384
        tkbRamLow.Name = "tkbRamLow"
        tkbRamLow.Size = New Size(162, 45)
        tkbRamLow.TabIndex = 4
        tkbRamLow.TickFrequency = 1024
        ' 
        ' lblRamMin
        ' 
        lblRamMin.Location = New Point(194, 112)
        lblRamMin.Name = "lblRamMin"
        lblRamMin.Size = New Size(61, 45)
        lblRamMin.TabIndex = 5
        lblRamMin.Text = "0"
        lblRamMin.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(29, 94)
        Label4.Name = "Label4"
        Label4.Size = New Size(99, 15)
        Label4.TabIndex = 6
        Label4.Text = "最小記憶體(&M)："
        ' 
        ' tkbRamMax
        ' 
        tkbRamMax.Enabled = False
        tkbRamMax.LargeChange = 1024
        tkbRamMax.Location = New Point(29, 178)
        tkbRamMax.Maximum = 16384
        tkbRamMax.Name = "tkbRamMax"
        tkbRamMax.Size = New Size(162, 45)
        tkbRamMax.TabIndex = 7
        tkbRamMax.TickFrequency = 1024
        ' 
        ' lblRamMax
        ' 
        lblRamMax.Location = New Point(194, 178)
        lblRamMax.Name = "lblRamMax"
        lblRamMax.Size = New Size(61, 45)
        lblRamMax.TabIndex = 8
        lblRamMax.Text = "0"
        lblRamMax.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(29, 160)
        Label5.Name = "Label5"
        Label5.Size = New Size(95, 15)
        Label5.TabIndex = 9
        Label5.Text = "最大記憶體(&A)："
        ' 
        ' Label3
        ' 
        Label3.Location = New Point(29, 208)
        Label3.Name = "Label3"
        Label3.Size = New Size(225, 47)
        Label3.TabIndex = 10
        Label3.Text = "記憶體顯示單位為MB" & vbCrLf & "平均而言一位玩家約占用100MB左右空間"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(txtProp)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(lblRamMax)
        GroupBox2.Controls.Add(tkbRamMax)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(lblRamMin)
        GroupBox2.Controls.Add(tkbRamLow)
        GroupBox2.Controls.Add(chkChangeRamLimit)
        GroupBox2.Controls.Add(chkDisableGui)
        GroupBox2.Controls.Add(LinkLabel1)
        GroupBox2.Controls.Add(chkAgreeEula)
        GroupBox2.Location = New Point(237, 60)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(260, 310)
        GroupBox2.TabIndex = 6
        GroupBox2.TabStop = False
        GroupBox2.Text = "啟動選項(&L)"
        ' 
        ' txtProp
        ' 
        txtProp.Location = New Point(6, 281)
        txtProp.Name = "txtProp"
        txtProp.Size = New Size(248, 23)
        txtProp.TabIndex = 12
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(6, 263)
        Label6.Name = "Label6"
        Label6.Size = New Size(106, 15)
        Label6.TabIndex = 11
        Label6.Text = "自訂啟動參數(&P)："
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(btnResetProp)
        GroupBox3.Controls.Add(btnRead)
        GroupBox3.Controls.Add(btnApply)
        GroupBox3.Controls.Add(btnReadProp)
        GroupBox3.Controls.Add(txtFilePath)
        GroupBox3.Controls.Add(Label7)
        GroupBox3.Controls.Add(numSpawnProt)
        GroupBox3.Controls.Add(numMaxView)
        GroupBox3.Controls.Add(numPort)
        GroupBox3.Controls.Add(numMaxPlayer)
        GroupBox3.Controls.Add(cmbOnlineMode)
        GroupBox3.Controls.Add(Label15)
        GroupBox3.Controls.Add(cmbCmdBlock)
        GroupBox3.Controls.Add(Label14)
        GroupBox3.Controls.Add(cmbDifficutly)
        GroupBox3.Controls.Add(Label13)
        GroupBox3.Controls.Add(cmbMode)
        GroupBox3.Controls.Add(Label12)
        GroupBox3.Controls.Add(cmbPvp)
        GroupBox3.Controls.Add(Label11)
        GroupBox3.Controls.Add(txtMotd)
        GroupBox3.Controls.Add(Label10)
        GroupBox3.Controls.Add(Label9)
        GroupBox3.Controls.Add(Label8)
        GroupBox3.Controls.Add(lblPort)
        GroupBox3.Controls.Add(lbMaxPlayer)
        GroupBox3.Location = New Point(503, 9)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(315, 432)
        GroupBox3.TabIndex = 7
        GroupBox3.TabStop = False
        GroupBox3.Text = "Server.Propties編輯器"
        ' 
        ' btnResetProp
        ' 
        btnResetProp.Location = New Point(72, 366)
        btnResetProp.Name = "btnResetProp"
        btnResetProp.Size = New Size(75, 25)
        btnResetProp.TabIndex = 39
        btnResetProp.Text = "重設(&E)"
        btnResetProp.UseVisualStyleBackColor = True
        ' 
        ' btnRead
        ' 
        btnRead.Location = New Point(153, 366)
        btnRead.Name = "btnRead"
        btnRead.Size = New Size(75, 25)
        btnRead.TabIndex = 38
        btnRead.Text = "讀取(&R)"
        btnRead.UseVisualStyleBackColor = True
        ' 
        ' btnApply
        ' 
        btnApply.Location = New Point(234, 366)
        btnApply.Name = "btnApply"
        btnApply.Size = New Size(75, 25)
        btnApply.TabIndex = 37
        btnApply.Text = "套用(&A)"
        btnApply.UseVisualStyleBackColor = True
        ' 
        ' btnReadProp
        ' 
        btnReadProp.Location = New Point(282, 337)
        btnReadProp.Name = "btnReadProp"
        btnReadProp.Size = New Size(27, 23)
        btnReadProp.TabIndex = 36
        btnReadProp.Text = "..."
        btnReadProp.UseVisualStyleBackColor = True
        ' 
        ' txtFilePath
        ' 
        txtFilePath.Location = New Point(133, 337)
        txtFilePath.Name = "txtFilePath"
        txtFilePath.ReadOnly = True
        txtFilePath.Size = New Size(143, 23)
        txtFilePath.TabIndex = 35
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(6, 340)
        Label7.Name = "Label7"
        Label7.Size = New Size(118, 15)
        Label7.TabIndex = 34
        Label7.Text = "伺服器屬性檔案(&P)："
        ' 
        ' numSpawnProt
        ' 
        numSpawnProt.Location = New Point(133, 79)
        numSpawnProt.Name = "numSpawnProt"
        numSpawnProt.Size = New Size(176, 23)
        numSpawnProt.TabIndex = 33
        ToolTip1.SetToolTip(numSpawnProt, "spawn-protection" & vbCrLf & vbCrLf & "透過將該值進行2x+1的運算來決定重生點的保護半徑。" & vbCrLf & "設定為1會保護以重生點為中心的3×3方塊的區域，2會保護5×5方塊的區域，3會保護7×7方塊的區域，以此類推。" & vbCrLf & "這個選項不在第一次伺服器啟動時生成，只會在第一個玩家加入伺服器時出現。" & vbCrLf & "如果伺服器沒有設定OP，這個選項會自動停用。")
        numSpawnProt.Value = New Decimal(New Integer() {16, 0, 0, 0})
        ' 
        ' numMaxView
        ' 
        numMaxView.Location = New Point(133, 108)
        numMaxView.Maximum = New Decimal(New Integer() {64, 0, 0, 0})
        numMaxView.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        numMaxView.Name = "numMaxView"
        numMaxView.Size = New Size(176, 23)
        numMaxView.TabIndex = 32
        ToolTip1.SetToolTip(numMaxView, "view-distance" & vbCrLf & vbCrLf & "設定伺服器端發送給用戶端的世界資料量，也就是設定玩家各個方向上的區塊數量（是以玩家為中心的半徑，不是直徑）。" & vbCrLf & "它決定了伺服器端的可視距離。（另見顯示距離），" & vbCrLf & "預設/推薦設定為10，如果有嚴重卡頓的話，減少該數值。")
        numMaxView.Value = New Decimal(New Integer() {10, 0, 0, 0})
        ' 
        ' numPort
        ' 
        numPort.Location = New Point(133, 50)
        numPort.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        numPort.Minimum = New Decimal(New Integer() {1024, 0, 0, 0})
        numPort.Name = "numPort"
        numPort.Size = New Size(176, 23)
        numPort.TabIndex = 31
        ToolTip1.SetToolTip(numPort, "server-port" & vbCrLf & vbCrLf & "此為玩家可連線上伺服器的端口。" & vbCrLf & "切記，如果您的25565端口被占用，請記得將此項目更改；否則建議不要更改此設定，以免玩家連線失敗。")
        numPort.Value = New Decimal(New Integer() {25565, 0, 0, 0})
        ' 
        ' numMaxPlayer
        ' 
        numMaxPlayer.Location = New Point(133, 21)
        numMaxPlayer.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        numMaxPlayer.Name = "numMaxPlayer"
        numMaxPlayer.Size = New Size(176, 23)
        numMaxPlayer.TabIndex = 30
        ToolTip1.SetToolTip(numMaxPlayer, "max-players" & vbCrLf & vbCrLf & "這是應該能在伺服器上遊戲的玩家的最大數量。" & vbCrLf & "請切記，較高的值可能會影響伺服器效能。")
        ' 
        ' cmbOnlineMode
        ' 
        cmbOnlineMode.BackColor = SystemColors.Window
        cmbOnlineMode.FormattingEnabled = True
        cmbOnlineMode.Items.AddRange(New Object() {"true", "false"})
        cmbOnlineMode.Location = New Point(133, 281)
        cmbOnlineMode.Name = "cmbOnlineMode"
        cmbOnlineMode.Size = New Size(176, 23)
        cmbOnlineMode.TabIndex = 29
        ToolTip1.SetToolTip(cmbOnlineMode, resources.GetString("cmbOnlineMode.ToolTip"))
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Microsoft YaHei UI", 9F, FontStyle.Bold)
        Label15.Location = New Point(6, 283)
        Label15.Name = "Label15"
        Label15.Size = New Size(68, 17)
        Label15.TabIndex = 28
        Label15.Text = "正版驗證："
        ' 
        ' cmbCmdBlock
        ' 
        cmbCmdBlock.BackColor = SystemColors.Window
        cmbCmdBlock.FormattingEnabled = True
        cmbCmdBlock.Items.AddRange(New Object() {"true", "false"})
        cmbCmdBlock.Location = New Point(133, 252)
        cmbCmdBlock.Name = "cmbCmdBlock"
        cmbCmdBlock.Size = New Size(176, 23)
        cmbCmdBlock.TabIndex = 27
        ToolTip1.SetToolTip(cmbCmdBlock, "enable-command-block" & vbCrLf & vbCrLf & "是否啟用指令方塊。")
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Microsoft YaHei UI", 9F, FontStyle.Bold)
        Label14.Location = New Point(6, 254)
        Label14.Name = "Label14"
        Label14.Size = New Size(92, 17)
        Label14.TabIndex = 26
        Label14.Text = "啟用指令方塊："
        ' 
        ' cmbDifficutly
        ' 
        cmbDifficutly.BackColor = SystemColors.Window
        cmbDifficutly.FormattingEnabled = True
        cmbDifficutly.Items.AddRange(New Object() {"peaceful", "easy", "normal", "hard"})
        cmbDifficutly.Location = New Point(133, 223)
        cmbDifficutly.Name = "cmbDifficutly"
        cmbDifficutly.Size = New Size(176, 23)
        cmbDifficutly.TabIndex = 25
        ToolTip1.SetToolTip(cmbDifficutly, "difficulty" & vbCrLf & vbCrLf & "設定遊戲難易度：" & vbCrLf & "　　peaceful (0) - 和平" & vbCrLf & "　　easy (1) - 簡單" & vbCrLf & "　　normal (2) - 普通" & vbCrLf & "　　hard (3) - 困難")
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Microsoft YaHei UI", 9F, FontStyle.Bold)
        Label13.Location = New Point(6, 225)
        Label13.Name = "Label13"
        Label13.Size = New Size(68, 17)
        Label13.TabIndex = 24
        Label13.Text = "遊戲難度："
        ' 
        ' cmbMode
        ' 
        cmbMode.BackColor = SystemColors.Window
        cmbMode.FormattingEnabled = True
        cmbMode.Items.AddRange(New Object() {"survival", "creative", "adventure", "spectator"})
        cmbMode.Location = New Point(133, 194)
        cmbMode.Name = "cmbMode"
        cmbMode.Size = New Size(176, 23)
        cmbMode.TabIndex = 23
        ToolTip1.SetToolTip(cmbMode, "gamemode" & vbCrLf & vbCrLf & "設定新玩家的遊戲模式。")
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Microsoft YaHei UI", 9F, FontStyle.Bold)
        Label12.Location = New Point(6, 196)
        Label12.Name = "Label12"
        Label12.Size = New Size(92, 17)
        Label12.TabIndex = 22
        Label12.Text = "預設遊戲模式："
        ' 
        ' cmbPvp
        ' 
        cmbPvp.BackColor = SystemColors.Window
        cmbPvp.FormattingEnabled = True
        cmbPvp.Items.AddRange(New Object() {"true", "false"})
        cmbPvp.Location = New Point(133, 165)
        cmbPvp.Name = "cmbPvp"
        cmbPvp.Size = New Size(176, 23)
        cmbPvp.TabIndex = 21
        ToolTip1.SetToolTip(cmbPvp, "pvp" & vbCrLf & vbCrLf & "是否允許PvP。也只有在允許PvP時玩家自己的箭才會受到傷害。" & vbCrLf & "true - 玩家可以互相傷害。" & vbCrLf & "false - 玩家無法互相造成傷害（也稱作玩家對戰環境（PvE））。" & vbCrLf & "註：由玩家造成的間接傷害（例如熔岩，火，TNT等，某種程度上還有水，沙和礫石）還是會傷害其他玩家。")
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Microsoft YaHei UI", 9F, FontStyle.Bold)
        Label11.Location = New Point(6, 167)
        Label11.Name = "Label11"
        Label11.Size = New Size(104, 17)
        Label11.TabIndex = 20
        Label11.Text = "玩家間互相傷害："
        ' 
        ' txtMotd
        ' 
        txtMotd.Location = New Point(133, 136)
        txtMotd.Name = "txtMotd"
        txtMotd.Size = New Size(176, 23)
        txtMotd.TabIndex = 19
        txtMotd.Text = "A Minecraft Server"
        ToolTip1.SetToolTip(txtMotd, "motd" & vbCrLf & vbCrLf & "本屬性值是玩家用戶端的多人遊戲伺服器列表中顯示的伺服器資訊，顯示於名稱下方。" & vbCrLf & "　　MOTD 支持樣式代碼。" & vbCrLf & "　　MOTD 支持特殊符號，比如""♥""。然而，這些符號需要轉換為Unicode轉義字元。你可以在這裡找到一個轉換器。" & vbCrLf & "　　如果MOTD超過59個字元，伺服器列表很可能會返回「通訊錯誤」。")
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Microsoft YaHei UI", 9F, FontStyle.Bold)
        Label10.Location = New Point(6, 138)
        Label10.Name = "Label10"
        Label10.Size = New Size(60, 17)
        Label10.TabIndex = 18
        Label10.Text = "MOTD："
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Microsoft YaHei UI", 9F, FontStyle.Bold)
        Label9.Location = New Point(6, 109)
        Label9.Name = "Label9"
        Label9.Size = New Size(92, 17)
        Label9.TabIndex = 16
        Label9.Text = "最大視野距離："
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft YaHei UI", 9F, FontStyle.Bold)
        Label8.Location = New Point(6, 80)
        Label8.Name = "Label8"
        Label8.Size = New Size(80, 17)
        Label8.TabIndex = 14
        Label8.Text = "重生點保護："
        ' 
        ' lblPort
        ' 
        lblPort.AutoSize = True
        lblPort.Font = New Font("Microsoft YaHei UI", 9F, FontStyle.Bold)
        lblPort.Location = New Point(6, 51)
        lblPort.Name = "lblPort"
        lblPort.Size = New Size(104, 17)
        lblPort.TabIndex = 12
        lblPort.Text = "伺服器連接端口："
        ' 
        ' lbMaxPlayer
        ' 
        lbMaxPlayer.AutoSize = True
        lbMaxPlayer.Font = New Font("Microsoft YaHei UI", 9F, FontStyle.Bold)
        lbMaxPlayer.Location = New Point(6, 22)
        lbMaxPlayer.Name = "lbMaxPlayer"
        lbMaxPlayer.Size = New Size(104, 17)
        lbMaxPlayer.TabIndex = 0
        lbMaxPlayer.Text = "伺服器最大人數："
        ' 
        ' btnStart
        ' 
        btnStart.Font = New Font("Microsoft YaHei UI", 9F)
        btnStart.Location = New Point(377, 410)
        btnStart.Name = "btnStart"
        btnStart.Size = New Size(114, 28)
        btnStart.TabIndex = 8
        btnStart.Text = "啟動伺服器(&L)"
        btnStart.UseVisualStyleBackColor = True
        ' 
        ' chkDisableLog
        ' 
        chkDisableLog.Location = New Point(243, 403)
        chkDisableLog.Name = "chkDisableLog"
        chkDisableLog.Size = New Size(128, 35)
        chkDisableLog.TabIndex = 9
        chkDisableLog.Text = "結束實例後不顯示紀錄視窗"
        chkDisableLog.UseVisualStyleBackColor = True
        ' 
        ' ofdOpenProp
        ' 
        ofdOpenProp.Filter = "伺服器屬性檔(server.properties)|server.properties|Java 設定檔(*.properties)|*.properties|所有檔案 (*.*)|*.*"
        ' 
        ' frmLoader
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(830, 450)
        Controls.Add(chkDisableLog)
        Controls.Add(btnStart)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(btnReload)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lstVersions)
        DoubleBuffered = True
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmLoader"
        Text = "Minecraft 伺服器管理器"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(tkbRamLow, ComponentModel.ISupportInitialize).EndInit()
        CType(tkbRamMax, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        CType(numSpawnProt, ComponentModel.ISupportInitialize).EndInit()
        CType(numMaxView, ComponentModel.ISupportInitialize).EndInit()
        CType(numPort, ComponentModel.ISupportInitialize).EndInit()
        CType(numMaxPlayer, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lstVersions As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnReload As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblName As Label
    Friend WithEvents chkAgreeEula As CheckBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents chkDisableGui As CheckBox
    Friend WithEvents chkChangeRamLimit As CheckBox
    Friend WithEvents tkbRamLow As TrackBar
    Friend WithEvents lblRamMin As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tkbRamMax As TrackBar
    Friend WithEvents lblRamMax As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnStart As Button
    Friend WithEvents txtProp As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents chkDisableLog As CheckBox
    Friend WithEvents cmbPvp As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtMotd As TextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtPort As TextBox
    Friend WithEvents lblPort As Label
    Friend WithEvents lbMaxPlayer As Label
    Friend WithEvents numMaxPlayer As NumericUpDown
    Friend WithEvents cmbOnlineMode As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents cmbCmdBlock As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents cmbDifficutly As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents cmbMode As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents numPort As NumericUpDown
    Friend WithEvents numSpawnProt As NumericUpDown
    Friend WithEvents numMaxView As NumericUpDown
    Friend WithEvents btnRead As Button
    Friend WithEvents btnApply As Button
    Friend WithEvents btnReadProp As Button
    Friend WithEvents txtFilePath As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ofdOpenProp As OpenFileDialog
    Friend WithEvents btnResetProp As Button
End Class

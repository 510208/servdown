<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDownloader
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDownloader))
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        btnCheck = New Button()
        Label8 = New Label()
        lblRamDone = New Label()
        Label6 = New Label()
        lblNetDone = New Label()
        Label5 = New Label()
        lblJavaInstalled = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        TabPage2 = New TabPage()
        LinkLabel2 = New LinkLabel()
        btnDownload = New Button()
        Button1 = New Button()
        txtInstallPath = New TextBox()
        Label7 = New Label()
        CheckBox2 = New CheckBox()
        LinkLabel1 = New LinkLabel()
        CheckBox1 = New CheckBox()
        cmbVersionSelector = New ComboBox()
        Label4 = New Label()
        ttpMain = New ToolTip(components)
        fbdInstallPath = New FolderBrowserDialog()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Dock = DockStyle.Fill
        TabControl1.Location = New Point(0, 0)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(294, 284)
        TabControl1.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(btnCheck)
        TabPage1.Controls.Add(Label8)
        TabPage1.Controls.Add(lblRamDone)
        TabPage1.Controls.Add(Label6)
        TabPage1.Controls.Add(lblNetDone)
        TabPage1.Controls.Add(Label5)
        TabPage1.Controls.Add(lblJavaInstalled)
        TabPage1.Controls.Add(Label3)
        TabPage1.Controls.Add(Label2)
        TabPage1.Controls.Add(Label1)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(286, 256)
        TabPage1.TabIndex = 0
        TabPage1.Text = "檢查環境"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' btnCheck
        ' 
        btnCheck.Font = New Font("Microsoft YaHei UI", 9F)
        btnCheck.Location = New Point(179, 220)
        btnCheck.Name = "btnCheck"
        btnCheck.Size = New Size(99, 28)
        btnCheck.TabIndex = 11
        btnCheck.Text = "檢查(&C)"
        btnCheck.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft YaHei UI", 9F)
        Label8.ForeColor = SystemColors.ControlText
        Label8.Location = New Point(82, 166)
        Label8.Name = "Label8"
        Label8.Size = New Size(128, 17)
        Label8.TabIndex = 10
        Label8.Text = "3GB以上的可用記憶體"
        ' 
        ' lblRamDone
        ' 
        lblRamDone.AutoSize = True
        lblRamDone.Font = New Font("Microsoft YaHei UI", 9F)
        lblRamDone.ForeColor = Color.Red
        lblRamDone.Location = New Point(8, 166)
        lblRamDone.Name = "lblRamDone"
        lblRamDone.Size = New Size(44, 17)
        lblRamDone.TabIndex = 9
        lblRamDone.Text = "未準備"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft YaHei UI", 9F)
        Label6.ForeColor = SystemColors.ControlText
        Label6.Location = New Point(82, 149)
        Label6.Name = "Label6"
        Label6.Size = New Size(80, 17)
        Label6.TabIndex = 8
        Label6.Text = "網際網路連線"
        ' 
        ' lblNetDone
        ' 
        lblNetDone.AutoSize = True
        lblNetDone.Font = New Font("Microsoft YaHei UI", 9F)
        lblNetDone.ForeColor = Color.Red
        lblNetDone.Location = New Point(8, 149)
        lblNetDone.Name = "lblNetDone"
        lblNetDone.Size = New Size(44, 17)
        lblNetDone.TabIndex = 7
        lblNetDone.Text = "未準備"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft YaHei UI", 9F)
        Label5.ForeColor = SystemColors.ControlText
        Label5.Location = New Point(82, 132)
        Label5.Name = "Label5"
        Label5.Size = New Size(91, 17)
        Label5.TabIndex = 4
        Label5.Text = "Java 17 執行時"
        ' 
        ' lblJavaInstalled
        ' 
        lblJavaInstalled.AutoSize = True
        lblJavaInstalled.Font = New Font("Microsoft YaHei UI", 9F)
        lblJavaInstalled.ForeColor = Color.Red
        lblJavaInstalled.Location = New Point(8, 132)
        lblJavaInstalled.Name = "lblJavaInstalled"
        lblJavaInstalled.Size = New Size(44, 17)
        lblJavaInstalled.TabIndex = 3
        lblJavaInstalled.Text = "未安裝"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft YaHei UI", 9F)
        Label3.Location = New Point(82, 108)
        Label3.Name = "Label3"
        Label3.Size = New Size(32, 17)
        Label3.TabIndex = 2
        Label3.Text = "項目"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft YaHei UI", 9F)
        Label2.Location = New Point(8, 108)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 17)
        Label2.TabIndex = 1
        Label2.Text = "已安裝？"
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Microsoft YaHei UI", 9F)
        Label1.Location = New Point(8, 14)
        Label1.Name = "Label1"
        Label1.Size = New Size(272, 70)
        Label1.TabIndex = 0
        Label1.Text = "本頁面會檢查你的電腦是否已經完成建立Minecraft伺服器的前置作業。" & vbCrLf & "請確定你的電腦已經安裝需要的環境，否則程式將會拒絕建立新Minecraft伺服器設定檔。" & vbCrLf
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(LinkLabel2)
        TabPage2.Controls.Add(btnDownload)
        TabPage2.Controls.Add(Button1)
        TabPage2.Controls.Add(txtInstallPath)
        TabPage2.Controls.Add(Label7)
        TabPage2.Controls.Add(CheckBox2)
        TabPage2.Controls.Add(LinkLabel1)
        TabPage2.Controls.Add(CheckBox1)
        TabPage2.Controls.Add(cmbVersionSelector)
        TabPage2.Controls.Add(Label4)
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(286, 256)
        TabPage2.TabIndex = 1
        TabPage2.Text = "下載伺服器"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' LinkLabel2
        ' 
        LinkLabel2.AutoSize = True
        LinkLabel2.Location = New Point(8, 227)
        LinkLabel2.Name = "LinkLabel2"
        LinkLabel2.Size = New Size(103, 15)
        LinkLabel2.TabIndex = 13
        LinkLabel2.TabStop = True
        LinkLabel2.Text = "伺服器程式管理器"
        ' 
        ' btnDownload
        ' 
        btnDownload.Font = New Font("Microsoft YaHei UI", 9F)
        btnDownload.Location = New Point(179, 220)
        btnDownload.Name = "btnDownload"
        btnDownload.Size = New Size(99, 28)
        btnDownload.TabIndex = 12
        btnDownload.Text = "下載(&D)"
        btnDownload.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Enabled = False
        Button1.Location = New Point(252, 90)
        Button1.Name = "Button1"
        Button1.Size = New Size(26, 23)
        Button1.TabIndex = 7
        Button1.Text = "..."
        Button1.UseVisualStyleBackColor = True
        ' 
        ' txtInstallPath
        ' 
        txtInstallPath.Enabled = False
        txtInstallPath.Location = New Point(96, 90)
        txtInstallPath.Name = "txtInstallPath"
        txtInstallPath.Size = New Size(150, 23)
        txtInstallPath.TabIndex = 6
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(8, 93)
        Label7.Name = "Label7"
        Label7.Size = New Size(82, 15)
        Label7.TabIndex = 5
        Label7.Text = "安裝路徑(&P)："
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(8, 66)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(131, 19)
        CheckBox2.TabIndex = 4
        CheckBox2.Text = "禁用伺服器終端GUI"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Location = New Point(205, 42)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(73, 15)
        LinkLabel1.TabIndex = 3
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "檢視該EULA"
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(8, 41)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(182, 19)
        CheckBox1.TabIndex = 2
        CheckBox1.Text = "我同意Minecraft官方的EULA"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' cmbVersionSelector
        ' 
        cmbVersionSelector.FormattingEnabled = True
        cmbVersionSelector.Location = New Point(109, 5)
        cmbVersionSelector.Name = "cmbVersionSelector"
        cmbVersionSelector.Size = New Size(169, 23)
        cmbVersionSelector.TabIndex = 1
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(8, 8)
        Label4.Name = "Label4"
        Label4.Size = New Size(95, 15)
        Label4.TabIndex = 0
        Label4.Text = "伺服器版本(&V)："
        ' 
        ' fbdInstallPath
        ' 
        fbdInstallPath.Description = "選擇欲安裝的路徑"
        ' 
        ' frmDownloader
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(294, 284)
        Controls.Add(TabControl1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmDownloader"
        Text = "Minecraft 伺服器下載器"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblJavaInstalled As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblNetDone As Label
    Friend WithEvents btnCheck As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents lblRamDone As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbVersionSelector As ComboBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtInstallPath As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents ttpMain As ToolTip
    Friend WithEvents fbdInstallPath As FolderBrowserDialog
    Friend WithEvents btnDownload As Button
    Friend WithEvents LinkLabel2 As LinkLabel

End Class

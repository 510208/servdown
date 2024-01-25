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
        Label4 = New Label()
        cmbVersionSelector = New ComboBox()
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
        TabControl1.Size = New Size(294, 450)
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
        TabPage1.Size = New Size(286, 422)
        TabPage1.TabIndex = 0
        TabPage1.Text = "檢查環境"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' btnCheck
        ' 
        btnCheck.Font = New Font("Microsoft YaHei UI", 9F)
        btnCheck.Location = New Point(179, 213)
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
        TabPage2.Controls.Add(cmbVersionSelector)
        TabPage2.Controls.Add(Label4)
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(286, 422)
        TabPage2.TabIndex = 1
        TabPage2.Text = "下載伺服器"
        TabPage2.UseVisualStyleBackColor = True
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
        ' cmbVersionSelector
        ' 
        cmbVersionSelector.FormattingEnabled = True
        cmbVersionSelector.Location = New Point(109, 5)
        cmbVersionSelector.Name = "cmbVersionSelector"
        cmbVersionSelector.Size = New Size(169, 23)
        cmbVersionSelector.TabIndex = 1
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(294, 450)
        Controls.Add(TabControl1)
        Name = "Form1"
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

End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLog
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
        Panel1 = New Panel()
        Button2 = New Button()
        Button1 = New Button()
        txtLogCont = New TextBox()
        LinkLabel1 = New LinkLabel()
        FontDialog1 = New FontDialog()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(LinkLabel1)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Dock = DockStyle.Bottom
        Panel1.Location = New Point(0, 391)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(488, 36)
        Panel1.TabIndex = 0
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(276, 3)
        Button2.Name = "Button2"
        Button2.Size = New Size(97, 28)
        Button2.TabIndex = 1
        Button2.Text = "複製紀錄..."
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(379, 3)
        Button1.Name = "Button1"
        Button1.Size = New Size(97, 28)
        Button1.TabIndex = 0
        Button1.Text = "確定(&C)"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' txtLogCont
        ' 
        txtLogCont.Dock = DockStyle.Fill
        txtLogCont.Location = New Point(0, 0)
        txtLogCont.Multiline = True
        txtLogCont.Name = "txtLogCont"
        txtLogCont.ReadOnly = True
        txtLogCont.ScrollBars = ScrollBars.Both
        txtLogCont.Size = New Size(488, 391)
        txtLogCont.TabIndex = 1
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Location = New Point(12, 10)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(55, 15)
        LinkLabel1.TabIndex = 2
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "更換字體"
        ' 
        ' frmLog
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(488, 427)
        Controls.Add(txtLogCont)
        Controls.Add(Panel1)
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmLog"
        Text = "frmLog"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents txtLogCont As TextBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents FontDialog1 As FontDialog
End Class

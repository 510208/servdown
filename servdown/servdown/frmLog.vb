Imports System.Drawing.Text

Public Class frmLog
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Clipboard.SetText(txtLogCont.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        FontDialog1.ShowDialog()
        txtLogCont.Font = FontDialog1.Font
    End Sub

    Private Sub CheckAndSetFont()
        ' 設定欲檢查的字體名稱
        Dim targetFontName As String = "Fira Code"

        ' 創建 InstalledFontCollection 並取得安裝的字體清單
        Dim installedFonts As New InstalledFontCollection()
        Dim fontFamilies() As FontFamily = installedFonts.Families

        ' 檢查用戶是否安裝了目標字體
        Dim fontInstalled As Boolean = fontFamilies.Any(Function(font) font.Name = targetFontName)

        If fontInstalled Then
            ' 如果安裝了目標字體，將 txtLogCont 的字體設定為目標字體
            txtLogCont.Font = New Font(targetFontName, txtLogCont.Font.Size) ' 這裡的 12 是字體大小，你可以根據需要調整
        End If
    End Sub

    Private Sub frmLog_Load(sender As Object, e As EventArgs) Handles Me.Load
        CheckAndSetFont()
    End Sub
End Class
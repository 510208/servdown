Imports System.Drawing.Color
Imports System.Formats.Tar
Imports System.IO

Public Class frmDownloader

    Function getPath() As String
        ' 取得執行檔案的完整路徑
        Dim fullPath As String = System.Reflection.Assembly.GetExecutingAssembly().Location
        ' 取得該路徑的目錄部分
        Dim directoryPath As String = Path.GetDirectoryName(fullPath)
        Return directoryPath
    End Function

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        Dim javaStat As Boolean = chkJava()
        Dim memStat As Boolean = chkMemory()
        Dim netStat As Boolean = chkNet()
        If javaStat Then
            lblJavaInstalled.Text = "已安裝"
            lblJavaInstalled.ForeColor = Color.Green
        Else
            lblJavaInstalled.Text = "未安裝"
            lblJavaInstalled.ForeColor = Color.Red
        End If
        If memStat Then
            lblRamDone.Text = "已準備"
            lblRamDone.ForeColor = Color.Green
        Else
            lblRamDone.Text = "未準備"
            lblRamDone.ForeColor = Color.Red
        End If
        If netStat Then
            lblNetDone.Text = "已準備"
            lblNetDone.ForeColor = Color.Green
        Else
            lblNetDone.Text = "未準備"
            lblNetDone.ForeColor = Color.Red
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillVersionComboBox()
        txtInstallPath.Text = $"{getPath()}\server"

        Try
            ' 目錄路徑
            Dim directoryPath As String = Directory.GetCurrentDirectory() + "\server"
            Dim jarFiles() As String = Nothing
            ' 確認目錄是否存在
            If Not Directory.Exists(directoryPath) Then
                ' 如果目錄不存在，創建目錄
                Directory.CreateDirectory(directoryPath)
            End If

            ' 取得當前目錄下所有 JAR 檔案
            jarFiles = Directory.GetFiles(directoryPath, "*.jar")

            If jarFiles IsNot Nothing Then
                frmLoader.Show()
                Close()
            End If
        Catch f As DirectoryNotFoundException
            MsgBox("找不到可用路徑！請檢查是否創建 Servers 路徑於此軟體目錄下，然後使用按鈕重試！", vbCritical)
        End Try

        Dim javaStat = chkJava()
        Dim memStat = chkMemory()
        Dim netStat = chkNet()

        If javaStat Then
            lblJavaInstalled.Text = "已安裝"
            lblJavaInstalled.ForeColor = Green
        Else
            lblJavaInstalled.Text = "未安裝"
            lblJavaInstalled.ForeColor = Red
        End If
        If memStat Then
            lblRamDone.Text = "已準備"
            lblRamDone.ForeColor = Green
        Else
            lblRamDone.Text = "未準備"
            lblRamDone.ForeColor = Red
        End If
        If netStat Then
            lblNetDone.Text = "已準備"
            lblNetDone.ForeColor = Green
        Else
            lblNetDone.Text = "未準備"
            lblNetDone.ForeColor = Red
        End If
    End Sub

    ' 函數：使用 GetAllVersions 取得所有版本，並將它們填充到 cmbVersionSelector 中
    Private Sub FillVersionComboBox()
        ' 使用 MinecraftHelper 中的 GetAllVersions 函數
        Dim allVersions As String = GetAllVersions()

        ' 將版本以換行符號分隔
        Dim versionArray As String() = allVersions.Split({Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)

        ' 將版本加入到 ComboBox 中
        For Each version As String In versionArray
            cmbVersionSelector.Items.Add(version)
        Next
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Shell("Rundll32.exe url.dll, FileProtocolHandler https://www.minecraft.net/en-us/eula", vbNormalFocus)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        fbdInstallPath.ShowDialog()
        txtInstallPath.Text = fbdInstallPath.SelectedPath
    End Sub

    Private Sub btnDownload_Click(sender As Object, e As EventArgs) Handles btnDownload.Click
        btnDownload.Enabled = False
        btnDownload.Text = "下載中...(&D)"
        If cmbVersionSelector.Text = "" Then
            MsgBox("請選擇需要的Minecraft伺服器版本，然後重試！", vbCritical)
        ElseIf CheckBox1.Checked Then
            Dim log As String = DownloadServer(cmbVersionSelector.Text)
            Dim stat As String = "下載成功！"
            Dim msgIcon = vbInformation
            If log.Contains("Error") Then stat = "下載失敗！" : msgIcon = vbCritical
            MsgBox($"{stat}以下為傳回Log內容：{vbCrLf}{log}", msgIcon)
        Else
            MsgBox("請同意Minecraft官方的EULA，然後重試！", vbCritical)
        End If
        btnDownload.Enabled = True
        btnDownload.Text = "下載(&D)"
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        frmLoader.Show()
        Me.Close()
    End Sub
End Class

Imports System.IO
Imports Microsoft.VisualBasic.Devices

Public Class frmLoader
    Private Sub scanJar()
        Dim jarFiles() As String = Nothing

        Try
            ' 目錄路徑
            Dim directoryPath As String = Directory.GetCurrentDirectory() + "\server"

            ' 確認目錄是否存在
            If Not Directory.Exists(directoryPath) Then
                ' 如果目錄不存在，創建目錄
                Directory.CreateDirectory(directoryPath)
            End If

            ' 取得當前目錄下所有 JAR 檔案
            jarFiles = Directory.GetFiles(directoryPath, "*.jar")
        Catch e As DirectoryNotFoundException
            MsgBox("找不到可用路徑！請檢查是否創建 Servers 路徑於此軟體目錄下，然後使用按鈕重試！", vbCritical)
        Finally
            ' 清空 lstVersions
            lstVersions.Items.Clear()
        End Try

        If jarFiles IsNot Nothing Then
            ' 將完整檔案名輸出到 lstVersions
            For Each jarFile As String In jarFiles
                Dim fileName As String = Path.GetFileName(jarFile)
                lstVersions.Items.Add(fileName)
            Next
        End If
        lstVersions.SelectedIndex = 0
    End Sub


    Private Sub btnReload_Click(sender As Object, e As EventArgs) Handles btnReload.Click
        scanJar()
    End Sub

    Private Sub frmLoader_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        scanJar()
        ' 獲取系統物理記憶體大小
        ' 獲取系統物理記憶體大小
        Dim totalPhysicalMemory = My.Computer.Info.TotalPhysicalMemory
        ' 將位元組轉換為 GB
        totalPhysicalMemory = totalPhysicalMemory / (1024 ^ 2)
        ' 設定 tkbRamMax 的 Maximum
        tkbRamMax.Maximum = totalPhysicalMemory
        tkbRamMax.Value = totalPhysicalMemory / 4
        lblRamMax.Text = Str(totalPhysicalMemory / 4)
        tkbRamLow.Maximum = totalPhysicalMemory
        tkbRamLow.Value = totalPhysicalMemory / 2
        lblRamMin.Text = Str(totalPhysicalMemory / 2)
    End Sub

    Private Sub lstVersions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstVersions.SelectedIndexChanged
        lblName.Text = "檔案名稱：" + lstVersions.Text
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Shell("Rundll32.exe url.dll, FileProtocolHandler https://www.minecraft.net/en-us/eula", vbNormalFocus)
    End Sub

    Private Sub chkChangeRamLimit_CheckedChanged(sender As Object, e As EventArgs) Handles chkChangeRamLimit.CheckedChanged
        tkbRamLow.Enabled = chkChangeRamLimit.Checked
        tkbRamMax.Enabled = chkChangeRamLimit.Checked
    End Sub

    Private Sub tkbRamLow_Scroll(sender As Object, e As EventArgs) Handles tkbRamLow.Scroll
        lblRamMin.Text = tkbRamLow.Value.ToString
        lblRamMax.Text = tkbRamMax.Value.ToString
    End Sub

    Private Sub tkbRamMax_Scroll(sender As Object, e As EventArgs) Handles tkbRamMax.Scroll
        lblRamMin.Text = tkbRamLow.Value.ToString
        lblRamMax.Text = tkbRamMax.Value.ToString
    End Sub

    Sub eulaEnable()
        ' eula.txt 的完整路徑
        Dim eulaFilePath As String = Path.Combine(Directory.GetCurrentDirectory(), "server", "eula.txt")

        ' 要寫入的內容
        Dim eulaContent As String = "#By changing the setting below to TRUE you are indicating your agreement to our EULA (https://account.mojang.com/documents/minecraft_eula)." & vbCrLf & "eula=true"

        Try
            ' 如果舊的 eula.txt 存在，則先刪除
            If File.Exists(eulaFilePath) Then
                File.Delete(eulaFilePath)
            End If

            ' 寫入內容到 eula.txt 檔案
            File.WriteAllText(eulaFilePath, eulaContent)

            ' 處理成功的程式碼，例如通知用戶啟用成功等
            MessageBox.Show("EULA 已成功啟用！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            ' 處理錯誤的程式碼，例如通知用戶發生錯誤等
            MessageBox.Show($"錯誤：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' 啟動伺服器按鈕的點擊事件處理程序
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If chkAgreeEula.Checked Then
            eulaEnable()
        End If

        Dim selectedFileName As String = ""
        Try
            If lstVersions.SelectedItem Is Nothing Then
                MsgBox("請選擇版本，然後重新嘗試啟動！", vbExclamation)
                Return
            End If
            ' 獲取選擇的伺服器檔案名
            selectedFileName = lstVersions.SelectedItem.ToString
        Catch f As NullReferenceException
            MsgBox("請選擇版本，然後重新嘗試啟動！", vbExclamation)
            Return
        End Try

        ' 構建伺服器檔案的完整路徑
        Dim serverFilePath = Path.Combine(Directory.GetCurrentDirectory, "server", selectedFileName)

        ' 創建 Process 物件
        Dim serverProcess As New Process

        ' 設定 ProcessStartInfo 屬性
        Dim startInfo As New ProcessStartInfo With {
            .FileName = "java.exe", ' 伺服器啟動所需的 Java 執行檔
            .Arguments = $"-jar ""{serverFilePath}""", ' 伺服器檔案的完整路徑作為啟動參數
            .RedirectStandardOutput = True,
            .WorkingDirectory = Path.Combine(Directory.GetCurrentDirectory, "server") ' 設定工作目錄
        }

        Dim arg As String = getArg()
        startInfo.Arguments += $" {arg}"
        Console.WriteLine(startInfo.Arguments)
        serverProcess.StartInfo = startInfo

        ' 啟動伺服器
        serverProcess.Start()

        ' 隱藏主視窗
        Hide()

        ' 等待伺服器終止
        serverProcess.WaitForExit()

        Dim log As String = "找不到記錄檔"
        If serverProcess.HasExited Then
            log = serverProcess.StandardOutput.ReadToEnd()
        End If
        ' 重新顯示主視窗
        Show()

        ' 處理紀錄，這裡可以根據需要自行實現
        frmLog.Text = $"執行實例：java.exe -jar ""{serverFilePath}"" {arg}"
        If Not chkDisableLog.Checked Then
            logProcess(log)
        End If
    End Sub

    ' 處理紀錄的方法，根據需要自行實現
    Private Sub logProcess(logContent As String)
        ' 處理紀錄的程式碼
        frmLog.txtLogCont.Text = logContent
        frmLog.ShowDialog()
    End Sub

    Function getArg()
        Dim launchArg As String = ""

        ' 是否要隱藏 GUI
        If chkDisableGui.Checked Then
            launchArg += " -nogui"
        End If

        ' 最小記憶體使用量
        Dim minRam As String = lblRamMin.Text.Trim()
        If Not String.IsNullOrEmpty(minRam) And chkChangeRamLimit.Checked Then
            launchArg += $" -Xms{minRam}M"
        End If

        ' 最大記憶體使用量
        Dim maxRam As String = lblRamMax.Text.Trim()
        If Not String.IsNullOrEmpty(maxRam) And chkChangeRamLimit.Checked Then
            launchArg += $" -Xmx{maxRam}M"
        End If

        ' 自訂其他啟動參數
        Dim customArgs As String = txtProp.Text.Trim()
        If Not String.IsNullOrEmpty(customArgs) Then
            launchArg += $" {customArgs}"
        End If
        Return launchArg
    End Function
End Class
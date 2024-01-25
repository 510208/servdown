Imports System.IO

Module check_enviroment
    Function chkJava() As Boolean
        ' Dim openFolder As New FolderBrowserDialog()

        ' 顯示對話框
        ' Dim result As DialogResult = openFolder.ShowDialog()

        ' 檢查使用者是否按下了 "確定" 按鈕
        Dim javaPath As Boolean = GetJavaPath()

        ' 檢查 java.exe 是否存在
        If javaPath Then
            Return True
        Else
            Return False
        End If
        ' 使用者取消了選擇資料夾
        Return False
    End Function

    Function GetJavaPath() As String
        Dim paths As String() = Environment.GetEnvironmentVariable("PATH").Split(Path.PathSeparator)

        For Each path In paths
            Dim javaExePath As String = path + "\java.exe"

            If path.Contains("java") AndAlso File.Exists(javaExePath) Then
                ' 找到包含 "java" 且有 java.exe 的路徑
                Return True
            End If
        Next

        Return False
    End Function

    ' 檢查空閒記憶體是否超過3GB
    Function chkMemory() As Boolean
        Dim freeMemory As Double = My.Computer.Info.AvailablePhysicalMemory / 1024 / 1024 / 1024 ' 轉換為GB
        Return freeMemory > 3
    End Function

    ' 檢查網際網路連線是否正常
    Function chkNet() As Boolean
        Return My.Computer.Network.IsAvailable
    End Function
End Module
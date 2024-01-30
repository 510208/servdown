Imports System.IO

Module propEditor
    Function EditProp(key As String, value As String, path As String) As String
        If Not File.Exists(path) Then
            MsgBox("文件不存在！請檢察路徑後重試", vbCritical)
            Return "文件不存在"
        End If

        Try
            Dim lines As List(Of String) = File.ReadAllLines(path).ToList()

            ' 尋找並修改 key 對應的 value
            Dim found As Boolean = False
            For i As Integer = 0 To lines.Count - 1
                Dim parts As String() = lines(i).Split("=")
                If parts.Length = 2 AndAlso parts(0).Trim() = key Then
                    lines(i) = $"{key}={value}"
                    found = True
                    Exit For
                End If
            Next

            If Not found Then
                MsgBox("找不到指定的Key：" + key, vbCritical)
                Return "找不到指定的 key"
            End If

            ' 寫回文件
            File.WriteAllLines(path, lines)

            Return value
        Catch ex As Exception
            Return $"{ex.Message}"
        End Try
    End Function

    Function ReadProp(key As String, path As String) As String
        If Not File.Exists(path) Then
            MsgBox("文件不存在！請檢察路徑後重試", vbCritical)
            Return "文件不存在"
        End If

        Try
            Dim lines As String() = File.ReadAllLines(path)

            ' 尋找 key 對應的 value
            For Each line As String In lines
                Dim parts As String() = line.Split("=")
                If parts.Length = 2 AndAlso parts(0).Trim() = key Then
                    Return parts(1).Trim()
                End If
            Next
            MsgBox("找不到指定的Key：" + key, vbCritical)
            Return "找不到指定的 key"
        Catch ex As Exception
            Return $"{ex.Message}"
        End Try
    End Function
End Module

Imports System.Diagnostics

Module MinecraftHelper
    Private pythonScriptPath As String = "get_file.py"

    ' 調用 Python 腳本中的 get_download_link 函數
    Function GetDownloadLink(mcVersion As String) As String
        Dim processStartInfo As New ProcessStartInfo With {
            .FileName = "python",
            .Arguments = $"{pythonScriptPath} --version {mcVersion}",
            .RedirectStandardOutput = True,
            .UseShellExecute = False,
            .CreateNoWindow = True
        }

        Using process As New Process() With {.StartInfo = processStartInfo}
            process.Start()
            Return process.StandardOutput.ReadToEnd()
        End Using
    End Function

    ' 調用 Python 腳本中的 download_server 函數
    Sub DownloadServer(mcVersion As String)
        Dim processStartInfo As New ProcessStartInfo With {
            .FileName = "python",
            .Arguments = $"{pythonScriptPath} --version {mcVersion} -d",
            .RedirectStandardOutput = True,
            .UseShellExecute = False,
            .CreateNoWindow = True
        }

        Using process As New Process() With {.StartInfo = processStartInfo}
            process.Start()
            Console.WriteLine(process.StandardOutput.ReadToEnd())
        End Using
    End Sub

    ' 調用 Python 腳本中的 get_all_versions 函數
    Function GetAllVersions() As String
        Dim processStartInfo As New ProcessStartInfo With {
            .FileName = "python",
            .Arguments = $"{pythonScriptPath} --all_ver",
            .RedirectStandardOutput = True,
            .UseShellExecute = False,
            .CreateNoWindow = True
        }

        Using process As New Process() With {.StartInfo = processStartInfo}
            process.Start()
            Return process.StandardOutput.ReadToEnd()
        End Using
    End Function
End Module

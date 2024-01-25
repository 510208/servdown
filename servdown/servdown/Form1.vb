Imports System.Drawing.Color

Public Class Form1

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
End Class

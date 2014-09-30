Imports System.IO
Imports System.Text
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim computerName As String = My.Computer.Name
            Dim a2 As New Process
            Dim loginfs As FileStream
            Dim info() As Byte
            Dim temp As String = Environment.GetEnvironmentVariable("TEMP")
            Dim drive As String = Environment.GetEnvironmentVariable("SYSTEMDRIVE")
            Dim programfiles As String
            If My.Computer.FileSystem.DirectoryExists(drive & "\Program Files (x86)") Then
                programfiles = drive & "\Program Files (x86)"
            Else
                programfiles = drive & "\Program Files"
            End If
            If My.Computer.FileSystem.DirectoryExists(drive & "\Archivos de programa (x86)") Then
                programfiles = drive & "\Archivos de programa (x86)"
            Else
                programfiles = drive & "\Archivos de programa"
            End If

            loginfs = New FileStream(temp & "\login.sql", FileMode.Create, FileAccess.Write)
            info = New UTF8Encoding(True).GetBytes(My.Resources.login)
            loginfs.Write(info, 0, info.Length)
            loginfs.Close()
            a2.StartInfo.FileName = "cmd"
            a2.StartInfo.Arguments = "/C" & programfiles & "\Microsoft SQL Server\110\Tools\Binn\SQLCMD.EXE/C -E -S " & computerName & "\SQLEXPRESSFORAPP -i %TEMP%\login.sql"
            a2.Start()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        
    End Sub
End Class

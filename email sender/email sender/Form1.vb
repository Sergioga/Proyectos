Imports System.Web
Imports System.IO
Imports System.Net.Mail
Imports System.Data.OleDb

Public Class Form1
    Dim clinicas() As String
    Dim accessCon As New OleDb.OleDbConnection(My.Settings.AccessConnection)
    Dim cmd As New OleDb.OleDbCommand
    Dim datareader As OleDb.OleDbDataReader
    Dim cmdCount As New OleDbCommand("select count(*) from empresa", accessCon)
    Dim empresas As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            accessCon.Open()

            empresas = CInt(cmdCount.ExecuteScalar())

            cmd.Connection = accessCon
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT Empresa FROM empresa"
            datareader = cmd.ExecuteReader

            If datareader.HasRows Then
                For i As Integer = 0 To empresas - 1
                    datareader.Read()
                    ReDim Preserve clinicas(i)
                    clinicas(i) = datareader(0)
                Next
                datareader.Close()
                accessCon.Close()
            End If

            datareader.Close()
            accessCon.Close()
            cmd.ExecuteReader()
        Catch ex As Exception
            send_email()
        End Try


    End Sub
    Private Sub send_email()
        Dim email As New MailMessage
        Dim smtp As New SmtpClient

        If empresas >= 1 Then

            Select Case clinicas.Length - 1
                Case 0
                    email.Body = "Se ha producido un error en la subida de archivos en la clinica " _
                        & clinicas(0) & " con fecha " & Date.Now.ToString
                Case 1
                    email.Body = "Se ha producido un error en la subida de archivos en las clinicas: " _
                        & clinicas(0) & ", " & clinicas(1) & " con fecha " & Date.Now.ToString
                Case 2
                    email.Body = "Se ha producido un error en la subida de archivos en las clinicas: " _
                        & clinicas(0) & ", " & clinicas(1) & ", " & clinicas(2) & " con fecha " & Date.Now.ToString
                Case 3
                    email.Body = "Se ha producido un error en la subida de archivos en las clinicas: " _
                        & clinicas(0) & ", " & clinicas(1) & " , " & clinicas(2) & ", " & clinicas(3) & " con fecha " & Date.Now.ToString
                Case 4
                    email.Body = "Se ha producido un error en la subida de archivos en las clinicas: " _
                        & clinicas(0) & ", " & clinicas(1) & ", " & clinicas(2) & ", " & clinicas(3) & ", " & clinicas(4) & " con fecha " & Date.Now.ToString
                Case 5
                    email.Body = "Se ha producido un error en la subida de archivos en las clinicas: " _
                        & clinicas(0) & ", " & clinicas(1) & ", " & clinicas(2) & ", " & clinicas(3) & ", " & clinicas(4) & ", " & clinicas(5) & " con fecha " & Date.Now.ToString
                Case 6
                    email.Body = "Se ha producido un error en la subida de archivos en las clinicas: " _
                        & clinicas(0) & ", " & clinicas(1) & ", " & clinicas(2) & ", " & clinicas(3) & _
                        ", " & clinicas(4) & ", " & clinicas(5) & ", " & clinicas(6) & " con fecha " & Date.Now.ToString
                Case 7
                    email.Body = "Se ha producido un error en la subida de archivos en las clinicas: " _
                        & clinicas(0) & ", " & clinicas(1) & ", " & clinicas(2) & ", " & clinicas(3) & _
                        ", " & clinicas(4) & ", " & clinicas(5) & ", " & clinicas(6) & ", " & clinicas(7) & " con fecha " & Date.Now.ToString
            End Select
        Else
            email.Body = "No se pudo acceder a la base de datos de Winvet, a fecha " & Date.Now.ToString & "enviado desde " 'String de VetBizz con el nombre de la BBDD'
        End If

        email.From = New MailAddress("visual.pruebas@gmail.com")
        email.Subject = "Error VetBizz"
        email.To.Add("sergiogasan@gmail.com")
        smtp.EnableSsl = True
        smtp.Port = "587"
        smtp.Host = " smtp.gmail.com"
        smtp.Credentials = New Net.NetworkCredential("visual.pruebas@gmail.com", "visual123")
        Try
            smtp.Send(email)
        Catch ex As Exception
        End Try


    End Sub
End Class

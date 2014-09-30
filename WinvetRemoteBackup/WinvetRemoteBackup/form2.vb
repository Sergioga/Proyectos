Imports System.IO
Imports System.Net.Mail
Imports System.Threading
Imports System.IO.Packaging
Public Class form2
    Private ruta As String = " "
    Private user As String = " "
    Private server As String = " "
    Private pass As String = " "
    Private jro As New JRO.JetEngine
    Private appPath As String = My.Application.Info.DirectoryPath

    Private Sub form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Dim remoteAccessConn As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & appPath & "\WinvetRemote.mdb")
            Dim cmd As New OleDb.OleDbCommand
            Dim datareader As OleDb.OleDbDataReader
            cmd.Connection = remoteAccessConn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT server, [user], pass, ruta FROM info WHERE(ID = 0)"
            remoteAccessConn.Open()
            If remoteAccessConn.State = ConnectionState.Open Then
                datareader = cmd.ExecuteReader
                If datareader.HasRows Then
                    datareader.Read()
                    server = datareader("server").ToString
                    ruta = datareader("ruta").ToString
                    pass = datareader("pass").ToString
                    user = datareader("user").ToString
                    serverTxt.Text = server
                    rutaWinvetBD.Text = ruta
                    passTxt.Text = pass
                    userTxt.Text = user

                End If
                If serverTxt.Text <> Nothing Then
                    ok2.Visible = True
                End If

                If rutaWinvetBD.Text <> Nothing Then
                    ok1.Visible = True
                End If

                If passTxt.Text <> Nothing Then
                    ok4.Visible = True
                End If

                If userTxt.Text <> Nothing Then
                    ok3.Visible = True
                End If
                If server = Nothing Or ruta = Nothing Or pass = Nothing Or user = Nothing Then
                    datareader.Close()
                    remoteAccessConn.Close()
                    MsgBox("Faltan datos de configuración, por favor ejecuta el programa e introduce los datos correctos", MsgBoxStyle.Exclamation, "Datos incorrectos")
                Else
                    datareader.Close()
                    remoteAccessConn.Close()
                    If My.Computer.FileSystem.FileExists(appPath & "\winvet_" & Date.Today.ToShortDateString.Replace("/", "-") & ".mdb") = True Then
                        My.Computer.FileSystem.DeleteFile(appPath & "\winvet_" & Date.Today.ToShortDateString.Replace("/", "-") & ".mdb")
                    End If
                    If My.Computer.FileSystem.FileExists(appPath & "\winvetCompactada_" & Date.Today.ToShortDateString.Replace("/", "-") & ".mdb") = True Then
                        My.Computer.FileSystem.DeleteFile(appPath & "\winvetCompactada_" & Date.Today.ToShortDateString.Replace("/", "-") & ".mdb")
                    End If
                    Timer3.Interval = 1000
                    Label5.Visible = False
                    ProgressBar1.Visible = False
                    Label7.Visible = False
                    Label8.Visible = False
                    Label6.Visible = True
                    Timer3.Enabled = True
                End If
            End If
        Catch ex As Exception
            send_email(ex.ToString)
        End Try
    End Sub

    Private Sub salirBtn_Click(sender As Object, e As EventArgs) Handles salirBtn.Click
        Me.Close()
    End Sub

    Private Sub confBtn_Click(sender As Object, e As EventArgs) Handles confBtn.Click
        configForm.Show()
        Me.Close()
    End Sub

    Private Sub UploadFile(ByVal _FileName As String, ByVal _UploadPath As String, ByVal _FTPUser As String, ByVal _FTPPass As String)
        Dim valorBarra As Integer = 0
        Dim _FileInfo As New System.IO.FileInfo(_FileName)

        ' Creacion de la URI de subida
        Dim _FtpWebRequest As System.Net.FtpWebRequest = CType(System.Net.FtpWebRequest.Create(New Uri(_UploadPath)), System.Net.FtpWebRequest)

        _FtpWebRequest.UsePassive = True
        ' Las credenciales para la subida
        _FtpWebRequest.Credentials = New System.Net.NetworkCredential(_FTPUser, _FTPPass)

        ' El KeepAlive de la conexión
        _FtpWebRequest.KeepAlive = False

        ' 20 segundo de tiempo de espera antes de cerrar la conexión
        _FtpWebRequest.Timeout = 20000

        ' El comando a ejecutar
        _FtpWebRequest.Method = System.Net.WebRequestMethods.Ftp.UploadFile

        ' Modo de transferencia, binario por supuesto.
        _FtpWebRequest.UseBinary = True

        ' Para que el servidor conozca la longitud del archivo
        _FtpWebRequest.ContentLength = _FileInfo.Length
        Dim maximo As Integer = _FileInfo.Length / 16384 + 1
        ProgressBar1.Maximum = maximo

        ' El tamaño del buffer, 16kb, para ir sobre seguro.
        Dim buffLength As Integer = 16384
        Dim buff(buffLength - 1) As Byte

        ' Abrimos un FileStream para el archivo
        Dim _FileStream As System.IO.FileStream = _FileInfo.OpenRead()
        
        Try

            Dim _Stream As System.IO.Stream = _FtpWebRequest.GetRequestStream()

            ' Leemos del stream a 16kb por segundo.
            Dim contentLen As Integer = _FileStream.Read(buff, 0, buffLength)

            Do While contentLen <> 0
                valorBarra += 1
                ProgressBar1.Value = valorBarra
                ' Guardar los datos en el servidor
                _Stream.Write(buff, 0, contentLen)
                contentLen = _FileStream.Read(buff, 0, buffLength)
            Loop
            ProgressBar1.Value = maximo
            ' cerrar el fileStream y el stream.
            _Stream.Close()
            _Stream.Dispose()
            _FileStream.Close()
            _FileStream.Dispose()
        Catch ex As Exception
            send_email(ex.ToString)
        End Try
    End Sub

    Private Sub send_email(ByVal excep As String)
        Dim email As New MailMessage
        Dim smtp As New SmtpClient
        email.Body = "No se ha podido subir la base de datos de ""El Bosque"" al otro servidor a fecha " & Date.Now.ToString & "Error: " & excep
        email.From = New MailAddress("visual.pruebas@gmail.com")
        email.Subject = "Error subida de datos de El Bosque"
        email.To.Add("hugo@qcompusoft.com")
        smtp.EnableSsl = True
        smtp.Port = "587"
        smtp.Host = " smtp.gmail.com"
        smtp.Credentials = New Net.NetworkCredential("visual.pruebas@gmail.com", "visual123")
        Try
            smtp.Send(email)
        Catch ex As Exception
            Dim exceps As String = ex.ToString
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        
        UploadFile(appPath & "\winvet_" & Date.Today.ToShortDateString.Replace("/", "-") & ".zip", _
        "ftp://" & server & "/winvet_" & Date.Today.ToShortDateString.Replace("/", "-") & ".zip", _
         user, _
        pass)
        If My.Computer.FileSystem.FileExists(appPath & "\winvet_" & Date.Today.ToShortDateString.Replace("/", "-") & ".mdb") = True Then
            My.Computer.FileSystem.DeleteFile(appPath & "\winvet_" & Date.Today.ToShortDateString.Replace("/", "-") & ".mdb")
        End If
        If My.Computer.FileSystem.FileExists(appPath & "\winvetCompactada_" & Date.Today.ToShortDateString.Replace("/", "-") & ".mdb") = True Then
            My.Computer.FileSystem.DeleteFile(appPath & "\winvetCompactada_" & Date.Today.ToShortDateString.Replace("/", "-") & ".mdb")
        End If
        If My.Computer.FileSystem.FileExists(appPath & "\winvet_" & Date.Today.ToShortDateString.Replace("/", "-") & ".zip") Then
            My.Computer.FileSystem.DeleteFile(appPath & "\winvet_" & Date.Today.ToShortDateString.Replace("/", "-") & ".zip")
        End If
        Timer1.Stop()
        Timer2.Interval = 3000
        Timer2.Enabled = True
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer2.Stop()
        Me.Close()
    End Sub

    Private Sub ZipFiles()
        If My.Computer.FileSystem.FileExists(appPath & "\winvet_" & Date.Today.ToShortDateString.Replace("/", "-") & ".zip") Then
            My.Computer.FileSystem.DeleteFile(appPath & "\winvet_" & Date.Today.ToShortDateString.Replace("/", "-") & ".zip")
        End If
        Dim zipPath As String = appPath & "\winvet_" & Date.Today.ToShortDateString.Replace("/", "-") & ".zip"

        'Open the zip file if it exists, else create a new one 
        Dim zip As Package = ZipPackage.Open(zipPath, _
             IO.FileMode.OpenOrCreate, IO.FileAccess.ReadWrite)

        'Add as many files as you like:
        AddToArchive(zip, appPath & "\winvetCompactada_" & Date.Today.ToShortDateString.Replace("/", "-") & ".mdb")
        zip.Close() 'Close the zip file
        Timer1.Interval = 1000
        Label5.Visible = True
        ProgressBar1.Visible = True
        Label7.Visible = False
        Label8.Visible = False
        Label6.Visible = False
        Timer1.Enabled = True
        
    End Sub

    Private Sub AddToArchive(ByVal zip As Package, _
                         ByVal fileToAdd As String)

        'Replace spaces with an underscore (_) 
        Dim uriFileName As String = fileToAdd.Replace(" ", "_")

        'A Uri always starts with a forward slash "/" 
        Dim zipUri As String = String.Concat("/", _
                   IO.Path.GetFileName(uriFileName))

        Dim partUri As New Uri(zipUri, UriKind.Relative)
        Dim contentType As String = _
                   Net.Mime.MediaTypeNames.Application.Zip

        'The PackagePart contains the information: 
        ' Where to extract the file when it's extracted (partUri) 
        ' The type of content stream (MIME type):  (contentType) 
        ' The type of compression:  (CompressionOption.Normal)   
        Dim pkgPart As PackagePart = zip.CreatePart(partUri, _
                   contentType, CompressionOption.Normal)

        'Read all of the bytes from the file to add to the zip file 
        Dim bites As Byte() = File.ReadAllBytes(fileToAdd)

        'Compress and write the bytes to the zip file 
        pkgPart.GetStream().Write(bites, 0, bites.Length)

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Timer3.Stop()
        My.Computer.FileSystem.CopyFile(ruta, appPath & "\winvet_" & Date.Today.ToShortDateString.Replace("/", "-") & ".mdb", True)
        Timer4.Interval = 1000
        Label5.Visible = False
        ProgressBar1.Visible = False
        Label7.Visible = True
        Label8.Visible = False
        Label6.Visible = False
        Timer4.Enabled = True
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Timer4.Stop()
        jro.CompactDatabase("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & appPath & "\winvet_" & Date.Today.ToShortDateString.Replace("/", "-") & ".mdb;Jet OLEDB:Database Password=14DaNiTe0996;", _
                   "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & appPath & "\winvetCompactada_" & Date.Today.ToShortDateString.Replace("/", "-") & _
                   ".mdb;Jet OLEDB:Engine Type=5;Jet OLEDB:Database Password=14DaNiTe0996;")
        Timer5.Interval = 1000
        Label5.Visible = False
        ProgressBar1.Visible = False
        Label7.Visible = False
        Label8.Visible = True
        Label6.Visible = False
        Timer5.Enabled = True
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        Timer5.Stop()
        ZipFiles()
    End Sub
End Class
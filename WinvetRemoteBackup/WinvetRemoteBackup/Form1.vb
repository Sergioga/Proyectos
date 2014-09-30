Public Class configForm
    ' Variables para grabar en la BBDD.
    Private ruta As String = " "
    Private user As String
    Private pass As String
    Private server As String
    Private accessCon As New OleDb.OleDbConnection
    Private cmd As New OleDb.OleDbCommand
    Private datareader As OleDb.OleDbDataReader
    Private appPath As String = My.Application.Info.DirectoryPath

    Private Sub examinarBtn_Click(sender As Object, e As EventArgs) Handles examinarBtn.Click
        Try
            ' Dialogo para seleccionar la BBDD de Winvet.
            OpenFileDialog1.Title = "Selecciona la base de datos de Winvet"
            OpenFileDialog1.Filter = "Base de datos de MS Access | *.mdb"
            OpenFileDialog1.FilterIndex = 1
            OpenFileDialog1.FileName = Nothing
            If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                rutaWinvetBD.Text = OpenFileDialog1.FileName()
                ruta = OpenFileDialog1.FileName()
            End If
            accessCon.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & ruta & ";Jet OLEDB:Database Password=14DaNiTe0996;Persist Security Info=True;"
            ' Comprobar si la BBDD se llama Winvet y, si es asi, probar la conexión
            ' seleccionando todo lo de la tabla empresa.
            If ruta.ToUpper.Contains("WINVET") Then
                cmd.Connection = accessCon
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "SELECT * FROM Empresa"
                accessCon.Open()
                If accessCon.State = ConnectionState.Open Then
                    datareader = cmd.ExecuteReader
                    ' Si la tabla empresa tiene algun dato (deberia tener) la BBDD esta OK.
                    If datareader.HasRows Then
                        connEstatus.Visible = True
                    Else
                        connEstatus.ForeColor = Color.White
                        connEstatus.BackColor = Color.Red
                        connEstatus.Text = "Conexión incorrecta"
                        connEstatus.Visible = True
                    End If
                    datareader.Close()
                    accessCon.Close()
                End If
                'accessCon.Close()
            Else
                MsgBox("Por favor, selecciona la base de datos de Winvet (winvet.mdb)", MsgBoxStyle.Exclamation, "Base de datos incorrecta")
            End If
        Catch ex As Exception
            Dim excep As String = ex.ToString
            ' MsgBox(excep)
            connEstatus.ForeColor = Color.White
            connEstatus.BackColor = Color.Red
            connEstatus.Text = "Conexión incorrecta"
            connEstatus.Visible = True
            accessCon.Close()
        End Try
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        ' Guardar los datos de los campos en las variables correspondientes
        ' si los campos no estan vacíos.
        Try
            If userTxt.Text = Nothing Or passTxt.Text = Nothing Or serverTxt.Text = Nothing Then
                MsgBox("Debes rellenar todos los campos", MsgBoxStyle.Exclamation, "Campos vacios")
            ElseIf ruta = Nothing Or Not ruta.ToUpper.Contains("WINVET") Then
                MsgBox("Debes escoger la base de datos de Winvet", MsgBoxStyle.Exclamation, "Selecciona la base de datos")
            Else
                user = userTxt.Text
                pass = passTxt.Text
                server = serverTxt.Text
                Dim winRemoteAccessCon As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=.\WinvetRemote.mdb")
                Dim cmd As New OleDb.OleDbCommand
                winRemoteAccessCon.Open()
                If winRemoteAccessCon.State = ConnectionState.Open Then
                    cmd.Connection = winRemoteAccessCon
                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = "UPDATE info SET server = '" & server & "', [user] = '" & user & "', pass = '" & pass & "', ruta ='" & ruta & "' WHERE (ID = 0)"
                    If cmd.ExecuteNonQuery() = 1 Then
                        MsgBox("Datos guardados correctamente", MsgBoxStyle.Information, "Datos grabados")
                        ok1.Visible = True
                        ok2.Visible = True
                        ok3.Visible = True
                        ok4.Visible = True
                    Else
                        MsgBox("Ha habido un problema a la hora de guardar la configuración", MsgBoxStyle.Exclamation, "Error")
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Ha habido un problema a la hora de guardar la configuración", MsgBoxStyle.Exclamation, "Error")
            MsgBox(ex.ToString)
        End Try

    End Sub
    
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim ruta As String
        Dim user As String
        Dim server As String
        Dim pass As String
        Try
            Dim remoteAccessConn As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=.\WinvetRemote.mdb")
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
                    If server = Nothing Or ruta = Nothing Or pass = Nothing Or user = Nothing Then
                        datareader.Close()
                        remoteAccessConn.Close()
                        MsgBox("Faltan datos de configuración, por favor ejecuta el programa e introduce los datos correctos", MsgBoxStyle.Exclamation, "Datos incorrectos")
                    Else
                        form2.Show()
                        Me.Close()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub configForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Intentamos cargar los datos de WinvetRemote y comprobar que no esten vacios.
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
                    serverTxt.Text = datareader("server").ToString
                    rutaWinvetBD.Text = datareader("ruta").ToString
                    ruta = rutaWinvetBD.Text
                    passTxt.Text = datareader("pass").ToString
                    userTxt.Text = datareader("user").ToString
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

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
End Class

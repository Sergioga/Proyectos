Imports System.IO
Imports System.Data.SqlClient
Imports System.Text

Module fun
    Public conn As New SqlClient.SqlConnection("Data Source=MEPHIST-PC\SQLEXPRESS;Initial Catalog=db1SQL;Integrated Security=True")
    Public sqlconn As New SqlClient.SqlConnection
    Public info As Byte()
    Public cmd As New SqlClient.SqlCommand
    Public datareader As SqlClient.SqlDataReader
    Public lvl As String
    Public loginName As String
    Public userName As String = "W"
    Public surname As String = "W"
    Public password As String
    Public userID As Integer
    Public profileArray(10) As String
    Public questionID As String
    Public path As String
    Public temp As String = Environment.GetEnvironmentVariable("TEMP")
    Public instanceName As String
    Public database As String
    Public dbUser As String
    Public dbPass As String
    Public computerName As String
    'Public thread1 As New System.Threading.Thread(AddressOf get_profile_ModProfile)
    Public Sub disconnect()
        conn.Close()
        loginForm.Show()
    End Sub
    Public Sub connect()
        Try
            conn.Open()
            'MsgBox("Connection Sucessful")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub chk_conn_str()
        If File.Exists(".\config.ini") = True Then
            Dim dbNameLines() As String = File.ReadAllLines(".\config.ini")
            Dim lineInstance As Integer
            Dim lineDB As Integer
            Dim lineUser As Integer
            Dim linePass As Integer
            Dim lineComputer As Integer
            Dim userTrue As Boolean = False
            Dim passTrue As Boolean = False
            Dim instanceTrue As Boolean = False
            Dim dbTrue As Boolean = False
            Dim computerTrue As Boolean = False
            For i As Integer = 0 To dbNameLines.Length - 1
                If dbNameLines(i).Contains("DataBase_Instance=") = True Then
                    lineInstance = i
                    instanceTrue = True
                ElseIf dbNameLines(i).Contains("DataBase_Name=") = True Then
                    lineDB = i
                    dbTrue = True
                ElseIf dbNameLines(i).Contains("DataBase_User=") = True Then
                    lineUser = i
                    userTrue = True
                ElseIf dbNameLines(i).Contains("DataBase_Password=") = True Then
                    linePass = i
                    passTrue = True
                ElseIf dbNameLines(i).Contains("Computer_Name=") = True Then
                    lineComputer = i
                    computerTrue = True
                End If
            Next
            If instanceTrue = True And dbTrue = True And userTrue = True And passTrue = True And computerTrue = True Then
                instanceName = dbNameLines(lineInstance).Substring(18)
                database = dbNameLines(lineDB).Substring(14)
                dbUser = dbNameLines(lineUser).Substring(14)
                dbPass = dbNameLines(linePass).Substring(18)
                computerName = dbNameLines(lineComputer).Substring(14)
                sqlconn.ConnectionString = "Data Source=" & computerName & "\" & instanceName & ";Initial Catalog=" & database & ";User ID=" & dbUser & ";Password=" & dbPass
            ElseIf computerTrue = True And dbTrue = True Then
                computerName = dbNameLines(lineComputer).Substring(14)
                database = dbNameLines(lineDB).Substring(14)
                sqlconn.ConnectionString = "Data Source=" & computerName & "\SQLEXPRESSFORAPP;Initial Catalog=" & database & ";User ID=sa;Password=Qwerty123"
            End If
        Else
            MsgBox("You need to configure your database server")
            database_settings.Show()
            loginForm.Close()
        End If
    End Sub
    Public Sub chk_login_chg(ByRef login As String)
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT userName, surname FROM login WHERE (loginName= '" & login.ToUpper & "') AND (passwd= '***change***')"
        Try
            datareader = cmd.ExecuteReader()
            datareader.Read()
            If datareader.HasRows Then
                userName = datareader(0).ToString
                surname = datareader(1).ToString
                datareader.Close()
                loginName = login.ToUpper
                MsgBox(My.Resources.strings_en.chgPassStr, MsgBoxStyle.Information, My.Resources.strings_en.chgPass)
                password_change.Show()
                loginForm.Close()
            End If
            datareader.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Public Sub loginfunc(ByRef login As String, ByRef pass As String)
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT userName, surname FROM login WHERE (loginName= '" & login.ToUpper & "') AND (passwd= '" & pass & "')"

        Try
            datareader = cmd.ExecuteReader()
            datareader.Read()
            If datareader.HasRows Then
                userName = datareader(0).ToString
                surname = datareader(1).ToString
                datareader.Close()
                loginForm.lblLogin.Visible = False
                loginName = login.ToUpper
                password = pass
                afterLogin.Show()
                loginForm.Close()
            Else
                loginForm.lblLogin.Visible = True
                loginForm.lblLogin.Text = My.Resources.strings_en.wrgPass
                loginForm.lblLogin.TextAlign = ContentAlignment.MiddleCenter
                loginForm.lblLogin.ForeColor = Color.Red
                loginForm.txtPass.Text = ""
                datareader.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub
    Public Sub getlevel()
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT lvl FROM login WHERE (loginName='" + loginName + "') AND (passwd='" + password + "')"
        Try
            datareader = cmd.ExecuteReader()
            datareader.Read()
            If datareader.HasRows Then
                lvl = datareader(0).ToString
                datareader.Close()
                'Else
                '   lvl = 5
                '    datareader.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Public Sub chg_passwd(ByRef newPass As String)
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "UPDATE login SET passwd='" + newPass + "' WHERE (loginName='" + loginName + "') AND (passwd='" + password_change.txtCurrent.Text + "')"
        If newPass.Length >= 8 And newPass.Length <= 32 Then
            Try
                datareader = cmd.ExecuteReader()
                datareader.Read()
                If datareader.RecordsAffected = 1 Then
                    MsgBox(My.Resources.strings_en.passSuccStr)
                    datareader.Close()
                    If password_change.userChgPass = True Then
                        conn.Close()
                        loginForm.lblLogin.Visible = False
                        loginForm.Show()
                        password_change.Close()
                    Else
                        password_change.Close()
                        conn.Close()
                        loginForm.lblLogin.Visible = False
                        loginForm.Show()
                        afterLogin.Close()
                    End If
                End If
                datareader.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            password_change.txtCurrent.Text = ""
            password_change.txtNew.Text = ""
            password_change.txtNewRe.Text = ""
            MsgBox(My.Resources.strings_en.passLenghStr)
        End If
    End Sub
    Public Sub chk_passwd()
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT userName FROM login WHERE (passwd='" + password_change.txtCurrent.Text + "') AND (loginName='" + loginName + "')"
        Try
            datareader = cmd.ExecuteReader()
            datareader.Read()
            If datareader.HasRows Then
                datareader.Close()
                Return
            Else
                MsgBox(My.Resources.strings_en.wrgPassStr)
                password_change.txtCurrent.Text = ""
                password_change.txtNew.Text = ""
                password_change.txtNewRe.Text = ""
                datareader.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Public Sub get_profile_Profile()
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT userProfiles.* FROM (login INNER JOIN userProfiles ON login.userId = userProfiles.userId) WHERE (login.userId =" + userID.ToString + ")"
        Try
            datareader = cmd.ExecuteReader()
            datareader.Read()
            If datareader.HasRows Then
                For f As Integer = 0 To 10
                    ProForm.Controls.Find("lblPro" + CStr(f), True)(0).Text = datareader(f).ToString
                Next
                ProForm.Controls.Find("lblPro" + CStr(8), True)(0).Text = datareader(8).ToString.TrimEnd("0", "00", ":")
                ProForm.Controls.Find("lblPro" + CStr(10), True)(0).Text = datareader(10).ToString.TrimEnd("0", "00", ":")
                questionID = datareader(6)
                datareader.Close()
            End If
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT question FROM secretQ WHERE questionID=" + questionID.ToString
            datareader = cmd.ExecuteReader()
            datareader.Read()
            ProForm.lblPro6.Text = datareader(0)
            datareader.Close()

            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT userName, surname FROM login WHERE userId=" + userID.ToString
            datareader = cmd.ExecuteReader()
            datareader.Read()
            userName = datareader(0)
            surname = datareader(1)
            datareader.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Public Sub get_profile_ModProfile()
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT userProfiles.* FROM (login INNER JOIN userProfiles ON login.userId = userProfiles.userId) WHERE (login.userId =" + userID.ToString + ")"
        Try
            datareader = cmd.ExecuteReader()
            datareader.Read()
            If datareader.HasRows Then
                For f As Integer = 0 To 9
                    modProfile.Controls.Find("lblPro" + CStr(f), True)(0).Text = datareader(f).ToString
                Next
                For i As Integer = 0 To 8
                    modProfile.Controls.Find("txtPro" + CStr(i), True)(0).Text = DBNull.Value.ToString
                Next
                modProfile.Controls.Find("lblPro" + CStr(8), True)(0).Text = datareader(8).ToString.TrimEnd("0", "00", ":")
                questionID = datareader(6)
                datareader.Close()
            End If
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT question FROM secretQ WHERE questionID=" + questionID.ToString
            datareader = cmd.ExecuteReader()
            datareader.Read()
            modProfile.lblPro6.Text = datareader(0)
            datareader.Close()

            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT userName, surname FROM login WHERE userId=" + userID.ToString
            datareader = cmd.ExecuteReader()
            datareader.Read()
            userName = datareader(0)
            surname = datareader(1)
            datareader.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Public Sub get_ID()
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT login.userId FROM login WHERE (loginName='" + loginName + "') AND (passwd='" + password + "')"
        Try
            datareader = cmd.ExecuteReader()
            datareader.Read()
            If datareader.HasRows Then
                userID = datareader(0)
                datareader.Close()
                'Else
                ' userID = 0
                'datareader.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Public Sub userProfile_close()
        ProForm.btnModPro.Visible = False
        ProForm.chkBoxRecovery.Checked = False
        ProForm.chkBoxContact.Checked = False
        ProForm.grpBoxPro.Visible = False
        ProForm.chkBoxContact.Visible = False
        ProForm.chkBoxRecovery.Visible = False
    End Sub
    Public Sub userProfile_open()
        ProForm.btnModPro.Visible = True
        ProForm.grpBoxPro.Visible = True
        ProForm.chkBoxContact.Visible = True
        ProForm.chkBoxRecovery.Visible = True
    End Sub
    Public Sub submit_changes()
        Dim dateOB As String
        Dim updateProfilesWO As String
        Dim updateLoginWO As String
        Dim vacioLogin As Boolean = True
        Dim vacioProfile As Boolean = True
        Dim updateProfiles As String = "UPDATE userProfiles SET "
        Dim updateLogin As String = "UPDATE login SET "
        Dim updateArray(8) As String
        Dim updateArrayString(8) As String
        Dim endWhere As String = " WHERE login.userId=" & userID
        Dim endWhereUser As String = " WHERE userProfiles.userId=" & userID
        Dim updateColum() As String = {"login.userName='", "login.surname='", "userProfiles.email='", "userProfiles.mobPhone='", "userProfiles.phone='", "userProfiles.address='", "userProfiles.city='", "userProfiles.country='", "userProfiles.secretA='"}
        For i As Integer = 2 To 8
            updateArray(i) = modProfile.Controls.Find("txtPro" + CStr(i), True)(0).Text
            If updateArray(i) <> DBNull.Value.ToString Then
                vacioProfile = False
                updateArrayString(i) = updateColum(i) + updateArray(i) + "', "
                updateProfiles += updateArrayString(i)
            End If
        Next
        If vacioProfile = False Then
            updateProfilesWO = updateProfiles.Remove(updateProfiles.Length - 2, 1) & endWhereUser
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = updateProfilesWO
            Try
                cmd.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
        For e As Integer = 0 To 1
            updateArray(e) = modProfile.Controls.Find("txtPro" + CStr(e), True)(0).Text
            If updateArray(e) <> DBNull.Value.ToString Then
                vacioLogin = False
                updateArrayString(e) = updateColum(e) + updateArray(e) + "', "
                updateLogin += updateArrayString(e)
            End If
        Next
        If vacioLogin = False Then
            updateLoginWO = updateLogin.Remove(updateLogin.Length - 2, 1) & endWhere
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = updateLoginWO
            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
        If modProfile.dateDateOB.Checked = True Then
            dateOB = modProfile.dateDateOB.Value.Date
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "UPDATE userProfiles SET dataOB='" & dateOB & "'" & endWhereUser
            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub
    Public Sub save_image()
        Dim fs As FileStream
        Dim imageFile As String = userImageForm.OpenFileDialog1.FileName
        If imageFile = "" Or imageFile = "OpenFileDialog1" Then
            MsgBox(My.Resources.strings_en.selImgStr)
        Else
            Dim buffer() As Byte = File.ReadAllBytes(userImageForm.OpenFileDialog1.FileName)
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT userId FROM userImages WHERE userId=" + userID.ToString
            Try
                datareader = cmd.ExecuteReader()
                datareader.Read()
                If datareader.HasRows Then
                    cmd.Parameters.Clear()
                    datareader.Close()
                    cmd.Connection = conn
                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = "DELETE FROM userImages WHERE userId=" + userID.ToString
                    cmd.ExecuteNonQuery()
                    datareader.Close()
                    cmd.Connection = conn
                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = "INSERT INTO userImages (userId, image) values (@userId, @image)"
                    cmd.Parameters.AddWithValue("@userId", userID)
                    cmd.Parameters.AddWithValue("@image", buffer)
                    cmd.ExecuteNonQuery()
                    cmd.Connection = conn
                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = "SELECT image FROM userImages WHERE userId=" + userID.ToString
                    Dim buffer2() As Byte = (cmd.ExecuteScalar())
                    fs = New FileStream(temp + "\ProfilePic.jpg", FileMode.Create, FileAccess.Write)
                    fs.Write(buffer2, 0, buffer2.Length)
                    fs.Flush()
                    fs.Close()
                    path = temp & "\ProfilePic.jpg"
                    MsgBox(My.Resources.strings_en.imgSuccStr)
                    userImageForm.Close()
                Else
                    cmd.Parameters.Clear()
                    datareader.Close()
                    cmd.Connection = conn
                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = "INSERT INTO userImages (userId, image) values (@userId, @image)"
                    cmd.Parameters.AddWithValue("@userId", userID)
                    cmd.Parameters.AddWithValue("@image", buffer)
                    cmd.ExecuteNonQuery()
                    cmd.Connection = conn
                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = "SELECT image FROM userImages WHERE userId=" + userID.ToString
                    Dim buffer2() As Byte = (cmd.ExecuteScalar())
                    fs = New FileStream(temp + "\ProfilePic.jpg", FileMode.Create, FileAccess.Write)
                    fs.Write(buffer2, 0, buffer2.Length)
                    fs.Flush()
                    fs.Close()
                    path = temp & "\ProfilePic.jpg"
                    MsgBox(My.Resources.strings_en.imgSuccStr)
                    userImageForm.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub
    Public Sub read_image()
        Dim fs As FileStream
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT userId FROM userImages WHERE userId=" + userID.ToString
        datareader = cmd.ExecuteReader()
        datareader.Read()
        If datareader.HasRows Then
            datareader.Close()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT image FROM userImages WHERE userId=" + userID.ToString
            Dim buffer2() As Byte = (cmd.ExecuteScalar())
            fs = New FileStream(temp + "\ProfilePic.jpg", FileMode.Create, FileAccess.ReadWrite)
            fs.Write(buffer2, 0, buffer2.Length)
            fs.Flush()
            fs.Close()
            path = temp & "\ProfilePic.jpg"
        End If
        datareader.Close()
    End Sub
End Module

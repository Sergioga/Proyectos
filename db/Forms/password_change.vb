Public Class password_change
    Public userChgPass As Boolean

    Private Sub password_change_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT passwd FROM login WHERE (loginName= '" & loginName.ToUpper & "') AND (passwd= '***change***')"
        Try
            datareader = cmd.ExecuteReader()
            datareader.Read()
            If datareader.HasRows Then
                userChgPass = True
                datareader.Close()
                txtCurrent.Text = "***change***"
                txtCurrent.Enabled = False
                txtCurrent.PasswordChar = "#"
            Else
                userChgPass = False
                datareader.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.Text = My.Resources.strings_en.chgPassFormStr
        btnBack.Text = My.Resources.strings_en.btnBackStr
        btnChange.Text = My.Resources.strings_en.btnChanStr
        lbl1.Text = My.Resources.strings_en.currPassStr
        lbl2.Text = My.Resources.strings_en.newPassStr
        lbl3.Text = My.Resources.strings_en.reNewPassStr
        lbl4.Text = My.Resources.strings_en.accDetStr

        lblLoginName.Text = My.Resources.strings_en.userName & ": " & loginName
        lblName.Text = My.Resources.strings_en.nameStr & " " + userName
        lblSurname.Text = My.Resources.strings_en.surnameStr & " " + surname
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Try
            If userChgPass = True Then
                conn.Close()
                loginForm.Show()
                Me.Close()
            Else
                afterLogin.Show()
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        chk_passwd()
        Dim newPassword As String = txtNew.Text
        If txtNew.Text.Equals(txtNewRe.Text) Then
            chg_passwd(newPassword)
        Else
            MsgBox("The passwords don't match")
        End If

    End Sub
End Class
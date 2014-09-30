Public Class afterLogin
    Private Sub afterLogin_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If path <> "" Then
            ProPicBox.ImageLocation = path
        End If
    End Sub
    Public Sub afterLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = My.Resources.strings_en.menuFormStr
        Label1.Text = My.Resources.strings_en.addUsers
        Label2.Text = My.Resources.strings_en.manUsers
        Label3.Text = My.Resources.strings_en.pro
        Label4.Text = My.Resources.strings_en.chgPass
        Label5.Text = My.Resources.strings_en.logOut
        Label6.Text = My.Resources.strings_en.exitStr
        get_ID()
        read_image()
        If path <> "" Then
            ProPicBox.ImageLocation = path
        End If
        getlevel()
        lblSurname.Text = surname + ", " + userName + "         Permission Level: " + lvl
        If lvl >= 1 Then
            gprBox1.Visible = True
        End If
        If lvl >= 2 Then
            gprBox2.Visible = True
        End If
        If lvl >= 3 Then
            gprBox3.Visible = True
        End If
        If lvl >= 4 Then
            usersGrpBox.Visible = True
        End If
        If lvl >= 5 Then
            AdminGrpBox.Visible = True
        End If
    End Sub
    Private Sub AdminPic1_Click(sender As Object, e As EventArgs) Handles AdminPic1.Click
        UserManForm.Show()
    End Sub

    Private Sub ExitPicBox_Click(sender As Object, e As EventArgs) Handles ExitPicBox.Click
        conn.Close()
        Me.Close()
    End Sub

    Private Sub LoguotPicBox_Click(sender As Object, e As EventArgs) Handles LogoutPicBox.Click
        disconnect()
        Me.Close()
    End Sub

    Private Sub PassPicBox_Click(sender As Object, e As EventArgs) Handles PassPicBox.Click
        password_change.Show()
    End Sub
    Private Sub ProPicBox_MouseDown(sender As Object, e As MouseEventArgs) Handles ProPicBox.MouseDown
        If e.Button = MouseButtons.Right Then
            If userID = 0 Then
                MsgBox(My.Resources.strings_en.defUserPic, MsgBoxStyle.OkOnly, "Default User")
            Else
                userImageForm.Show()
            End If
        ElseIf e.Button = Windows.Forms.MouseButtons.Left Then
            If userID = 0 Then
                MsgBox(My.Resources.strings_en.defUserPic, MsgBoxStyle.OkOnly, "Default User")
            Else
                ProForm.Show()
            End If
        End If
    End Sub
End Class
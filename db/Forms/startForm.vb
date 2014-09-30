Imports System.Threading

Public Class startForm
    Private Sub startForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Forms.afterLogin.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        My.Forms.database_settings.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        My.Forms.loginForm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        My.Forms.modProfile.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        My.Forms.password_change.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        My.Forms.ProForm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        My.Forms.userImageForm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        My.Forms.UserManForm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        My.Forms.afterLogin.MaximizeBox = False
        My.Forms.database_settings.MaximizeBox = False
        My.Forms.loginForm.MaximizeBox = False
        My.Forms.modProfile.MaximizeBox = False
        My.Forms.password_change.MaximizeBox = False
        My.Forms.ProForm.MaximizeBox = False
        Me.MaximizeBox = False
        My.Forms.userImageForm.MaximizeBox = False
        My.Forms.UserManForm.MaximizeBox = False
        If RadioButton1.Checked = True Then
            Label4.Text = My.Resources.strings_es.exitStr
            Label3.Text = My.Resources.strings_es.startStr
            Label2.Text = My.Resources.strings_es.settStr
            Label1.Text = My.Resources.strings_es.dbStatusStr
        ElseIf RadioButton2.Checked = True Then
            Label4.Text = My.Resources.strings_en.exitStr
            Label3.Text = My.Resources.strings_en.startStr
            Label2.Text = My.Resources.strings_en.settStr
            Label1.Text = My.Resources.strings_en.dbStatusStr
        End If
        
    End Sub
    Private Sub PictureBox1_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox1.MouseHover
        PictureBox1.Location = New Point(25, 146)
        PictureBox1.Size = New Size(128, 128)
        Label2.Visible = True
    End Sub

    Private Sub PictureBox2_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox2.MouseHover
        PictureBox2.Location = New Point(248, 146)
        PictureBox2.Size = New Size(128, 128)
        Label3.Visible = True
    End Sub
    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox2.MouseLeave
        PictureBox2.Location = New Point(257, 155)
        PictureBox2.Size = New Size(110, 110)
        Label3.Visible = False
    End Sub

    Private Sub PictureBox3_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox3.MouseEnter
        PictureBox3.Location = New Point(310, 312)
        PictureBox3.Size = New Size(90, 90)
        Label4.Visible = True
    End Sub
    Private Sub PictureBox3_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox3.MouseLeave
        PictureBox3.Location = New Point(319, 321)
        PictureBox3.Size = New Size(72, 72)
        Label4.Visible = False
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        database_settings.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox2_CLick(sender As Object, e As EventArgs) Handles PictureBox2.Click
        loginForm.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.Location = New Point(34, 155)
        PictureBox1.Size = New Size(110, 110)
        Label2.Visible = False
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            Label5.Visible = True
            Label6.Visible = False
            Label4.Text = My.Resources.strings_es.exitStr
            Label3.Text = My.Resources.strings_es.startStr
            Label2.Text = My.Resources.strings_es.settStr
            Label1.Text = My.Resources.strings_es.dbStatusStr
        ElseIf RadioButton2.Checked = True Then
            Label6.Visible = True
            Label5.Visible = False
            Label4.Text = My.Resources.strings_en.exitStr
            Label3.Text = My.Resources.strings_en.startStr
            Label2.Text = My.Resources.strings_en.settStr
            Label1.Text = My.Resources.strings_en.dbStatusStr
        End If
    End Sub
End Class
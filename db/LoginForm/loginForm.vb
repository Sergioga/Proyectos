Imports System.IO

Public Class loginForm

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'chk_conn_str()
        Me.Text = My.Resources.strings_en.logFormStr
        Label1.Text = My.Resources.strings_en.userName
        Label2.Text = My.Resources.strings_en.pass
        btnLogin.Text = My.Resources.strings_en.btnLogInStr
        connect()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim login As String
        Dim passwd As String
        login = txtUser.Text
        passwd = txtPass.Text
        chk_login_chg(login)
        loginfunc(login, passwd)
    End Sub

    Private Sub txtPass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPass.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            Dim login As String
            Dim passwd As String
            login = txtUser.Text
            passwd = txtPass.Text
            chk_login_chg(login)
            loginfunc(login, passwd)
        End If
    End Sub

End Class

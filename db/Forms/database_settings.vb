Public Class database_settings

    Private Sub database_settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = My.Resources.strings_en.nameIPstr
        Label2.Text = My.Resources.strings_en.dbStr
        Label3.Text = My.Resources.strings_en.instanceNameStr
        Label3.Enabled = False
        TextBox3.Enabled = False
        TextBox3.Text = "SQLEXPRESSFORAPP"
        Label4.Text = My.Resources.strings_en.dbUserStr
        Label4.Enabled = False
        TextBox4.Enabled = False
        TextBox4.Text = "sa"
        Label5.Text = My.Resources.strings_en.dbPassStr
        Label5.Enabled = False
        TextBox5.Enabled = False
        TextBox5.Text = "Qwerty123"
        TextBox5.PasswordChar = "#"
        CheckBox1.Text = My.Resources.strings_en.dbChkBoxStr
        CheckBox1.CheckState = CheckState.Unchecked
        Button1.Text = My.Resources.strings_en.btnClose
        Button2.Text = My.Resources.strings_en.btnSaveStr
        Me.Text = My.Resources.strings_en.dbSettStr
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.CheckState = CheckState.Unchecked Then
            Label3.Enabled = False
            Label4.Enabled = False
            Label5.Enabled = False
            TextBox3.Enabled = False
            TextBox4.Enabled = False
            TextBox5.Enabled = False
        Else
            Label3.Enabled = True
            Label4.Enabled = True
            Label5.Enabled = True
            TextBox3.Enabled = True
            TextBox4.Enabled = True
            TextBox5.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        startForm.Show()
        Me.Close()
    End Sub
End Class
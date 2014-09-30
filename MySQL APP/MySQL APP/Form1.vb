Imports EDAPP.Crypto

Public Class Form1
    'Public lang As String
    Public serial As Int64

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.Control AndAlso e.Shift AndAlso e.KeyCode = Keys.D Then
            If debugChk.Visible = False Then
                debugChk.Visible = True
                debugChk.CheckState = CheckState.Checked
                debugChk.Text = "Debug mode activated"
                debugChk.ForeColor = Color.Red
                debugChk.AutoCheck = False
                isDebug = debugChk.CheckState
            Else
                debugChk.Visible = False
                debugChk.CheckState = CheckState.Unchecked
                debugChk.Text = ""
                isDebug = debugChk.CheckState
            End If
        End If
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If radBtnEs.Checked = True Then
            lang = "es"
            Label1.Text = My.Resources.strings_es.startStr
            Label2.Text = My.Resources.strings_es.settingsStr
            Label3.Text = My.Resources.strings_es.exitStr
        ElseIf radBtnEn.Checked = True Then
            lang = "en"
            Label1.Text = My.Resources.strings_en.startStr
            Label2.Text = My.Resources.strings_en.settingsStr
            Label3.Text = My.Resources.strings_en.exitStr
        End If
    End Sub

    Private Sub radBtnEn_CheckedChanged(sender As Object, e As EventArgs) Handles radBtnEn.CheckedChanged
        If radBtnEn.Checked = True Then
            lang = "en"
            Label1.Text = My.Resources.strings_en.startStr
            Label2.Text = My.Resources.strings_en.settingsStr
            Label3.Text = My.Resources.strings_en.exitStr
        End If
    End Sub

    Private Sub radBtnEs_CheckedChanged(sender As Object, e As EventArgs) Handles radBtnEs.CheckedChanged
        If radBtnEs.Checked = True Then
            lang = "es"
            Label1.Text = My.Resources.strings_es.startStr
            Label2.Text = My.Resources.strings_es.settingsStr
            Label3.Text = My.Resources.strings_es.exitStr
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        radBtnEs.Checked = True
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        radBtnEn.Checked = True
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.Close()
    End Sub

    Private Sub PictureBox1_MouseHover(sender As Object, e As EventArgs) Handles PictureBox1.MouseHover
        Label2.Visible = True
    End Sub

    Private Sub PictureBox2_MouseHover(sender As Object, e As EventArgs) Handles PictureBox2.MouseHover
        Label1.Visible = True
    End Sub

    Private Sub PictureBox5_MouseHover(sender As Object, e As EventArgs) Handles PictureBox5.MouseHover
        Label3.Visible = True
    End Sub

    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox2.MouseLeave
        Label1.Visible = False
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        Label2.Visible = False
    End Sub

    Private Sub PictureBox5_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox5.MouseLeave
        Label3.Visible = False
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        mysqlSettings.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim license As String
        If mysqlConn.State = ConnectionState.Open Then
            mysqlConn.Close()
        End If
        mysqlConn.ConnectionString = "server=localhost; uid=sergio; password=qwerty"  '' Change to something else
        mysqlConn.Open()
        cmd.Connection = mysqlConn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT * FROM appmysql.license WHERE id=1"
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            dr.Read()
            serial = dr("serial")
            license = dr("license").ToString
            If license = "0" Then
                licenseFrom.Show()
            Else
                If check_serial(serial, license) = True Then
                    MsgBox("Verificada")
                ElseIf check_serial(serial, license) = False Then
                    MsgBox("Verificacion fallida")
                End If
            End If
            dr.Close()
        Else
            dr.Close()
            MsgBox("It seems there is a problem with the connection to the database... Did you use the correct settings?")
        End If
    End Sub
End Class

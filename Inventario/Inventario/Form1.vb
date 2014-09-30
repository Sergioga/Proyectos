Public Class inventarioForm

    Private Sub inventarioForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MaximizeBox = False
        PictureBox1.Image = My.Resources.loginImg
        passTxt.PasswordChar = ""
    End Sub

    Private Sub salirBtn_Click(sender As Object, e As EventArgs) Handles salirBtn.Click
        Me.Close()
    End Sub

    Private Sub userTxt_Enter(sender As Object, e As EventArgs) Handles userTxt.Enter
        If userTxt.Text = "Usuario" Then
            userTxt.Text = DBNull.Value.ToString
        End If
    End Sub

    Private Sub userTxt_Leave(sender As Object, e As EventArgs) Handles userTxt.Leave
        If userTxt.Text = DBNull.Value.ToString Then
            userTxt.Text = "Usuario"
        Else
            userTxt.Text = userTxt.Text.ToUpper
        End If
    End Sub

    Private Sub passTxt_Enter(sender As Object, e As EventArgs) Handles passTxt.Enter
        If passTxt.Text = "Contraseña" Then
            passTxt.Text = DBNull.Value.ToString
            passTxt.PasswordChar = "#"
        End If

    End Sub

    Private Sub passTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles passTxt.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            login()
        End If
    End Sub

    Private Sub passTxt_Leave(sender As Object, e As EventArgs) Handles passTxt.Leave
        If passTxt.Text = DBNull.Value.ToString Then
            passTxt.Text = "Contraseña"
            passTxt.PasswordChar = ""
        End If
    End Sub

    Private Sub logBtn_Click(sender As Object, e As EventArgs) Handles logBtn.Click
        login()
    End Sub
    Public Sub login()
        Try
            If DBCon.State = ConnectionState.Closed Then
                DBCon.Open()
            End If
            cmd.Connection = DBCon
            cmd.CommandText = "SELECT * FROM Usuarios WHERE (Login=""" & userTxt.Text & """) AND (Contraseña=""" & passTxt.Text & """)"
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                Panel1.Visible = True
                Panel1.Enabled = true
                Panel2.Visible = False
                Panel2.Enabled = False
                Panel3.Visible = True
                Panel3.Enabled = True
                ArticulosBox.Image = My.Resources.art
                SerialBox.Image = My.Resources.ser
                ReportsBox.Image = My.Resources.rep
                OpcionesBox.Image = My.Resources.settings
            Else
                Label1.Visible = True
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub SalirMainBtn_Click(sender As Object, e As EventArgs) Handles SalirMainBtn.Click
        If DBCon.State = ConnectionState.Open Then
            DBCon.Close()
        End If
        Me.Close()
    End Sub

    Private Sub SesionBtn_Click(sender As Object, e As EventArgs) Handles SesionBtn.Click
        If DBCon.State = ConnectionState.Open Then
            DBCon.Close()
        End If
        Panel2.Visible = True
        Panel2.Enabled = True
        Panel3.Visible = False
        Panel3.Enabled = False
        passTxt.Text = "Contraseña"
        passTxt.PasswordChar = ""
        userTxt.Text = "Usuario"
    End Sub

    Private Sub ArticulosBox_Click(sender As Object, e As EventArgs) Handles ArticulosBox.Click
        articulos.Show()
    End Sub
End Class

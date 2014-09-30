Public Class Form1

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub btn_enter_Click(sender As Object, e As EventArgs) Handles btn_enter.Click
        If txt_pass.Text = "w4511" Then
            form2.Show()
            Me.Close()
        Else
            Label1.Visible = True
        End If
    End Sub

    Private Sub txt_pass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_pass.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            If txt_pass.Text = "w4511" Then
                form2.Show()
                Me.Close()
            Else
                Label1.Visible = True
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_pass.Focus()
    End Sub
End Class

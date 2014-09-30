Imports EDAPP.Crypto
Imports System.Math
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim a As Int64 = random_gen()
        TextBox1.Text = a.ToString
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If check_serial(TextBox1.Text, TextBox2.Text) = True Then
            MsgBox("Verificada")
        ElseIf check_serial(TextBox1.Text, TextBox2.Text) = False Then
            MsgBox("Verificacion fallida")
        End If
    End Sub
End Class

Imports EDAPP.Crypto
Public Class licenseFrom

    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        Me.Close()
    End Sub

    Private Sub verBtn_Click(sender As Object, e As EventArgs) Handles verBtn.Click
        If check_serial(TextBox1.Text, TextBox2.Text) = True Then
            Try
                tr = mysqlConn.BeginTransaction
                cmd.Connection = mysqlConn
                cmd.Transaction = tr
                cmd.CommandText = "UPDATE appmysql.license SET license='" & TextBox2.Text & "' WHERE serial=" & Form1.serial
                cmd.ExecuteNonQuery()
                tr.Commit()
            Catch ex As Exception
                tr.Rollback()
                If isDebug = True Then
                    MsgBox(ex.ToString)
                End If
            End Try
            MsgBox("Verificada")

        ElseIf check_serial(TextBox1.Text, TextBox2.Text) = False Then
            MsgBox("Verificacion fallida")
            Me.Close()
        End If
    End Sub

    Private Sub licenseFrom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = Form1.serial
    End Sub
End Class
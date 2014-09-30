Public Class menu

    Private Sub menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Add("Autorizacióon 1")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Select Case ListBox1.SelectedIndex
            Case 0
                MsgBox("selecion 1")
                visorForm.CrystalReportViewer1.ReportSource = "./autorizacion.rpt"
                firmarForm.Show()
            Case Else
                MsgBox("nah")

        End Select

    End Sub
End Class

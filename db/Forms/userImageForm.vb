Public Class userImageForm

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.Filter = My.Resources.strings_en.diagFilter
        OpenFileDialog1.Title = My.Resources.strings_en.diagTitle
        OpenFileDialog1.Multiselect = False
        OpenFileDialog1.ValidateNames = True
        OpenFileDialog1.FileName = DBNull.Value.ToString
        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.FileName <> "" Then
            Try
                PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
            Catch ex As Exception
                MsgBox(e.ToString)
            End Try
        End If
        'PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        save_image()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub userImageForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = My.Resources.strings_en.proImgFormStr
        Button1.Text = My.Resources.strings_en.btnSelImg
        Button2.Text = My.Resources.strings_en.btnSaveStr
        Button4.Text = My.Resources.strings_en.btnBackStr
        If path <> "" Then
            PictureBox1.ImageLocation = path
        End If
    End Sub
End Class
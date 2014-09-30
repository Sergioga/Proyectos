Imports System.IO
Public Class Form1
    Public file() As String
    Public awnsers() As String
    Public questions() As String
    Public lines() As String
    Public QandA() As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximizeBox = False
        PictureBox1.AllowDrop = True
    End Sub
    Private Sub PictureBox1_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PictureBox1.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.All
        End If
    End Sub
    Private Sub PictureBox1_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PictureBox1.DragDrop
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            file = Nothing
            file = e.Data.GetData(DataFormats.FileDrop)
            If file(0).EndsWith(".txt") Then
                Dim a As StreamReader = New StreamReader(file(0).ToString, System.Text.Encoding.ASCII)
                Dim line As String = "-"
                Dim i As Integer = 0
                Do Until line Is Nothing
                    ReDim Preserve lines(i)
                    line = a.ReadLine()
                    lines(i) = a.ReadLine()
                    i += 1
                Loop
                a.Close()
                For f As Integer = 0 To lines.Length - 1
                    ReDim Preserve QandA(f)
                    MsgBox(lines(f).Split("::").ToString)

                Next
            Else
                file(0) = "Archivo no valido"
                MsgBox("El archivo no es valido", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox(file(0).ToString)
        Try
            MsgBox(lines(0).ToString)
            MsgBox(lines(1).ToString)
            MsgBox(lines(2).ToString)
            MsgBox(QandA(0).ToString)
            MsgBox(QandA(1).ToString)
            MsgBox(QandA(2).ToString)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub
End Class

Imports System.Collections.Specialized
Imports System.IO
Public Class Form1
    Public Const del As String = "::"
    Public lines() As String
    Public i As Integer = 0
    Public textToWrite As New StringCollection()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.Columns.Add("Preguntas")
        ListView1.Columns.Add("Respuestas")
        ListView1.View = View.Details
        ListView1.Columns(0).Width = 308
        ListView1.Columns(1).Width = 308

    End Sub

    Private Sub btnAñadir_Click(sender As Object, e As EventArgs) Handles btnAñadir.Click
        Dim item1 As New ListViewItem(TextBox1.Text)
        item1.SubItems.Add(TextBox2.Text)
        ListView1.Items.AddRange(New ListViewItem() {item1})
        textToWrite.Add(TextBox1.Text & del & TextBox2.Text)
        TextBox1.Text = Nothing
        TextBox2.Text = Nothing
    End Sub

    Private Sub btnBorrarTodo_Click(sender As Object, e As EventArgs) Handles btnBorrarTodo.Click
        ListView1.Items.Clear()
        textToWrite.Clear()
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Dim stopLoop As Boolean = False
        Dim f As Integer = 0
        Dim stringOn As String
        For Each item In ListView1.SelectedItems
            Do Until stopLoop = True
                stringOn = textToWrite.Item(f)
                If stringOn.Contains(item.ToString.Substring(15).Replace("}", "")) Then
                    textToWrite.RemoveAt(f)
                    stopLoop = True
                End If
                If f = textToWrite.Count - 1 Then
                    stopLoop = True
                Else
                    f += 1
                End If
            Loop
            
            ListView1.Items.Remove(item)
        Next
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim saveFileDialog1 As New SaveFileDialog()
        Dim copytext(textToWrite.Count - 1) As String
        saveFileDialog1.Filter = "QAF Files|*.qaf"
        saveFileDialog1.Title = "Guardar cuestionario"
        saveFileDialog1.ShowDialog()
        Dim fs = New FileStream(saveFileDialog1.FileName, FileMode.Create)
        Dim writer = New StreamWriter(fs)
        For Each foundString As String In
           textToWrite
            foundString = foundString & vbCrLf
            writer.Write(foundString)
        Next
        writer.Close()
    End Sub
End Class

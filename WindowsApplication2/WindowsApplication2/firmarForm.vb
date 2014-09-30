Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Drawing.Drawing2D


Public Class firmarForm
    Private isPainting As Boolean = False
    Private pX As Integer = -1
    Private pY As Integer = -1
    Private drawing As Bitmap
    Private unlockCursor As Boolean = False
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cursor.Position = Label1.Parent.PointToScreen(Label1.Location)
        drawing = New Bitmap(Panel1.Width, Panel1.Height, Panel1.CreateGraphics())
        Graphics.FromImage(drawing).Clear(Color.White)
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        isPainting = True
        pX = e.X
        pY = e.Y
    End Sub

    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp
        isPainting = False
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If unlockCursor = False Then
            Cursor.Clip = Me.RectangleToScreen(Me.ClientRectangle)
        End If

        If isPainting = True Then
            Dim myGraphic = Graphics.FromImage(drawing)

            Dim myPen = New Pen(Color.Black, 3)

            myPen.EndCap = LineCap.Round
            myPen.StartCap = LineCap.Round

            myGraphic.DrawLine(myPen, pX, pY, e.X, e.Y)

            Panel1.CreateGraphics().DrawImageUnscaled(drawing, New Point(0, 0))
            pX = e.X
            pY = e.Y
        End If
    End Sub
    Private Sub panel1_Paint(sender As Object, e As PaintEventArgs)
        e.Graphics.DrawImageUnscaled(drawing, New Point(0, 0))
    End Sub

    Private Sub Panel1_MouseEnter(sender As Object, e As EventArgs) Handles Panel1.MouseEnter
        If unlockCursor = False Then
            Cursor.Clip = Me.RectangleToScreen(Me.ClientRectangle)
        End If

    End Sub
    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            unlockCursor = True
            Cursor.Clip = Nothing
            drawing.Save(".\firma.bmp")
            MsgBox("He acabado de dibujar")
            visor.Show()
            Me.Close()
        ElseIf e.KeyChar = Convert.ToChar(Keys.Escape) Then
            unlockCursor = True
            Cursor.Clip = Nothing
            MsgBox("Salir")
            visor.Show()
            Me.Close()

        End If
    End Sub
End Class

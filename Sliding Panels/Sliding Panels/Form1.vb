Imports System.Threading
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.DoubleBuffered = True
        MaximizeBox = False
        MsgBox(My.Computer.GetHashCode)
    End Sub
    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles Panel1.Click
        Dim palen4docked As Boolean = False
        If Panel4.Width <> 0 Then
            Dim pWidth As Integer = Me.Width
            While Panel4.Width <> 0
                Panel4.Width -= 1
                Thread.Sleep(0.5)
            End While
            Thread.Sleep(100)
            palen4docked = True
        Else
            palen4docked = True
        End If

        If palen4docked = True Then
            If Panel3.Width = 0 Then
                Dim pWidth As Integer = Me.Width
                While pWidth - Panel3.Width <> 50
                    Panel3.Width += 1
                    Thread.Sleep(0.5)
                End While

            Else
                While Panel3.Width <> 0
                    Panel3.Width -= 1
                    Thread.Sleep(0.5)
                End While
            End If
        End If

    End Sub

    

    Private Sub Panel2_Click(sender As Object, e As EventArgs) Handles Panel2.Click

        Dim palen3docked As Boolean = False
        If Panel3.Width <> 0 Then
            Dim pWidth As Integer = Me.Width
            While Panel3.Width <> 0
                Panel3.Width -= 1
                Thread.Sleep(0.5)
            End While
            Thread.Sleep(100)
            palen3docked = True
        Else
            palen3docked = True
        End If

        If palen3docked = True Then
            If Panel4.Width = 0 Then
                Dim pWidth As Integer = Me.Width
                While pWidth - Panel4.Width <> 50
                    Panel4.Width += 1
                    Thread.Sleep(0.5)
                End While

            Else
                While Panel4.Width <> 0
                    Panel4.Width -= 1
                    Thread.Sleep(0.5)
                End While
            End If
        End If




    End Sub
End Class

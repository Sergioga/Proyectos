Imports System
Imports Microsoft.VisualBasic
Imports System.Threading

Public Class form
    Public rutaBBDD As String
    Public contCheck As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MaximizeBox = False
        MinimizeBox = False
    End Sub

    Private Sub Panel1_DragDrop(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles Panel1.DragDrop
        Dim filePath As String() = CType(e.Data.GetData(DataFormats.FileDrop), String())
        If filePath(0) <> DBNull.Value.ToString Then
            If filePath(0).Substring(filePath(0).Length - 10).ToUpper = "WINVET.MDB" Then
                rutaBDTxt.Text = filePath(0)
                rutaBBDD = rutaBDTxt.Text
                Me.Size = New Size(397, 353)
                PictureBox1.Location = New Point(328, 273)
                'Panel1.Visible = False
                Label2.Visible = False
                accessIcon.Visible = True
                winLbl.Text = rutaBBDD
                winLbl.Visible = True
                If checkLDB() = True Then
                    warnLbl.Visible = False
                    compBtn.Visible = True
                ElseIf checkLDB() = False Then
                    warnLbl.Visible = True
                    compBtn.Visible = False
                End If
            Else
                MsgBox("Arrastra la BBDD de Winvet al recuadro...", MsgBoxStyle.Information, "BBDD erronea...")
            End If
        End If
    End Sub
    Private Sub Panel1_DragEnter(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles Panel1.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub examBtn_Click(sender As Object, e As EventArgs) Handles examBtn.Click
        OpenFileDialog1.FileName = DBNull.Value.ToString
        OpenFileDialog1.Filter = "Base de datos de MS Access (*.mdb)|*.mdb"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            rutaBBDD = OpenFileDialog1.FileName
            If rutaBBDD.Substring(rutaBBDD.Length - 10).ToUpper = "WINVET.MDB" Then
                rutaBDTxt.Text = rutaBBDD
                Me.Size = New Size(397, 353)
                PictureBox1.Location = New Point(328, 273)
                'Panel1.Visible = False
                Label2.Visible = False
                accessIcon.Visible = True
                winLbl.Text = rutaBBDD
                winLbl.Visible = True
                If checkLDB() = True Then
                    warnLbl.Visible = False
                    compBtn.Visible = True
                    ' MsgBox("compactar")
                ElseIf checkLDB() = False Then
                    warnLbl.Visible = True
                    compBtn.Visible = False
                End If
            Else
                MsgBox("Selecciona la BBDD de Winvet...", MsgBoxStyle.Information, "BBDD erronea...")
                rutaBBDD = DBNull.Value.ToString
                rutaBDTxt.Text = DBNull.Value.ToString
            End If

            'MsgBox(rutaBBDD)
        End If
    End Sub

    Private Function checkLDB()
        Dim closed As Boolean
        Try
            If My.Computer.FileSystem.FileExists(rutaBBDD.Remove(rutaBBDD.Length - 3, 3) & "ldb") Then
                My.Computer.FileSystem.DeleteFile(rutaBBDD.Remove(rutaBBDD.Length - 3, 3) & "ldb")
                closed = True
            Else
                closed = True
            End If
        Catch ex As Exception
            closed = False
        End Try
        Return closed
    End Function

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub




    Private Sub compBtn_Click(sender As Object, e As EventArgs) Handles compBtn.Click

        If checkLDB() = True Then
            mensaje.Show()
            Me.Close()
        ElseIf checkLDB() = False Then
            compBtn.Visible = False
            warnLbl.Visible = True
            MsgBox("Se ha abierto Winvet en el proceso de compactacion, por favor cierra todos los Winvet y vuelve a intentarlo.", MsgBoxStyle.Information, "BBDD Abierta")
        End If
    End Sub
End Class

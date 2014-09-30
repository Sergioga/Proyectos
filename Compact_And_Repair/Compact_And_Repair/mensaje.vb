Imports System.Threading
Public Class mensaje
    Public rutaBBDD As String = form.rutaBBDD
    Public t1 As New Thread(AddressOf compactBBDD)
    Private Sub mensaje_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        t1.Start()
    End Sub
    Public Sub compactBBDD()
        Dim fecha As String = Date.Now.ToShortDateString.Replace("/", "_")
        Try
            Dim jro As New JRO.JetEngine
            If My.Computer.FileSystem.FileExists(rutaBBDD) Then
                'Me.Close()
                'mensaje.Show()
                My.Computer.FileSystem.CopyFile(rutaBBDD, rutaBBDD.Remove(rutaBBDD.Length - 4, 4) & "_Backup_" & fecha & ".mdb", True)
                jro.CompactDatabase("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & rutaBBDD & ";Jet OLEDB:Database Password=14DaNiTe0996", _
"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & rutaBBDD.Remove(rutaBBDD.Length - 4, 4) & "-Compactada.mdb" & ";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Password=14DaNiTe0996")
                My.Computer.FileSystem.MoveFile(rutaBBDD.Remove(rutaBBDD.Length - 4, 4) & "-Compactada.mdb", rutaBBDD, True)
                MsgBox("Se ha completado la operación correctamente. Ya puede volver a utilizar Winvet.", MsgBoxStyle.Information, "Winvet")
                CloseMe()
            Else
                MsgBox("Se ha encotrado un problema al crear la copia temporal... Saliendo.", MsgBoxStyle.Exclamation, "Copia temporal")
                CloseMe()
            End If


        Catch ex As Exception
            MsgBox("Se ha encontrado algun error en el proceso. Se ha creado una copia llamada Winvet_Backup. Se intentara restaurar la copia automaticamente. Error: " & ex.ToString)
            If My.Computer.FileSystem.FileExists(rutaBBDD.Remove(rutaBBDD.Length - 4, 4) & "_Backup_" & fecha & ".mdb") Then
                My.Computer.FileSystem.CopyFile(rutaBBDD.Remove(rutaBBDD.Length - 4, 4) & "_Backup_" & fecha & ".mdb", rutaBBDD, True)
            End If
            CloseMe()
        End Try


    End Sub

    Private Sub CloseMe()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf CloseMe))
            Exit Sub
        End If
        Me.Close()
    End Sub
End Class
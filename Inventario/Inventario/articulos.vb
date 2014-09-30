Public Class articulos
    Public cantidad As Integer
    Public nombre As String
    Public descripcion As String
    Public seleccionado As Boolean = False
    Public autonumero As Integer
    Public numero As Integer = 1

    Private Sub articulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(290, 130)
        MaximizeBox = False
    End Sub

    Private Sub findBtn_Click(sender As Object, e As EventArgs) Handles findBtn.Click
        Me.Size = New Size(500, 400)
        nombreTxt.Text = ""
        desTxt.Text = ""
        cantTxt.Text = ""
        seleccionado = False
        Try
            If DBCon.State = ConnectionState.Closed Then
                DBCon.Open()
            End If
            cmd.Connection = DBCon
            cmd.CommandText = "SELECT Nombre FROM Articulos WHERE (Nombre LIKE '%" & findTxt.Text & "%')"
            cmd.CommandType = CommandType.Text

            ListBox1.Visible = True
            delBtn.Visible = True
            nombreLbl.Visible = True
            nombreTxt.Visible = True
            desLbl.Visible = True
            desTxt.Visible = True
            actBtn.Visible = True

            If ListBox1.Visible = True Then
                ListBox1.Items.Clear()
            End If
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read()
                    ListBox1.Items.Add(dr.Item("Nombre").ToString)
                End While
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub newBtn_Click(sender As Object, e As EventArgs) Handles newBtn.Click
        Me.Size = New Size(290, 400)
        nombreTxt.Text = ""
        desTxt.Text = ""
        cantTxt.Text = ""
        cantLbl.Visible = False
        cantTxt.Visible = False
        seleccionado = False
        delBtn.Visible = True
        nombreLbl.Visible = True
        nombreTxt.Visible = True
        desLbl.Visible = True
        desTxt.Visible = True
        actBtn.Visible = True
        seleccionado = False
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedItem = DBNull.Value.ToString Then
        Else
            If DBCon.State = ConnectionState.Closed Then
                DBCon.Open()
            End If
            cmd.Connection = DBCon
            cmd.CommandText = "SELECT Nombre, Descripcion, Cantidad FROM Articulos WHERE (Nombre =""" & ListBox1.SelectedItem.ToString & """)"
            cmd.CommandType = CommandType.Text
            Try
                dr = cmd.ExecuteReader
                If dr.HasRows Then
                    dr.Read()
                    nombreTxt.Text = dr(0)
                    nombre = dr(0)
                    desTxt.Text = dr(1)
                    descripcion = dr(1)
                    cantLbl.Visible = True
                    cantTxt.Visible = True
                    cantTxt.Text = dr(2)
                    cantidad = dr(2)
                    cantTxt.ReadOnly = True
                    seleccionado = True
                End If
                dr.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
        
    End Sub

    Private Sub actBtn_Click(sender As Object, e As EventArgs) Handles actBtn.Click
        Try
            If DBCon.State = ConnectionState.Closed Then
                DBCon.Open()
            End If
            If seleccionado = False Then

                cmd.Connection = DBCon
                cmd.CommandText = "SELECT ID FROM Articulos WHERE ID=" & numero
                dr = cmd.ExecuteReader
                While dr.HasRows
                    dr.Close()
                    numero = numero + 1
                    cmd.CommandText = "SELECT ID FROM Articulos WHERE ID=" & numero
                    dr = cmd.ExecuteReader
                End While
                dr.Close()

                tr = DBCon.BeginTransaction()
                cmd.Transaction = tr
                cmd.CommandText = "INSERT INTO Articulos (Nombre, Descripcion, Cantidad, ID) VALUES ('" & nombreTxt.Text & "', '" & desTxt.Text & "', 0, " & numero & ")"
                cmd.ExecuteNonQuery()
                tr.Commit()
                cmd.Dispose()

            Else
                cmd.Connection = DBCon
                tr = DBCon.BeginTransaction()
                cmd.Transaction = tr
                cmd.CommandText = "UPDATE Articulos SET Nombre = '" & nombreTxt.Text & "', Descripcion = '" & desTxt.Text & "' WHERE (Articulos.Nombre = '" & ListBox1.SelectedItem.ToString & "')"
                cmd.ExecuteNonQuery()
                tr.Commit()
                cmd.Dispose()
            End If
        Catch ex As Exception
            tr.Rollback()
            MsgBox(ex.ToString)
        End Try
        

    End Sub
End Class
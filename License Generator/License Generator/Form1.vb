Public Class Form1
    Public accessConn As New OleDb.OleDbConnection(My.Settings.licensesDDBB)
    Public command As New OleDb.OleDbCommand
    Public dataReader As OleDb.OleDbDataReader
    Public serial As Decimal
    Public license As String
    Public client As String

    Public Shared Function generate_license(ByVal serialNumber As Int64)
        Dim number As Integer = 1
        Dim licStringsLenght As Integer = 0
        Dim licenseVerified As String = " "
        For i As Integer = 0 To 100
            While number <> 0
                number = serialNumber Mod 10000
                serialNumber = serialNumber / 10000
                licenseVerified = licenseVerified.Insert(licStringsLenght, get_license(number).ToString)
                licStringsLenght = licenseVerified.Length
            End While
            Exit For
        Next
        licenseVerified = licenseVerified.Replace(" ", "X")
        Return licenseVerified
    End Function

    Public Shared Function get_license(ByVal tok As Integer)
        Dim numberToHex As Decimal = Math.Pow(tok, 4)
        Dim hexa As String = Hex(numberToHex)
        Return hexa
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox3.Text = DBNull.Value.ToString Then
            MsgBox("You need to insert a client name!", MsgBoxStyle.Information)
        ElseIf TextBox1.Text = DBNull.Value.ToString Then
            MsgBox("You need to insert a serial!", MsgBoxStyle.Information)
        Else
            command.Connection = accessConn
            command.CommandText = "SELECT serial FROM Licenses WHERE serial =" & TextBox1.Text
            command.CommandType = CommandType.Text
            Try
                dataReader = command.ExecuteReader
                If dataReader.HasRows Then
                    MsgBox("This serial number its already registered to someone. Please check it", MsgBoxStyle.Information)
                    TextBox1.Text = ""
                    TextBox3.Text = ""
                    TextBox2.Text = ""
                    TextBox1.ReadOnly = False
                    TextBox3.ReadOnly = False
                    PictureBox1.Enabled = True
                    PictureBox2.Enabled = True
                    dataReader.Close()
                Else
                    dataReader.Close()
                    command.CommandText = "SELECT serial FROM Licenses WHERE client ='" & TextBox3.Text & "'"
                    dataReader = command.ExecuteReader
                    If dataReader.HasRows Then
                        MsgBox("This client name its already on the database. Please change or check it.", MsgBoxStyle.Information)
                        dataReader.Close()
                    Else
                        dataReader.Close()
                        TextBox2.Text = generate_license(TextBox1.Text)
                        command.Connection = accessConn
                        command.CommandText = "INSERT INTO Licenses (client, serial, license) VALUES ('" & TextBox3.Text & "'," & TextBox1.Text & ", '" & TextBox2.Text & "')"
                        command.CommandType = CommandType.Text
                        command.ExecuteNonQuery()
                    End If
                End If
                dataReader.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            Me.Size = New Size(510, 271)
            Button3.Visible = False
            ListBox1.Visible = False
            TextBox4.Text = Nothing
            TextBox4.Visible = False
            Label4.Visible = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Size = New Size(510, 271)
        Button3.Visible = False
        ListBox1.Visible = False
        TextBox1.ReadOnly = False
        TextBox3.ReadOnly = False
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = Nothing
        TextBox4.Visible = False
        Label4.Visible = False
        PictureBox1.Enabled = True
        PictureBox2.Enabled = True
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        accessConn.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MaximizeBox = False
        Try
            accessConn.Open()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.Size = New Size(510, 271)
        Button3.Visible = False
        ListBox1.Visible = False
        TextBox2.ReadOnly = True
    End Sub
    Private Sub textbox1_enter(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            Me.Size = New Size(756, 271)
            ListBox1.Visible = True
            Button3.Visible = True
            command.Connection = accessConn
            command.CommandText = "SELECT serial FROM Licenses WHERE (serial LIKE '%" & TextBox1.Text & "%')"
            command.CommandType = CommandType.Text
            Try
                If ListBox1.Visible = True Then
                    ListBox1.Items.Clear()
                End If
                dataReader = command.ExecuteReader
                If dataReader.HasRows Then
                    While dataReader.Read()
                        ListBox1.Items.Add(dataReader.Item("serial").ToString)
                    End While
                End If
                dataReader.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub
    Private Sub textbox2_enter(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            Me.Size = New Size(756, 271)
            ListBox1.Visible = True
            Button3.Visible = True
            command.Connection = accessConn
            command.CommandText = "SELECT client FROM Licenses WHERE (client LIKE '%" & TextBox3.Text & "%')"
            command.CommandType = CommandType.Text
            Try
                If ListBox1.Visible = True Then
                    ListBox1.Items.Clear()
                End If
                dataReader = command.ExecuteReader
                If dataReader.HasRows Then
                    While dataReader.Read()
                        ListBox1.Items.Add(dataReader.Item("client").ToString)
                    End While
                End If
                dataReader.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub ListBox1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListBox1.MouseDoubleClick
        If ListBox1.SelectedItem = DBNull.Value.ToString Then
        Else
            command.Connection = accessConn
            command.CommandText = "SELECT serial, client, license, joined FROM licenses WHERE (client LIKE '%" & ListBox1.SelectedItem.ToString & "%') OR (serial LIKE '%" & ListBox1.SelectedItem & "%')"
            command.CommandType = CommandType.Text
            Try
                dataReader = command.ExecuteReader
                If dataReader.HasRows Then
                    dataReader.Read()
                    TextBox1.Text = dataReader(0)
                    serial = dataReader(0)
                    TextBox1.ReadOnly = True
                    TextBox3.Text = dataReader(1)
                    client = dataReader(1)
                    TextBox3.ReadOnly = True
                    TextBox2.Text = dataReader(2)
                    license = dataReader(2)
                    TextBox2.ReadOnly = True
                    TextBox4.Text = dataReader(3)
                    TextBox4.Visible = True
                    Label4.Visible = True
                    PictureBox1.Enabled = False
                    PictureBox2.Enabled = False
                    Me.Size = New Size(510, 271)
                End If
                dataReader.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ListBox1.SelectedItem = DBNull.Value.ToString Then
        Else
            If client = DBNull.Value.ToString Or serial.ToString = DBNull.Value.ToString Then
                MsgBox("Double-click on a record to select it", MsgBoxStyle.Information)
            Else
                command.Connection = accessConn
                command.CommandText = "DELETE FROM Licenses WHERE (client = '" & client & "') OR (serial =" & serial & ")"
                command.CommandType = CommandType.Text
                Try
                    If MsgBox("Are you sure?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                        command.ExecuteNonQuery()
                        MsgBox("Deleted successfully", MsgBoxStyle.Information)
                    End If
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
                Me.Size = New Size(510, 271)
                serial = Nothing
                license = Nothing
                client = Nothing
                Button3.Visible = False
                ListBox1.Visible = False
                TextBox1.ReadOnly = False
                TextBox2.ReadOnly = False
                TextBox3.ReadOnly = False
                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = Nothing
                TextBox4.Visible = False
                Label4.Visible = False
                PictureBox1.Enabled = True
                PictureBox2.Enabled = True
            End If
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Size = New Size(756, 271)
        ListBox1.Visible = True
        Button3.Visible = True
        command.Connection = accessConn
        command.CommandText = "SELECT serial FROM Licenses WHERE (serial LIKE '%" & TextBox1.Text & "%')"
        command.CommandType = CommandType.Text
        Try
            If ListBox1.Visible = True Then
                ListBox1.Items.Clear()
            End If
            dataReader = command.ExecuteReader
            If dataReader.HasRows Then
                While dataReader.Read()
                    ListBox1.Items.Add(dataReader.Item("serial").ToString)
                End While
            End If
            dataReader.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Size = New Size(756, 271)
        ListBox1.Visible = True
        Button3.Visible = True
        command.Connection = accessConn
        command.CommandText = "SELECT client FROM Licenses WHERE (client LIKE '%" & TextBox3.Text & "%')"
        command.CommandType = CommandType.Text
        Try
            If ListBox1.Visible = True Then
                ListBox1.Items.Clear()
            End If
            dataReader = command.ExecuteReader
            If dataReader.HasRows Then
                While dataReader.Read()
                    ListBox1.Items.Add(dataReader.Item("client").ToString)
                End While
            End If
            dataReader.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class

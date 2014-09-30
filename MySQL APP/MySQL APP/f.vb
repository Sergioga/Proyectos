Imports System.IO
Imports EDAPP.Crypto
Imports System.Math
Module f
    Public tr As MySql.Data.MySqlClient.MySqlTransaction
    Public mysqlConn As New MySql.Data.MySqlClient.MySqlConnection
    Public cmd As New MySql.Data.MySqlClient.MySqlCommand
    Public dr As MySql.Data.MySqlClient.MySqlDataReader
    Public lang As String
    Public isDebug As Boolean

    Public Function checkMysql(ByVal server As String, ByVal user As String, ByVal pass As String)
        Dim result As Integer
        Try
            If mysqlConn.State = ConnectionState.Open Then
                mysqlConn.Close()
            End If
            mysqlConn.ConnectionString = "server=" & server & "; uid=" & user & "; password=" & pass '' Change to something else
            mysqlConn.Open()
            cmd.Connection = mysqlConn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SHOW DATABASES LIKE 'appmysql'"
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                dr.Close()
                result = 0
            Else
                dr.Close()
                result = 1
            End If
        Catch ex As Exception
            If isDebug = True Then
                MsgBox(ex.ToString)
            End If
            result = 2
        End Try
        Return result
    End Function

    Public Function createMysql(ByVal server As String, ByVal user As String, ByVal pass As String)
        Dim mysqlfile1 As New FileInfo(My.Application.Info.DirectoryPath & "\mysqlStart0.sql")
        Dim mysqlfile2 As New FileInfo(My.Application.Info.DirectoryPath & "\mysqlStart1.sql")
        Dim mysql1 As String = mysqlfile1.OpenText.ReadToEnd
        Dim mysql2 As String = mysqlfile2.OpenText.ReadToEnd
        Dim serial As Int64 = random_gen()
        Dim state As Boolean
        ' Creamos la base de datos mysqlapp
        Try
            tr = mysqlConn.BeginTransaction
            cmd.Connection = mysqlConn
            cmd.Transaction = tr
            cmd.CommandText = mysql1
            cmd.ExecuteNonQuery()
            cmd.CommandText = "GRANT ALL PRIVILEGES ON appmysql.* TO " & user & "@" & server & " IDENTIFIED BY '" & pass & "'"
            cmd.ExecuteNonQuery()
            cmd.CommandText = mysql2
            cmd.ExecuteNonQuery()
            cmd.CommandText = "INSERT INTO appmysql.license VALUES (1,'" & Serial & "','0')"
            cmd.ExecuteNonQuery()
            tr.Commit()
            cmd.Dispose()
            mysqlConn.Close()
            state = True
        Catch ex As Exception
            tr.Rollback()
            state = False
            If isDebug = True Then
                MsgBox(ex.ToString)
            End If
        End Try
        Return state
    End Function
    Public Function checkUser(ByVal pass As String)
        Dim ok As Boolean
        If pass = "14DaNiTe0996" Then
            ok = True
        Else
            If Form1.radBtnEs.Checked = True Then
                MsgBox(My.Resources.strings_es.wrgPass)
            ElseIf Form1.radBtnEn.Checked = True Then
                MsgBox(My.Resources.strings_es.wrgPass)
            End If
            ok = False
        End If
        Return ok
    End Function
End Module

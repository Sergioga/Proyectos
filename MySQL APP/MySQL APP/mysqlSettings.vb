Public Class mysqlSettings
    'Public hola As String
    Private Sub mysqlSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If lang = "es" Then
            exitBtn.Text = My.Resources.strings_es.exitStr
            saveBtn.Text = My.Resources.strings_es.saveBtnStr
            Label1.Text = My.Resources.strings_es.dbServerStr
            Label2.Text = My.Resources.strings_es.dbUserStr
            Label3.Text = My.Resources.strings_es.dbPassStr
        ElseIf lang = "en" Then
            exitBtn.Text = My.Resources.strings_en.exitStr
            saveBtn.Text = My.Resources.strings_en.saveBtnStr
            Label1.Text = My.Resources.strings_en.dbServerStr
            Label2.Text = My.Resources.strings_en.dbUserStr
            Label3.Text = My.Resources.strings_en.dbPassStr
        End If
    End Sub

    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        If serverTxt.Text = DBNull.Value.ToString Or userTxt.Text = DBNull.Value.ToString Or passTxt.Text = DBNull.Value.ToString Then
            If lang = "es" Then
                MsgBox(My.Resources.strings_es.emptyStr, MsgBoxStyle.Exclamation)
            ElseIf lang = "en" Then
                MsgBox(My.Resources.strings_en.emptyStr, MsgBoxStyle.Exclamation)
            End If
        Else
            Dim ok As Integer = checkMysql(serverTxt.Text, userTxt.Text, passTxt.Text)
            If ok = 1 Then
                Dim state As Boolean = createMysql(serverTxt.Text, userTxt.Text, passTxt.Text)
                If state = True Then
                    If lang = "es" Then
                        MsgBox(My.Resources.strings_es.creDBStr, MsgBoxStyle.Information)
                        Form1.Show()
                        Me.Close()
                    ElseIf lang = "en" Then
                        MsgBox(My.Resources.strings_en.creDBStr, MsgBoxStyle.Information)
                        Form1.Show()
                        Me.Close()
                    End If
                Else
                    If lang = "es" Then
                        MsgBox(My.Resources.strings_es.wrgDBStr, MsgBoxStyle.Information)
                    ElseIf lang = "en" Then
                        MsgBox(My.Resources.strings_en.wrgDBStr, MsgBoxStyle.Information)
                    End If
                End If
            ElseIf ok = 0 Then
                secureCheck.Show()
            End If
        End If

        
    End Sub
End Class
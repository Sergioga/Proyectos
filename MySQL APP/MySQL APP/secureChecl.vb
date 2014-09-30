Public Class secureCheck

    Private Sub secureCheck_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If lang = "es" Then
            Label1.Text = My.Resources.strings_es.secStr
            Label3.Text = My.Resources.strings_es.passStr
            exitBtn.Text = My.Resources.strings_es.exitStr
            contBtn.Text = My.Resources.strings_es.contStr
        ElseIf lang = "en" Then
            Label1.Text = My.Resources.strings_en.secStr
            Label3.Text = My.Resources.strings_en.passStr
            exitBtn.Text = My.Resources.strings_en.exitStr
            contBtn.Text = My.Resources.strings_en.contStr
        End If
    End Sub

    Private Sub contBtn_Click(sender As Object, e As EventArgs) Handles contBtn.Click
        Dim ok As Boolean = checkUser(passTxt.Text)
        If ok = True Then
            Dim state As Boolean = createMysql(mysqlSettings.serverTxt.Text, mysqlSettings.userTxt.Text, mysqlSettings.passTxt.Text)
            If state = True Then
                If lang = "es" Then
                    MsgBox(My.Resources.strings_es.creDBStr, MsgBoxStyle.Information)
                    Me.Close()
                    Form1.Show()
                    mysqlSettings.Close()
                ElseIf lang = "en" Then
                    MsgBox(My.Resources.strings_en.creDBStr, MsgBoxStyle.Information)
                    Me.Close()
                    Form1.Show()
                    mysqlSettings.Close()
                End If
            Else
                If lang = "es" Then
                    MsgBox(My.Resources.strings_es.wrgDBStr, MsgBoxStyle.Information)
                ElseIf lang = "en" Then
                    MsgBox(My.Resources.strings_en.wrgDBStr, MsgBoxStyle.Information)
                End If
            End If
        Else
            If lang = "es" Then
                MsgBox(My.Resources.strings_es.badStr, MsgBoxStyle.Information)
            ElseIf lang = "en" Then
                MsgBox(My.Resources.strings_en.badStr, MsgBoxStyle.Information)
            End If
        End If
    End Sub

    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        Me.Close()
    End Sub
End Class
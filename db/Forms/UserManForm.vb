Public Class UserManForm

    Private Sub DataGridView1_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs)
        LoginNameDataGridViewTextBoxColumn.DefaultCellStyle.Tag = "TOUPPER"
        If ((e.CellStyle.Tag = "TOUPPER")) Then
            DirectCast(e.Control, TextBox).CharacterCasing = CharacterCasing.Upper
        Else
            DirectCast(e.Control, TextBox).CharacterCasing = CharacterCasing.Normal
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            LoginTableAdapter.Update(Db1SQLDataSet)
            LoginTableAdapter.ClearBeforeFill = True
            LoginTableAdapter.Fill(Db1SQLDataSet.login)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub UserManForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = My.Resources.strings_en.userManFormStr
        Button1.Text = My.Resources.strings_en.btnSaveChanStr
        Button2.Text = My.Resources.strings_en.btnBackStr
        chkBoxLevel.Text = My.Resources.strings_en.showUserLvlStr
        chkBoxPasswd.Text = My.Resources.strings_en.showPassChkStr
        grpBoxRights.Text = My.Resources.strings_en.lvlGrpStr
        Label1.Text = My.Resources.strings_en.lvl1Str
        Label2.Text = My.Resources.strings_en.lvl2Str
        Label3.Text = My.Resources.strings_en.lvl3Str
        Label4.Text = My.Resources.strings_en.lvl4Str
        Label5.Text = My.Resources.strings_en.lvl5Str
        UserIdDataGridViewTextBoxColumn.HeaderText = My.Resources.strings_en.idColStr
        UserNameDataGridViewTextBoxColumn.HeaderText = My.Resources.strings_en.userNameColStr
        PasswdDataGridViewTextBoxColumn.HeaderText = My.Resources.strings_en.passColStr
        LoginNameDataGridViewTextBoxColumn.HeaderText = My.Resources.strings_en.loginNameColStr
        SurnameDataGridViewTextBoxColumn.HeaderText = My.Resources.strings_en.surnameColStr
        LvlDataGridViewTextBoxColumn.HeaderText = My.Resources.strings_en.lvlColStr
        Me.LoginTableAdapter.ClearBeforeFill = True
        Me.LoginTableAdapter.Fill(Me.Db1SQLDataSet.login)
        Me.DataGridView1.Sort(UserIdDataGridViewTextBoxColumn, System.ComponentModel.ListSortDirection.Ascending)
        Me.UserIdDataGridViewTextBoxColumn.ReadOnly = True
        chkBoxLevel.CheckState = CheckState.Checked
        chkBoxPasswd.CheckState = CheckState.Unchecked
        If chkBoxLevel.Checked = True Then
            LvlDataGridViewTextBoxColumn.Visible = True
            grpBoxRights.Visible = True
        Else
            LvlDataGridViewTextBoxColumn.Visible = False
            grpBoxRights.Visible = False
        End If
    End Sub

    Private Sub chkBoxLevel_CheckedChanged_1(sender As Object, e As EventArgs) Handles chkBoxLevel.CheckedChanged
        If chkBoxLevel.Checked = True Then
            LvlDataGridViewTextBoxColumn.Visible = True
            grpBoxRights.Visible = True
        Else
            LvlDataGridViewTextBoxColumn.Visible = False
            grpBoxRights.Visible = False
        End If
    End Sub

    Private Sub chkBoxPasswd_CheckedChanged_1(sender As Object, e As EventArgs) Handles chkBoxPasswd.CheckedChanged
        If chkBoxPasswd.Checked = True Then
            PasswdDataGridViewTextBoxColumn.Visible = True
        Else
            PasswdDataGridViewTextBoxColumn.Visible = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

End Class
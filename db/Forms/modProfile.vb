Public Class modProfile

    Private Sub modProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = My.Resources.strings_en.modProFormStr
        btnBack.Text = My.Resources.strings_en.btnBackStr
        btnSubmit.Text = My.Resources.strings_en.btnSubChgStr
        lblAddress.Text = My.Resources.strings_en.addressStr
        lblActu.Text = My.Resources.strings_en.actStr
        lblCity.Text = My.Resources.strings_en.cityStr
        lblCountry.Text = My.Resources.strings_en.counStr
        lblDateOB.Text = My.Resources.strings_en.dateOBStr
        lblName.Text = My.Resources.strings_en.nameStr
        lblSurname.Text = My.Resources.strings_en.surnameStr
        lvlMobPhone.Text = My.Resources.strings_en.mobPhoneStr
        lblPhone.Text = My.Resources.strings_en.phoneStr
        Label1.Text = My.Resources.strings_en.secQStr
        lblSecretA.Text = My.Resources.strings_en.secAStr
        lblNew.Text = My.Resources.strings_en.newStr
        Dim ds As New DataSet
        Dim strSQL As String = "SELECT * FROM secretQ"
        Dim adapter As New SqlClient.SqlDataAdapter(strSQL, conn)
        ds.Tables.Add("Questions")
        adapter.Fill(ds.Tables("Questions"))
        ComboSecret.DataSource = ds.Tables("Questions")
        ComboSecret.ValueMember = "questionID"
        ComboSecret.DisplayMember = "question"
        lblProName.Text = userName
        lblProSurname.Text = surname
        get_profile_ModProfile()
        dateDateOB.Checked = False
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        lblSurname.Text = surname + ", " + userName + "         Permission Level: " + lvl
        Me.Close()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        submit_changes()
        If ComboSecret.SelectedText = lblPro6.Text Then
        Else
            Try
                cmd.Connection = conn
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "UPDATE userProfiles SET secretQ=" + ComboSecret.SelectedValue.ToString
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

        End If
        get_profile_ModProfile()
        lblProName.Text = userName
        lblProSurname.Text = surname
    End Sub
End Class
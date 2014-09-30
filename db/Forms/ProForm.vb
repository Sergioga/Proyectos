Public Class ProForm

    Private Sub ProForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        get_profile_Profile()
        lblProName.Text = userName
        lblProSurname.Text = surname
    End Sub

    Private Sub ProForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = My.Resources.strings_en.proFormStr
        btnClose.Text = My.Resources.strings_en.btnClose
        btnModPro.Text = My.Resources.strings_en.btnModPro
        Label10.Text = My.Resources.strings_en.addressStr
        Label11.Text = My.Resources.strings_en.surnameStr
        Label13.Text = My.Resources.strings_en.counStr
        Label14.Text = My.Resources.strings_en.cityStr
        Label15.Text = My.Resources.strings_en.mobPhoneStr
        Label16.Text = My.Resources.strings_en.dateOBStr
        Label17.Text = My.Resources.strings_en.joinStr
        Label8.Text = My.Resources.strings_en.nameStr
        Label9.Text = My.Resources.strings_en.phoneStr
        lblQuestion.Text = My.Resources.strings_en.secQStr
        lblAwnser.Text = My.Resources.strings_en.secAStr
        chkBoxContact.Text = My.Resources.strings_en.showContInfStr
        chkBoxRecovery.Text = My.Resources.strings_en.showPassStr
        grpBoxContact.Text = My.Resources.strings_en.contInfStr
        grpBoxPasswd.Text = My.Resources.strings_en.passRecQStr
        grpBoxPro.Text = My.Resources.strings_en.pro
        'If path <> "" Then
        picBoxPro.ImageLocation = path
        'End If
        get_profile_Profile()
        lblProName.Text = userName
        lblProSurname.Text = surname
        If grpBoxPro.Visible = False And chkBoxContact.Visible = False And chkBoxRecovery.Visible = False And btnModPro.Visible = False Then
            'userMan_close()
            userProfile_open()
        Else
            userProfile_close()
        End If
    End Sub

    Private Sub chkBoxContact_CheckedChanged(sender As Object, e As EventArgs) Handles chkBoxContact.CheckedChanged
        If chkBoxContact.Checked = True Then
            grpBoxContact.Visible = True
        Else
            grpBoxContact.Visible = False
        End If
    End Sub

    Private Sub chkBoxRecovery_CheckedChanged(sender As Object, e As EventArgs) Handles chkBoxRecovery.CheckedChanged
        If chkBoxRecovery.Checked = True Then
            grpBoxPasswd.Visible = True
        Else
            grpBoxPasswd.Visible = False
        End If
    End Sub

    Private Sub btnModPro_Click(sender As Object, e As EventArgs) Handles btnModPro.Click
        modProfile.Show()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
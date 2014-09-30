Public Class form2
    Private Sub form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Impresoras_inst As String
        ' Buscar impresoras compartidas
        For Each Impresoras_inst In
            System.Drawing.Printing.PrinterSettings.InstalledPrinters
            Me.cmbComp.Items.Add(Impresoras_inst)
            Me.cmbDes.Items.Add(Impresoras_inst)
        Next Impresoras_inst
        'GetPrinters()
    End Sub
    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        desmapear()
        Me.Close()
    End Sub
    Private Sub btn_continuar_Click(sender As Object, e As EventArgs) Handles btn_continuar.Click
        mapear_impresora(txtRecurso.Text)
        If abrir_Programa = True Then
            start_nvlogo()
        End If
    End Sub

    Private Sub btn_compartir_Click(sender As Object, e As EventArgs) Handles btn_compartir.Click
        If txtNombreCom.Text <> DBNull.Value.ToString Then
            nombre_impresoraP = cmbComp.SelectedItem.ToString
            compartir_impresora(cmbComp.SelectedItem.ToString, txtNombreCom.Text.ToString)
            'GetPrinters()
        Else
            MsgBox("Debes rellenar todos los campos", MsgBoxStyle.OkOnly, "Campos vacios")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Shell("nvlogo.exe")
        'start_nvlogo()

    End Sub

    Private Sub btn_Descom_Click(sender As Object, e As EventArgs) Handles btn_Descom.Click
        nombre_impresoraP = cmbDes.SelectedItem.ToString
        descompartir(cmbDes.SelectedItem.ToString)
        'GetPrinters()
    End Sub
End Class
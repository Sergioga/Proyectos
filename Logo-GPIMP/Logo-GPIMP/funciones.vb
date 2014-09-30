Module funciones

    Public nombre_impresoraP As String
    Public nombre_nuevoRecursoP As String
    Public abrir_Programa As Boolean = False
    'Public Sub GetPrinters()
    'Dim c As New Process
    'Dim i As Integer = 0
    'Dim h As Integer = 0
    'Dim cOutput As String
    'Dim cArray(0) As String
    'Dim cError As String
    '    c.StartInfo.UseShellExecute = False
    '    c.StartInfo.RedirectStandardError = True
    '    c.StartInfo.RedirectStandardOutput = True
    '    c.StartInfo.FileName = "cmd"
    '    c.StartInfo.Arguments = "/C cscript prnmngr.vbs -l -s localhost"
    '    c.Start()
    '    Do Until c.StandardOutput.EndOfStream = True
    '        cOutput = c.StandardOutput.ReadLine
    '        If cOutput.Contains("Printer name") = True Or cOutput.Contains("Share name") = True Then
    '            ReDim Preserve cArray(h)
    '            cArray(h) = cOutput
    '            h += 1
    '        End If
    '        i += 1
    '    Loop
    '    For f As Integer = 0 To cArray.Length - 1
    '        If f = 1 Or f = 3 Or f = 5 Or f = 7 Or f = 9 Or f = 11 Or f = 13 Or f = 15 Or f = 17 Or f = 19 Or f = 21 Or f = 23 Then
    '            If cArray(f).Length = 11 Then
    '            Else
    '                form2.cmbBox1.Items.Add(cArray(f).Remove(0, 11))
    '            End If
    '        End If
    '    Next
    '    cError = c.StandardError.ReadToEnd
    ''MsgBox(cOutput)
    ''MsgBox(cError)
    ''End Sub

    Public Sub compartir_impresora(ByVal nombre_impresora As String, ByVal nombre_nuevoRecurso As String)
        Dim b As New Process
        Dim bOutput As String
        Dim bError As String
        nombre_impresoraP = nombre_impresora
        nombre_nuevoRecursoP = nombre_nuevoRecurso
        b.StartInfo.UseShellExecute = False
        b.StartInfo.RedirectStandardError = True
        b.StartInfo.RedirectStandardOutput = True
        b.StartInfo.FileName = "cmd"
        b.StartInfo.Arguments = "/C cscript prncnfg.vbs -t -p """ + nombre_impresora + """ +shared -h """ + nombre_nuevoRecurso + """"
        b.Start()
        bOutput = b.StandardOutput.ReadToEnd()
        bError = b.StandardError.ReadToEnd()
        form2.Focus()
        If bOutput.Contains("Configured printer") Then
            MsgBox("La impresora """ + nombre_impresora + """ se ha compartido correctamente con el nombre """ + nombre_nuevoRecurso + """")
        ElseIf bOutput.Contains("Unable to get") Then
            MsgBox("La impresora """ + nombre_impresora + """ no existe en el sistema")
        Else
            MsgBox(bError + "Algo inexperado, avisar a alguien...")
        End If
        'MsgBox(bOutput)
        'MsgBox(bError)
    End Sub
    Public Sub mapear_impresora(ByVal printer_name As String)
        Dim computer_name As String = My.Computer.Name.ToString
        Dim a As New Process
        Dim errorOutput As String
        Dim output As String
        'MsgBox("NET USE LPT1 \\" + computer_name + "\" + printer_name)
        a.StartInfo.UseShellExecute = False
        a.StartInfo.RedirectStandardOutput = True
        a.StartInfo.RedirectStandardError = True
        a.StartInfo.FileName = "cmd"
        a.StartInfo.Arguments = "/C NET USE LPT1 ""\\" + computer_name + "\" + printer_name + """"
        a.Start()
        output = a.StandardOutput.ReadLine()
        errorOutput = a.StandardError.ReadToEnd()
        form2.Focus()
        If errorOutput.Contains("error 66") Then
            MsgBox("El nombre introducido como recurso compartido no es correcto")
        ElseIf errorOutput.Contains("Error de sistema 67") Then
            MsgBox("No se encuentra el recurso compartido, asegurate de que la impresora este compartida correctamente")
        ElseIf output.Contains("successfully") Or output.Contains("correctamente") Then
            abrir_Programa = True
            MsgBox("El comando se ha completado correctamente")
        ElseIf errorOutput.Contains("error 85") Then
            MsgBox("El puerto ya esta en uso")
        Else
            MsgBox(errorOutput + "Algo inexperado, avisar a alguien...")
        End If
    End Sub
    Public Sub start_nvlogo()
        Shell("nvlogo.exe")
        'Dim p As New Process
        'p.StartInfo.FileName = "cmd"
        'p.StartInfo.Arguments = "/c nvlogo.exe"
        'p.StartInfo.UseShellExecute = False
        'p.StartInfo.RedirectStandardError = True
        'p.StartInfo.RedirectStandardOutput = True
        'p.Start()
        'MsgBox(p.StandardError.ReadToEnd.ToString)
        'MsgBox(p.StandardOutput.ReadToEnd.ToString)
        ' p.WaitForExit(10000)
        'If p.HasExited = True Then
        'form2.Focus()
        'End If
    End Sub
    Public Sub desmapear()
        Dim a As New Process
        Dim errorOutput As String
        Dim output As String
        Dim question As MsgBoxResult
        question = MsgBox("¿Desea desconectar el recurso compartido LPT1? (Recomendado, si se ha finalizado la instalación del logo)", MsgBoxStyle.YesNo, "Desmapear")
        If question = MsgBoxResult.Yes Then
            'MsgBox("NET USE LPT1 \\" + computer_name + "\" + printer_name)
            a.StartInfo.UseShellExecute = False
            a.StartInfo.RedirectStandardOutput = True
            a.StartInfo.RedirectStandardError = True
            a.StartInfo.FileName = "cmd"
            a.StartInfo.Arguments = "/C NET USE LPT1 /delete"
            a.Start()
            output = a.StandardOutput.ReadLine()
            errorOutput = a.StandardError.ReadToEnd()
            form2.Focus()
            If errorOutput.Contains("connection could not be found") Or errorOutput.Contains("No se ha encontrado") Then
                MsgBox("No se ha encontrado ninguna impresora mapeada al puerto LPT1...")
            ElseIf output.Contains("successfully") Or output.Contains("correctamente") Or output.Contains("eliminado") Then
                MsgBox("La conexion se ha elimidado correctamente")
            Else
                MsgBox(errorOutput + "Algo inexperado, avisar a alguien...")
            End If
            'MsgBox(errorOutput)
            'MsgBox(output)
        End If

    End Sub
    Public Sub descompartir(ByRef nombre_impresora As String)
        'Dim question As MsgBoxResult
        Dim b As New Process
        Dim bOutput As String
        Dim bError As String
        'question = MsgBox("¿Desea des-compartir el recurso compartido creado? (Recomendado, si la impresora no va a utilizarse en red)", MsgBoxStyle.YesNo, "Des-compartir")
        ' If question = MsgBoxResult.Yes Then
        b.StartInfo.UseShellExecute = False
        b.StartInfo.RedirectStandardError = True
        b.StartInfo.RedirectStandardOutput = True
        b.StartInfo.FileName = "cmd"
        b.StartInfo.Arguments = "/C cscript prncnfg.vbs -t -p """ + nombre_impresora + """ -shared"
        b.Start()
        bOutput = b.StandardOutput.ReadToEnd()
        bError = b.StandardError.ReadToEnd()
        form2.Focus()
        If bOutput.Contains("Examples:") Then
            MsgBox("No has compartido la impresora utilizando este programa, por favor, des-compartela manualmente")
        ElseIf bOutput.Contains("Configured pr") Then
            MsgBox("La impresora """ + nombre_impresora + """ con nombre compartido """ + nombre_nuevoRecursoP + """ se ha des-compartido correctamente")
        ElseIf bOutput.Contains("parse command") Then
            MsgBox("No has compartido la impresora utilizando este programa")
        Else
            MsgBox(bError + "Algo inexperado, avisar a alguien...")
        End If
        'MsgBox(bOutput)
        'MsgBox(bError)
        'End If
    End Sub
End Module

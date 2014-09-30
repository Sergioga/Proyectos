<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form2))
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.btn_compartir = New System.Windows.Forms.Button()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.btn_continuar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbComp = New System.Windows.Forms.ComboBox()
        Me.cmbDes = New System.Windows.Forms.ComboBox()
        Me.btn_Descom = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombreCom = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRecurso = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(347, 344)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(127, 44)
        Me.btn_salir.TabIndex = 3
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'lbl1
        '
        Me.lbl1.ForeColor = System.Drawing.Color.Red
        Me.lbl1.Location = New System.Drawing.Point(8, 96)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(261, 33)
        Me.lbl1.TabIndex = 1
        Me.lbl1.Text = "Si la impresora no esta compartida, seleccionala aqui e introduce el nombre de re" & _
    "d ha asignar:"
        '
        'btn_compartir
        '
        Me.btn_compartir.Location = New System.Drawing.Point(695, 88)
        Me.btn_compartir.Name = "btn_compartir"
        Me.btn_compartir.Size = New System.Drawing.Size(114, 49)
        Me.btn_compartir.TabIndex = 0
        Me.btn_compartir.Text = "Compartir"
        Me.btn_compartir.UseVisualStyleBackColor = True
        '
        'lbl2
        '
        Me.lbl2.AutoEllipsis = True
        Me.lbl2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl2.Location = New System.Drawing.Point(8, 267)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(240, 39)
        Me.lbl2.TabIndex = 4
        Me.lbl2.Text = "Si ya has compartido la impresora, introduce su nombre compartido y pulsa en ""Con" & _
    "tinuar"":"
        '
        'btn_continuar
        '
        Me.btn_continuar.Location = New System.Drawing.Point(604, 258)
        Me.btn_continuar.Name = "btn_continuar"
        Me.btn_continuar.Size = New System.Drawing.Size(205, 48)
        Me.btn_continuar.TabIndex = 2
        Me.btn_continuar.Text = "Continuar"
        Me.btn_continuar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label1.Location = New System.Drawing.Point(284, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(293, 47)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "¡Para poder utilizar este programa, la impresora en concreto debe estar compartid" & _
    "a!"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label2.Location = New System.Drawing.Point(8, 181)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(261, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Selecciona el nombre de la impresora a des-compartir:"
        '
        'cmbComp
        '
        Me.cmbComp.FormattingEnabled = True
        Me.cmbComp.Location = New System.Drawing.Point(275, 103)
        Me.cmbComp.Name = "cmbComp"
        Me.cmbComp.Size = New System.Drawing.Size(211, 21)
        Me.cmbComp.TabIndex = 10
        '
        'cmbDes
        '
        Me.cmbDes.FormattingEnabled = True
        Me.cmbDes.Location = New System.Drawing.Point(331, 181)
        Me.cmbDes.Name = "cmbDes"
        Me.cmbDes.Size = New System.Drawing.Size(211, 21)
        Me.cmbDes.TabIndex = 11
        '
        'btn_Descom
        '
        Me.btn_Descom.Location = New System.Drawing.Point(604, 166)
        Me.btn_Descom.Name = "btn_Descom"
        Me.btn_Descom.Size = New System.Drawing.Size(205, 48)
        Me.btn_Descom.TabIndex = 12
        Me.btn_Descom.Text = "Des-compartir"
        Me.btn_Descom.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(338, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Impresoras:"
        '
        'txtNombreCom
        '
        Me.txtNombreCom.Location = New System.Drawing.Point(516, 102)
        Me.txtNombreCom.Name = "txtNombreCom"
        Me.txtNombreCom.Size = New System.Drawing.Size(149, 20)
        Me.txtNombreCom.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(540, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Nombre compartido:"
        '
        'txtRecurso
        '
        Me.txtRecurso.Location = New System.Drawing.Point(331, 269)
        Me.txtRecurso.Name = "txtRecurso"
        Me.txtRecurso.Size = New System.Drawing.Size(211, 20)
        Me.txtRecurso.TabIndex = 16
        '
        'form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(821, 409)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtRecurso)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNombreCom)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn_Descom)
        Me.Controls.Add(Me.cmbDes)
        Me.Controls.Add(Me.cmbComp)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_continuar)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.btn_compartir)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GP-Impresora"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents btn_compartir As System.Windows.Forms.Button
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents btn_continuar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbComp As System.Windows.Forms.ComboBox
    Friend WithEvents cmbDes As System.Windows.Forms.ComboBox
    Friend WithEvents btn_Descom As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNombreCom As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtRecurso As System.Windows.Forms.TextBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form))
        Me.rutaBDTxt = New System.Windows.Forms.TextBox()
        Me.examBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.warnLbl = New System.Windows.Forms.Label()
        Me.compBtn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.accessIcon = New System.Windows.Forms.PictureBox()
        Me.winLbl = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.accessIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rutaBDTxt
        '
        Me.rutaBDTxt.Location = New System.Drawing.Point(12, 188)
        Me.rutaBDTxt.Name = "rutaBDTxt"
        Me.rutaBDTxt.ReadOnly = True
        Me.rutaBDTxt.Size = New System.Drawing.Size(249, 20)
        Me.rutaBDTxt.TabIndex = 0
        '
        'examBtn
        '
        Me.examBtn.Location = New System.Drawing.Point(275, 186)
        Me.examBtn.Name = "examBtn"
        Me.examBtn.Size = New System.Drawing.Size(94, 23)
        Me.examBtn.TabIndex = 1
        Me.examBtn.Text = "Examinar"
        Me.examBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 169)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Ruta a la BBDD:"
        '
        'warnLbl
        '
        Me.warnLbl.AutoEllipsis = True
        Me.warnLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.warnLbl.ForeColor = System.Drawing.Color.DarkRed
        Me.warnLbl.Location = New System.Drawing.Point(10, 214)
        Me.warnLbl.Name = "warnLbl"
        Me.warnLbl.Size = New System.Drawing.Size(360, 76)
        Me.warnLbl.TabIndex = 3
        Me.warnLbl.Text = "La base de datos sigue abierta, por favor cierra todos los Winvet abiertos, prueb" & _
    "a otra vez y mantenlos cerrados hasta que se complete la operacion."
        Me.warnLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.warnLbl.Visible = False
        '
        'compBtn
        '
        Me.compBtn.Location = New System.Drawing.Point(115, 238)
        Me.compBtn.Name = "compBtn"
        Me.compBtn.Size = New System.Drawing.Size(146, 52)
        Me.compBtn.TabIndex = 4
        Me.compBtn.Text = "Compactar"
        Me.compBtn.UseVisualStyleBackColor = True
        Me.compBtn.Visible = False
        '
        'Panel1
        '
        Me.Panel1.AllowDrop = True
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.winLbl)
        Me.Panel1.Controls.Add(Me.accessIcon)
        Me.Panel1.Location = New System.Drawing.Point(15, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(354, 124)
        Me.Panel1.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label2.Location = New System.Drawing.Point(41, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(273, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "¡Arrastra y suelta aqui la BBDD de Winvet!"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label3.Location = New System.Drawing.Point(113, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(155, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "¡O seleccionala aqui abajo!"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'accessIcon
        '
        Me.accessIcon.Image = CType(resources.GetObject("accessIcon.Image"), System.Drawing.Image)
        Me.accessIcon.Location = New System.Drawing.Point(-8, 0)
        Me.accessIcon.Name = "accessIcon"
        Me.accessIcon.Size = New System.Drawing.Size(128, 128)
        Me.accessIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.accessIcon.TabIndex = 7
        Me.accessIcon.TabStop = False
        Me.accessIcon.Visible = False
        '
        'winLbl
        '
        Me.winLbl.AutoEllipsis = True
        Me.winLbl.Location = New System.Drawing.Point(120, 16)
        Me.winLbl.Name = "winLbl"
        Me.winLbl.Size = New System.Drawing.Size(235, 96)
        Me.winLbl.TabIndex = 8
        Me.winLbl.Text = "C:\Winvet\Winvet.mdb"
        Me.winLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.winLbl.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(330, 216)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(381, 257)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.compBtn)
        Me.Controls.Add(Me.warnLbl)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.examBtn)
        Me.Controls.Add(Me.rutaBDTxt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "form"
        Me.Text = "Compact & Repair"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.accessIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rutaBDTxt As System.Windows.Forms.TextBox
    Friend WithEvents examBtn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents warnLbl As System.Windows.Forms.Label
    Friend WithEvents compBtn As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents accessIcon As System.Windows.Forms.PictureBox
    Friend WithEvents winLbl As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class

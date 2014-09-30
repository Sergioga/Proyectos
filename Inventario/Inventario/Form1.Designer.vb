<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inventarioForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(inventarioForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.OpcionesBox = New System.Windows.Forms.PictureBox()
        Me.SerialBox = New System.Windows.Forms.PictureBox()
        Me.ReportsBox = New System.Windows.Forms.PictureBox()
        Me.ArticulosBox = New System.Windows.Forms.PictureBox()
        Me.SalirMainBtn = New System.Windows.Forms.Button()
        Me.SesionBtn = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.salirBtn = New System.Windows.Forms.Button()
        Me.logBtn = New System.Windows.Forms.Button()
        Me.passTxt = New System.Windows.Forms.TextBox()
        Me.userTxt = New System.Windows.Forms.TextBox()
        Me.passLbl = New System.Windows.Forms.Label()
        Me.userLbl = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.OpcionesBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SerialBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportsBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticulosBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SlateBlue
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(662, 561)
        Me.Panel1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.OpcionesBox)
        Me.Panel3.Controls.Add(Me.SerialBox)
        Me.Panel3.Controls.Add(Me.ReportsBox)
        Me.Panel3.Controls.Add(Me.ArticulosBox)
        Me.Panel3.Controls.Add(Me.SalirMainBtn)
        Me.Panel3.Controls.Add(Me.SesionBtn)
        Me.Panel3.Location = New System.Drawing.Point(-1, -1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(664, 562)
        Me.Panel3.TabIndex = 3
        Me.Panel3.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkRed
        Me.Label5.Location = New System.Drawing.Point(52, 510)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Numeros de serie"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(366, 510)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Opciones"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label3.Location = New System.Drawing.Point(369, 237)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Informes"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.Location = New System.Drawing.Point(81, 237)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Artículos"
        '
        'OpcionesBox
        '
        Me.OpcionesBox.Location = New System.Drawing.Point(300, 300)
        Me.OpcionesBox.Name = "OpcionesBox"
        Me.OpcionesBox.Size = New System.Drawing.Size(200, 200)
        Me.OpcionesBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.OpcionesBox.TabIndex = 5
        Me.OpcionesBox.TabStop = False
        '
        'SerialBox
        '
        Me.SerialBox.Location = New System.Drawing.Point(12, 300)
        Me.SerialBox.Name = "SerialBox"
        Me.SerialBox.Size = New System.Drawing.Size(200, 200)
        Me.SerialBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SerialBox.TabIndex = 4
        Me.SerialBox.TabStop = False
        '
        'ReportsBox
        '
        Me.ReportsBox.Location = New System.Drawing.Point(300, 24)
        Me.ReportsBox.Name = "ReportsBox"
        Me.ReportsBox.Size = New System.Drawing.Size(200, 200)
        Me.ReportsBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ReportsBox.TabIndex = 3
        Me.ReportsBox.TabStop = False
        '
        'ArticulosBox
        '
        Me.ArticulosBox.Location = New System.Drawing.Point(12, 24)
        Me.ArticulosBox.Name = "ArticulosBox"
        Me.ArticulosBox.Size = New System.Drawing.Size(200, 200)
        Me.ArticulosBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ArticulosBox.TabIndex = 2
        Me.ArticulosBox.TabStop = False
        '
        'SalirMainBtn
        '
        Me.SalirMainBtn.Location = New System.Drawing.Point(547, 513)
        Me.SalirMainBtn.Name = "SalirMainBtn"
        Me.SalirMainBtn.Size = New System.Drawing.Size(102, 36)
        Me.SalirMainBtn.TabIndex = 1
        Me.SalirMainBtn.Text = "Salir"
        Me.SalirMainBtn.UseVisualStyleBackColor = True
        '
        'SesionBtn
        '
        Me.SesionBtn.Location = New System.Drawing.Point(547, 13)
        Me.SesionBtn.Name = "SesionBtn"
        Me.SesionBtn.Size = New System.Drawing.Size(102, 36)
        Me.SesionBtn.TabIndex = 0
        Me.SesionBtn.Text = "Cerrar Sesion"
        Me.SesionBtn.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.salirBtn)
        Me.Panel2.Controls.Add(Me.logBtn)
        Me.Panel2.Controls.Add(Me.passTxt)
        Me.Panel2.Controls.Add(Me.userTxt)
        Me.Panel2.Controls.Add(Me.passLbl)
        Me.Panel2.Controls.Add(Me.userLbl)
        Me.Panel2.Location = New System.Drawing.Point(142, 177)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(378, 208)
        Me.Panel2.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(162, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Usuario o contraseña incorrectos"
        Me.Label1.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(15, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'salirBtn
        '
        Me.salirBtn.Location = New System.Drawing.Point(47, 136)
        Me.salirBtn.Name = "salirBtn"
        Me.salirBtn.Size = New System.Drawing.Size(93, 37)
        Me.salirBtn.TabIndex = 0
        Me.salirBtn.Text = "Salir"
        Me.salirBtn.UseVisualStyleBackColor = True
        '
        'logBtn
        '
        Me.logBtn.Location = New System.Drawing.Point(221, 136)
        Me.logBtn.Name = "logBtn"
        Me.logBtn.Size = New System.Drawing.Size(90, 37)
        Me.logBtn.TabIndex = 3
        Me.logBtn.Text = "Identificarse"
        Me.logBtn.UseVisualStyleBackColor = True
        '
        'passTxt
        '
        Me.passTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passTxt.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.passTxt.Location = New System.Drawing.Point(242, 60)
        Me.passTxt.Name = "passTxt"
        Me.passTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.passTxt.Size = New System.Drawing.Size(100, 21)
        Me.passTxt.TabIndex = 2
        Me.passTxt.Text = "Contraseña"
        '
        'userTxt
        '
        Me.userTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userTxt.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.userTxt.Location = New System.Drawing.Point(242, 21)
        Me.userTxt.Name = "userTxt"
        Me.userTxt.Size = New System.Drawing.Size(100, 21)
        Me.userTxt.TabIndex = 1
        Me.userTxt.Text = "Usuario"
        '
        'passLbl
        '
        Me.passLbl.AutoSize = True
        Me.passLbl.Location = New System.Drawing.Point(142, 65)
        Me.passLbl.Name = "passLbl"
        Me.passLbl.Size = New System.Drawing.Size(64, 13)
        Me.passLbl.TabIndex = 1
        Me.passLbl.Text = "Contraseña:"
        '
        'userLbl
        '
        Me.userLbl.AutoSize = True
        Me.userLbl.Location = New System.Drawing.Point(142, 26)
        Me.userLbl.Name = "userLbl"
        Me.userLbl.Size = New System.Drawing.Size(46, 13)
        Me.userLbl.TabIndex = 0
        Me.userLbl.Text = "Usuario:"
        '
        'inventarioForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 561)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "inventarioForm"
        Me.Text = "Inventario"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.OpcionesBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SerialBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportsBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticulosBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents salirBtn As System.Windows.Forms.Button
    Friend WithEvents logBtn As System.Windows.Forms.Button
    Friend WithEvents passTxt As System.Windows.Forms.TextBox
    Friend WithEvents userTxt As System.Windows.Forms.TextBox
    Friend WithEvents passLbl As System.Windows.Forms.Label
    Friend WithEvents userLbl As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents OpcionesBox As System.Windows.Forms.PictureBox
    Friend WithEvents SerialBox As System.Windows.Forms.PictureBox
    Friend WithEvents ReportsBox As System.Windows.Forms.PictureBox
    Friend WithEvents ArticulosBox As System.Windows.Forms.PictureBox
    Friend WithEvents SalirMainBtn As System.Windows.Forms.Button
    Friend WithEvents SesionBtn As System.Windows.Forms.Button

End Class

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form2))
        Me.ok1 = New System.Windows.Forms.PictureBox()
        Me.ok4 = New System.Windows.Forms.PictureBox()
        Me.ok3 = New System.Windows.Forms.PictureBox()
        Me.ok2 = New System.Windows.Forms.PictureBox()
        Me.userTxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.passTxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.serverTxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rutaWinvetBD = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.confBtn = New System.Windows.Forms.Button()
        Me.salirBtn = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.ok1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ok4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ok3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ok2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ok1
        '
        Me.ok1.Image = CType(resources.GetObject("ok1.Image"), System.Drawing.Image)
        Me.ok1.Location = New System.Drawing.Point(289, 236)
        Me.ok1.Name = "ok1"
        Me.ok1.Size = New System.Drawing.Size(18, 19)
        Me.ok1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ok1.TabIndex = 42
        Me.ok1.TabStop = False
        Me.ok1.Visible = False
        '
        'ok4
        '
        Me.ok4.Image = CType(resources.GetObject("ok4.Image"), System.Drawing.Image)
        Me.ok4.Location = New System.Drawing.Point(289, 359)
        Me.ok4.Name = "ok4"
        Me.ok4.Size = New System.Drawing.Size(18, 19)
        Me.ok4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ok4.TabIndex = 41
        Me.ok4.TabStop = False
        Me.ok4.Visible = False
        '
        'ok3
        '
        Me.ok3.Image = CType(resources.GetObject("ok3.Image"), System.Drawing.Image)
        Me.ok3.Location = New System.Drawing.Point(157, 359)
        Me.ok3.Name = "ok3"
        Me.ok3.Size = New System.Drawing.Size(18, 19)
        Me.ok3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ok3.TabIndex = 40
        Me.ok3.TabStop = False
        Me.ok3.Visible = False
        '
        'ok2
        '
        Me.ok2.Image = CType(resources.GetObject("ok2.Image"), System.Drawing.Image)
        Me.ok2.Location = New System.Drawing.Point(289, 294)
        Me.ok2.Name = "ok2"
        Me.ok2.Size = New System.Drawing.Size(18, 19)
        Me.ok2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ok2.TabIndex = 39
        Me.ok2.TabStop = False
        Me.ok2.Visible = False
        '
        'userTxt
        '
        Me.userTxt.Location = New System.Drawing.Point(52, 358)
        Me.userTxt.Name = "userTxt"
        Me.userTxt.ReadOnly = True
        Me.userTxt.Size = New System.Drawing.Size(100, 20)
        Me.userTxt.TabIndex = 38
        Me.userTxt.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(81, 340)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 15)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Usuario:"
        '
        'passTxt
        '
        Me.passTxt.Location = New System.Drawing.Point(183, 357)
        Me.passTxt.Name = "passTxt"
        Me.passTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(43)
        Me.passTxt.ReadOnly = True
        Me.passTxt.Size = New System.Drawing.Size(100, 20)
        Me.passTxt.TabIndex = 36
        Me.passTxt.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(195, 339)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 15)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Contraseña:"
        '
        'serverTxt
        '
        Me.serverTxt.Location = New System.Drawing.Point(52, 293)
        Me.serverTxt.Name = "serverTxt"
        Me.serverTxt.ReadOnly = True
        Me.serverTxt.Size = New System.Drawing.Size(231, 20)
        Me.serverTxt.TabIndex = 34
        Me.serverTxt.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(125, 273)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 15)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Servidor FTP:"
        '
        'rutaWinvetBD
        '
        Me.rutaWinvetBD.Location = New System.Drawing.Point(52, 236)
        Me.rutaWinvetBD.Name = "rutaWinvetBD"
        Me.rutaWinvetBD.ReadOnly = True
        Me.rutaWinvetBD.Size = New System.Drawing.Size(231, 20)
        Me.rutaWinvetBD.TabIndex = 32
        Me.rutaWinvetBD.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(95, 218)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 15)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Ruta a la BBDD de Winvet:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WinvetRemoteBackup.My.Resources.Resources.logo1
        Me.PictureBox1.Location = New System.Drawing.Point(113, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(133, 120)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 43
        Me.PictureBox1.TabStop = False
        '
        'confBtn
        '
        Me.confBtn.Location = New System.Drawing.Point(54, 398)
        Me.confBtn.Name = "confBtn"
        Me.confBtn.Size = New System.Drawing.Size(75, 23)
        Me.confBtn.TabIndex = 0
        Me.confBtn.Text = "Configurar"
        Me.confBtn.UseVisualStyleBackColor = True
        '
        'salirBtn
        '
        Me.salirBtn.Location = New System.Drawing.Point(232, 398)
        Me.salirBtn.Name = "salirBtn"
        Me.salirBtn.Size = New System.Drawing.Size(75, 23)
        Me.salirBtn.TabIndex = 1
        Me.salirBtn.Text = "Salir"
        Me.salirBtn.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 13)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Subiendo datos..."
        Me.Label5.Visible = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(15, 166)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(332, 23)
        Me.ProgressBar1.TabIndex = 45
        Me.ProgressBar1.Visible = False
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(84, 168)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(190, 16)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Copiando la base de datos..."
        Me.Label6.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(71, 170)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(217, 16)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "Compactando la base de datos..."
        Me.Label7.Visible = False
        '
        'Timer3
        '
        '
        'Timer4
        '
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(69, 170)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(220, 16)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "Comprimiendo la base de datos..."
        Me.Label8.Visible = False
        '
        'form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(359, 437)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.salirBtn)
        Me.Controls.Add(Me.confBtn)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ok1)
        Me.Controls.Add(Me.ok4)
        Me.Controls.Add(Me.ok3)
        Me.Controls.Add(Me.ok2)
        Me.Controls.Add(Me.userTxt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.passTxt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.serverTxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.rutaWinvetBD)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "form2"
        Me.Text = "Subir datos"
        CType(Me.ok1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ok4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ok3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ok2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ok1 As System.Windows.Forms.PictureBox
    Friend WithEvents ok4 As System.Windows.Forms.PictureBox
    Friend WithEvents ok3 As System.Windows.Forms.PictureBox
    Friend WithEvents ok2 As System.Windows.Forms.PictureBox
    Friend WithEvents userTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents passTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents serverTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rutaWinvetBD As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents confBtn As System.Windows.Forms.Button
    Friend WithEvents salirBtn As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents Timer4 As System.Windows.Forms.Timer
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Timer5 As System.Windows.Forms.Timer
End Class

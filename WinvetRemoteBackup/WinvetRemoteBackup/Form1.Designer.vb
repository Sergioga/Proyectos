<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class configForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(configForm))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.userTxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.passTxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.serverTxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.connEstatus = New System.Windows.Forms.TextBox()
        Me.rutaWinvetBD = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.examinarBtn = New System.Windows.Forms.Button()
        Me.ok2 = New System.Windows.Forms.PictureBox()
        Me.ok3 = New System.Windows.Forms.PictureBox()
        Me.ok4 = New System.Windows.Forms.PictureBox()
        Me.ok1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ok2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ok3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ok4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ok1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(395, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(133, 120)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(415, 161)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(90, 90)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 14
        Me.PictureBox2.TabStop = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(236, 232)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(120, 34)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Subir archivos"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'userTxt
        '
        Me.userTxt.Location = New System.Drawing.Point(21, 174)
        Me.userTxt.Name = "userTxt"
        Me.userTxt.Size = New System.Drawing.Size(100, 20)
        Me.userTxt.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 15)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Usuario:"
        '
        'passTxt
        '
        Me.passTxt.Location = New System.Drawing.Point(180, 174)
        Me.passTxt.Name = "passTxt"
        Me.passTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(43)
        Me.passTxt.Size = New System.Drawing.Size(100, 20)
        Me.passTxt.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(177, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 15)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Contraseña:"
        '
        'serverTxt
        '
        Me.serverTxt.Location = New System.Drawing.Point(21, 118)
        Me.serverTxt.Name = "serverTxt"
        Me.serverTxt.Size = New System.Drawing.Size(261, 20)
        Me.serverTxt.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 15)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Servidor FTP:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(21, 232)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 34)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Guardar datos"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'connEstatus
        '
        Me.connEstatus.BackColor = System.Drawing.Color.Lime
        Me.connEstatus.Font = New System.Drawing.Font("Arial", 8.9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.connEstatus.ForeColor = System.Drawing.Color.Black
        Me.connEstatus.Location = New System.Drawing.Point(44, 59)
        Me.connEstatus.Name = "connEstatus"
        Me.connEstatus.ReadOnly = True
        Me.connEstatus.Size = New System.Drawing.Size(180, 21)
        Me.connEstatus.TabIndex = 18
        Me.connEstatus.Text = "Conexión correcta"
        Me.connEstatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.connEstatus.Visible = False
        '
        'rutaWinvetBD
        '
        Me.rutaWinvetBD.Location = New System.Drawing.Point(21, 33)
        Me.rutaWinvetBD.Name = "rutaWinvetBD"
        Me.rutaWinvetBD.Size = New System.Drawing.Size(231, 20)
        Me.rutaWinvetBD.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 15)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Ruta a la BBDD de Winvet:"
        '
        'examinarBtn
        '
        Me.examinarBtn.Location = New System.Drawing.Point(281, 27)
        Me.examinarBtn.Name = "examinarBtn"
        Me.examinarBtn.Size = New System.Drawing.Size(75, 23)
        Me.examinarBtn.TabIndex = 1
        Me.examinarBtn.Text = "Examinar"
        Me.examinarBtn.UseVisualStyleBackColor = True
        '
        'ok2
        '
        Me.ok2.Image = CType(resources.GetObject("ok2.Image"), System.Drawing.Image)
        Me.ok2.Location = New System.Drawing.Point(289, 118)
        Me.ok2.Name = "ok2"
        Me.ok2.Size = New System.Drawing.Size(18, 19)
        Me.ok2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ok2.TabIndex = 27
        Me.ok2.TabStop = False
        Me.ok2.Visible = False
        '
        'ok3
        '
        Me.ok3.Image = CType(resources.GetObject("ok3.Image"), System.Drawing.Image)
        Me.ok3.Location = New System.Drawing.Point(127, 174)
        Me.ok3.Name = "ok3"
        Me.ok3.Size = New System.Drawing.Size(18, 19)
        Me.ok3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ok3.TabIndex = 28
        Me.ok3.TabStop = False
        Me.ok3.Visible = False
        '
        'ok4
        '
        Me.ok4.Image = CType(resources.GetObject("ok4.Image"), System.Drawing.Image)
        Me.ok4.Location = New System.Drawing.Point(286, 174)
        Me.ok4.Name = "ok4"
        Me.ok4.Size = New System.Drawing.Size(18, 19)
        Me.ok4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ok4.TabIndex = 29
        Me.ok4.TabStop = False
        Me.ok4.Visible = False
        '
        'ok1
        '
        Me.ok1.Image = CType(resources.GetObject("ok1.Image"), System.Drawing.Image)
        Me.ok1.Location = New System.Drawing.Point(257, 34)
        Me.ok1.Name = "ok1"
        Me.ok1.Size = New System.Drawing.Size(18, 19)
        Me.ok1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ok1.TabIndex = 30
        Me.ok1.TabStop = False
        Me.ok1.Visible = False
        '
        'configForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 280)
        Me.ControlBox = False
        Me.Controls.Add(Me.ok1)
        Me.Controls.Add(Me.ok4)
        Me.Controls.Add(Me.ok3)
        Me.Controls.Add(Me.ok2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.userTxt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.passTxt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.serverTxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.connEstatus)
        Me.Controls.Add(Me.rutaWinvetBD)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.examinarBtn)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "configForm"
        Me.Text = "Configuracion"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ok2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ok3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ok4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ok1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents userTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents passTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents serverTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents connEstatus As System.Windows.Forms.TextBox
    Friend WithEvents rutaWinvetBD As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents examinarBtn As System.Windows.Forms.Button
    Friend WithEvents ok2 As System.Windows.Forms.PictureBox
    Friend WithEvents ok3 As System.Windows.Forms.PictureBox
    Friend WithEvents ok4 As System.Windows.Forms.PictureBox
    Friend WithEvents ok1 As System.Windows.Forms.PictureBox

End Class

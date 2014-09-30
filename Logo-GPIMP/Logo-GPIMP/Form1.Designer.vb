<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btn_enter = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.txt_pass = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_enter
        '
        Me.btn_enter.Location = New System.Drawing.Point(12, 220)
        Me.btn_enter.Name = "btn_enter"
        Me.btn_enter.Size = New System.Drawing.Size(130, 45)
        Me.btn_enter.TabIndex = 1
        Me.btn_enter.Text = "Continuar"
        Me.btn_enter.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(189, 220)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(130, 45)
        Me.btn_salir.TabIndex = 2
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.Location = New System.Drawing.Point(18, 180)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(85, 17)
        Me.lbl1.TabIndex = 3
        Me.lbl1.Text = "Contraseña:"
        '
        'txt_pass
        '
        Me.txt_pass.Location = New System.Drawing.Point(116, 179)
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.txt_pass.Size = New System.Drawing.Size(100, 20)
        Me.txt_pass.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(94, 148)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Contraseña incorrecta"
        Me.Label1.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Logo_GPIMP.My.Resources.Resources._2000px_Gnome_dev_printer
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(93, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 132)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(332, 290)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_pass)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_enter)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mapper"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_enter As System.Windows.Forms.Button
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents txt_pass As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class

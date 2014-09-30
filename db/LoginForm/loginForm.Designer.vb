<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(loginForm))
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtUser
        '
        Me.txtUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUser.Location = New System.Drawing.Point(15, 80)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(126, 20)
        Me.txtUser.TabIndex = 0
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(79, 189)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(126, 42)
        Me.btnLogin.TabIndex = 2
        Me.btnLogin.Text = "text"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "label2"
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(15, 131)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.txtPass.Size = New System.Drawing.Size(126, 20)
        Me.txtPass.TabIndex = 1
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.Location = New System.Drawing.Point(10, 23)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(39, 13)
        Me.lblLogin.TabIndex = 5
        Me.lblLogin.Text = "Label3"
        Me.lblLogin.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.db.My.Resources.Resources.loginImg
        Me.PictureBox1.Location = New System.Drawing.Point(158, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(118, 127)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'loginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblLogin)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtUser)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(300, 300)
        Me.Name = "loginForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "text"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents lblLogin As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class

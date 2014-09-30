<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class userImageForm
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(31, 33)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(168, 45)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "text"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.db.My.Resources.Resources.profile
        Me.PictureBox1.Location = New System.Drawing.Point(278, 33)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(90, 90)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 105)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(84, 39)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "text"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(132, 105)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(91, 39)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "text"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'userImageForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 162)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "userImageForm"
        Me.Text = "text"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class licenseFrom
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
        Me.verBtn = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.exitBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'verBtn
        '
        Me.verBtn.Location = New System.Drawing.Point(87, 119)
        Me.verBtn.Name = "verBtn"
        Me.verBtn.Size = New System.Drawing.Size(75, 23)
        Me.verBtn.TabIndex = 0
        Me.verBtn.Text = "Button1"
        Me.verBtn.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(133, 29)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(182, 20)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(69, 63)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(368, 20)
        Me.TextBox2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Label2"
        '
        'exitBtn
        '
        Me.exitBtn.Location = New System.Drawing.Point(281, 119)
        Me.exitBtn.Name = "exitBtn"
        Me.exitBtn.Size = New System.Drawing.Size(75, 23)
        Me.exitBtn.TabIndex = 5
        Me.exitBtn.Text = "Button2"
        Me.exitBtn.UseVisualStyleBackColor = True
        '
        'licenseFrom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 154)
        Me.ControlBox = False
        Me.Controls.Add(Me.exitBtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.verBtn)
        Me.Name = "licenseFrom"
        Me.Text = "license"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents verBtn As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents exitBtn As System.Windows.Forms.Button
End Class

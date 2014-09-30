<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class secureCheck
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
        Me.contBtn = New System.Windows.Forms.Button()
        Me.exitBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.passTxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'contBtn
        '
        Me.contBtn.Location = New System.Drawing.Point(12, 144)
        Me.contBtn.Name = "contBtn"
        Me.contBtn.Size = New System.Drawing.Size(99, 41)
        Me.contBtn.TabIndex = 0
        Me.contBtn.Text = "Button1"
        Me.contBtn.UseVisualStyleBackColor = True
        '
        'exitBtn
        '
        Me.exitBtn.Location = New System.Drawing.Point(154, 144)
        Me.exitBtn.Name = "exitBtn"
        Me.exitBtn.Size = New System.Drawing.Size(109, 41)
        Me.exitBtn.TabIndex = 1
        Me.exitBtn.Text = "Button2"
        Me.exitBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoEllipsis = True
        Me.Label1.Location = New System.Drawing.Point(18, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(241, 65)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'passTxt
        '
        Me.passTxt.Location = New System.Drawing.Point(130, 103)
        Me.passTxt.Name = "passTxt"
        Me.passTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.passTxt.Size = New System.Drawing.Size(123, 20)
        Me.passTxt.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Label3"
        '
        'secureCheck
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(276, 200)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.passTxt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.exitBtn)
        Me.Controls.Add(Me.contBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "secureCheck"
        Me.Text = "secureChecl"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents contBtn As System.Windows.Forms.Button
    Friend WithEvents exitBtn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents passTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class

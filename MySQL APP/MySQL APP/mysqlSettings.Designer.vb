<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mysqlSettings
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
        Me.serverTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.userTxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.passTxt = New System.Windows.Forms.TextBox()
        Me.saveBtn = New System.Windows.Forms.Button()
        Me.exitBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'serverTxt
        '
        Me.serverTxt.Location = New System.Drawing.Point(12, 36)
        Me.serverTxt.Name = "serverTxt"
        Me.serverTxt.Size = New System.Drawing.Size(211, 20)
        Me.serverTxt.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Label2"
        '
        'userTxt
        '
        Me.userTxt.Location = New System.Drawing.Point(102, 74)
        Me.userTxt.Name = "userTxt"
        Me.userTxt.Size = New System.Drawing.Size(121, 20)
        Me.userTxt.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Label3"
        '
        'passTxt
        '
        Me.passTxt.Location = New System.Drawing.Point(102, 100)
        Me.passTxt.Name = "passTxt"
        Me.passTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.passTxt.Size = New System.Drawing.Size(121, 20)
        Me.passTxt.TabIndex = 4
        '
        'saveBtn
        '
        Me.saveBtn.Location = New System.Drawing.Point(39, 141)
        Me.saveBtn.Name = "saveBtn"
        Me.saveBtn.Size = New System.Drawing.Size(168, 49)
        Me.saveBtn.TabIndex = 6
        Me.saveBtn.Text = "Button1"
        Me.saveBtn.UseVisualStyleBackColor = True
        '
        'exitBtn
        '
        Me.exitBtn.Location = New System.Drawing.Point(75, 196)
        Me.exitBtn.Name = "exitBtn"
        Me.exitBtn.Size = New System.Drawing.Size(96, 37)
        Me.exitBtn.TabIndex = 7
        Me.exitBtn.Text = "Button1"
        Me.exitBtn.UseVisualStyleBackColor = True
        '
        'mysqlSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(247, 244)
        Me.ControlBox = False
        Me.Controls.Add(Me.exitBtn)
        Me.Controls.Add(Me.saveBtn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.passTxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.userTxt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.serverTxt)
        Me.Name = "mysqlSettings"
        Me.Text = "mysqlSettings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents serverTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents userTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents passTxt As System.Windows.Forms.TextBox
    Friend WithEvents saveBtn As System.Windows.Forms.Button
    Friend WithEvents exitBtn As System.Windows.Forms.Button
End Class

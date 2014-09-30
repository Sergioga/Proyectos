<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class password_change
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
        Me.txtCurrent = New System.Windows.Forms.TextBox()
        Me.txtNew = New System.Windows.Forms.TextBox()
        Me.txtNewRe = New System.Windows.Forms.TextBox()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnChange = New System.Windows.Forms.Button()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblSurname = New System.Windows.Forms.Label()
        Me.lblLoginName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtCurrent
        '
        Me.txtCurrent.Location = New System.Drawing.Point(67, 144)
        Me.txtCurrent.Name = "txtCurrent"
        Me.txtCurrent.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.txtCurrent.Size = New System.Drawing.Size(152, 20)
        Me.txtCurrent.TabIndex = 1
        '
        'txtNew
        '
        Me.txtNew.Location = New System.Drawing.Point(67, 191)
        Me.txtNew.Name = "txtNew"
        Me.txtNew.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.txtNew.Size = New System.Drawing.Size(152, 20)
        Me.txtNew.TabIndex = 2
        '
        'txtNewRe
        '
        Me.txtNewRe.Location = New System.Drawing.Point(67, 236)
        Me.txtNewRe.Name = "txtNewRe"
        Me.txtNewRe.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.txtNewRe.Size = New System.Drawing.Size(152, 20)
        Me.txtNewRe.TabIndex = 3
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(64, 128)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(24, 13)
        Me.lbl1.TabIndex = 4
        Me.lbl1.Text = "text"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Location = New System.Drawing.Point(64, 175)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(24, 13)
        Me.lbl2.TabIndex = 5
        Me.lbl2.Text = "text"
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Location = New System.Drawing.Point(64, 220)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(24, 13)
        Me.lbl3.TabIndex = 6
        Me.lbl3.Text = "text"
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(12, 271)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(101, 23)
        Me.btnBack.TabIndex = 7
        Me.btnBack.Text = "text"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnChange
        '
        Me.btnChange.Location = New System.Drawing.Point(174, 271)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(98, 23)
        Me.btnChange.TabIndex = 8
        Me.btnChange.Text = "text"
        Me.btnChange.UseVisualStyleBackColor = True
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lbl4.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lbl4.Location = New System.Drawing.Point(3, 13)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(26, 15)
        Me.lbl4.TabIndex = 9
        Me.lbl4.Text = "text"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(50, 44)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(39, 13)
        Me.lblName.TabIndex = 10
        Me.lblName.Text = "Label1"
        '
        'lblSurname
        '
        Me.lblSurname.AutoSize = True
        Me.lblSurname.Location = New System.Drawing.Point(50, 72)
        Me.lblSurname.Name = "lblSurname"
        Me.lblSurname.Size = New System.Drawing.Size(39, 13)
        Me.lblSurname.TabIndex = 11
        Me.lblSurname.Text = "Label2"
        '
        'lblLoginName
        '
        Me.lblLoginName.AutoSize = True
        Me.lblLoginName.Location = New System.Drawing.Point(50, 99)
        Me.lblLoginName.Name = "lblLoginName"
        Me.lblLoginName.Size = New System.Drawing.Size(39, 13)
        Me.lblLoginName.TabIndex = 12
        Me.lblLoginName.Text = "Label3"
        '
        'password_change
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(285, 316)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblLoginName)
        Me.Controls.Add(Me.lblSurname)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lbl4)
        Me.Controls.Add(Me.btnChange)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.txtNewRe)
        Me.Controls.Add(Me.txtNew)
        Me.Controls.Add(Me.txtCurrent)
        Me.Name = "password_change"
        Me.Text = "text"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCurrent As System.Windows.Forms.TextBox
    Friend WithEvents txtNew As System.Windows.Forms.TextBox
    Friend WithEvents txtNewRe As System.Windows.Forms.TextBox
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents lbl3 As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnChange As System.Windows.Forms.Button
    Friend WithEvents lbl4 As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblSurname As System.Windows.Forms.Label
    Friend WithEvents lblLoginName As System.Windows.Forms.Label
End Class

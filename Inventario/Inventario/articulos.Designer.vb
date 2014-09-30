<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class articulos
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
        Me.newBtn = New System.Windows.Forms.Button()
        Me.delBtn = New System.Windows.Forms.Button()
        Me.actBtn = New System.Windows.Forms.Button()
        Me.findBtn = New System.Windows.Forms.Button()
        Me.findTxt = New System.Windows.Forms.TextBox()
        Me.nombreTxt = New System.Windows.Forms.TextBox()
        Me.desTxt = New System.Windows.Forms.TextBox()
        Me.nombreLbl = New System.Windows.Forms.Label()
        Me.desLbl = New System.Windows.Forms.Label()
        Me.cantLbl = New System.Windows.Forms.Label()
        Me.cantTxt = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'newBtn
        '
        Me.newBtn.Location = New System.Drawing.Point(183, 51)
        Me.newBtn.Name = "newBtn"
        Me.newBtn.Size = New System.Drawing.Size(79, 39)
        Me.newBtn.TabIndex = 2
        Me.newBtn.Text = "Nuevo"
        Me.newBtn.UseVisualStyleBackColor = True
        '
        'delBtn
        '
        Me.delBtn.Location = New System.Drawing.Point(183, 308)
        Me.delBtn.Name = "delBtn"
        Me.delBtn.Size = New System.Drawing.Size(79, 39)
        Me.delBtn.TabIndex = 3
        Me.delBtn.Text = "Borrar"
        Me.delBtn.UseVisualStyleBackColor = True
        Me.delBtn.Visible = False
        '
        'actBtn
        '
        Me.actBtn.Location = New System.Drawing.Point(12, 308)
        Me.actBtn.Name = "actBtn"
        Me.actBtn.Size = New System.Drawing.Size(79, 39)
        Me.actBtn.TabIndex = 4
        Me.actBtn.Text = "Actualizar"
        Me.actBtn.UseVisualStyleBackColor = True
        Me.actBtn.Visible = False
        '
        'findBtn
        '
        Me.findBtn.Location = New System.Drawing.Point(183, 11)
        Me.findBtn.Name = "findBtn"
        Me.findBtn.Size = New System.Drawing.Size(79, 30)
        Me.findBtn.TabIndex = 5
        Me.findBtn.Text = "Buscar"
        Me.findBtn.UseVisualStyleBackColor = True
        '
        'findTxt
        '
        Me.findTxt.Location = New System.Drawing.Point(12, 17)
        Me.findTxt.Name = "findTxt"
        Me.findTxt.Size = New System.Drawing.Size(153, 20)
        Me.findTxt.TabIndex = 6
        '
        'nombreTxt
        '
        Me.nombreTxt.Location = New System.Drawing.Point(12, 135)
        Me.nombreTxt.Name = "nombreTxt"
        Me.nombreTxt.Size = New System.Drawing.Size(153, 20)
        Me.nombreTxt.TabIndex = 8
        Me.nombreTxt.Visible = False
        '
        'desTxt
        '
        Me.desTxt.Location = New System.Drawing.Point(12, 197)
        Me.desTxt.Multiline = True
        Me.desTxt.Name = "desTxt"
        Me.desTxt.Size = New System.Drawing.Size(250, 84)
        Me.desTxt.TabIndex = 9
        Me.desTxt.Visible = False
        '
        'nombreLbl
        '
        Me.nombreLbl.AutoSize = True
        Me.nombreLbl.Location = New System.Drawing.Point(9, 112)
        Me.nombreLbl.Name = "nombreLbl"
        Me.nombreLbl.Size = New System.Drawing.Size(47, 13)
        Me.nombreLbl.TabIndex = 10
        Me.nombreLbl.Text = "Nombre:"
        Me.nombreLbl.Visible = False
        '
        'desLbl
        '
        Me.desLbl.AutoSize = True
        Me.desLbl.Location = New System.Drawing.Point(9, 172)
        Me.desLbl.Name = "desLbl"
        Me.desLbl.Size = New System.Drawing.Size(66, 13)
        Me.desLbl.TabIndex = 11
        Me.desLbl.Text = "Descripción:"
        Me.desLbl.Visible = False
        '
        'cantLbl
        '
        Me.cantLbl.AutoSize = True
        Me.cantLbl.Location = New System.Drawing.Point(215, 112)
        Me.cantLbl.Name = "cantLbl"
        Me.cantLbl.Size = New System.Drawing.Size(52, 13)
        Me.cantLbl.TabIndex = 13
        Me.cantLbl.Text = "Cantidad:"
        Me.cantLbl.Visible = False
        '
        'cantTxt
        '
        Me.cantTxt.Location = New System.Drawing.Point(214, 135)
        Me.cantTxt.Name = "cantTxt"
        Me.cantTxt.ReadOnly = True
        Me.cantTxt.Size = New System.Drawing.Size(53, 20)
        Me.cantTxt.TabIndex = 12
        Me.cantTxt.Visible = False
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(285, 13)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(187, 342)
        Me.ListBox1.TabIndex = 14
        Me.ListBox1.Visible = False
        '
        'articulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 362)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.cantLbl)
        Me.Controls.Add(Me.cantTxt)
        Me.Controls.Add(Me.desLbl)
        Me.Controls.Add(Me.nombreLbl)
        Me.Controls.Add(Me.desTxt)
        Me.Controls.Add(Me.nombreTxt)
        Me.Controls.Add(Me.findTxt)
        Me.Controls.Add(Me.findBtn)
        Me.Controls.Add(Me.actBtn)
        Me.Controls.Add(Me.delBtn)
        Me.Controls.Add(Me.newBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "articulos"
        Me.Text = "Artículos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents newBtn As System.Windows.Forms.Button
    Friend WithEvents delBtn As System.Windows.Forms.Button
    Friend WithEvents actBtn As System.Windows.Forms.Button
    Friend WithEvents findBtn As System.Windows.Forms.Button
    Friend WithEvents findTxt As System.Windows.Forms.TextBox
    Friend WithEvents nombreTxt As System.Windows.Forms.TextBox
    Friend WithEvents desTxt As System.Windows.Forms.TextBox
    Friend WithEvents nombreLbl As System.Windows.Forms.Label
    Friend WithEvents desLbl As System.Windows.Forms.Label
    Friend WithEvents cantLbl As System.Windows.Forms.Label
    Friend WithEvents cantTxt As System.Windows.Forms.TextBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
End Class

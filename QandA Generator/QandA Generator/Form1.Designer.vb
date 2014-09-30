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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAñadir = New System.Windows.Forms.Button()
        Me.btnBorrarTodo = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(48, 70)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(350, 61)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(420, 70)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(350, 61)
        Me.TextBox2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(186, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Pregunta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(592, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Respuesta"
        '
        'btnAñadir
        '
        Me.btnAñadir.Location = New System.Drawing.Point(287, 150)
        Me.btnAñadir.Name = "btnAñadir"
        Me.btnAñadir.Size = New System.Drawing.Size(229, 62)
        Me.btnAñadir.TabIndex = 5
        Me.btnAñadir.Text = "Añadir"
        Me.btnAñadir.UseVisualStyleBackColor = True
        '
        'btnBorrarTodo
        '
        Me.btnBorrarTodo.Location = New System.Drawing.Point(664, 355)
        Me.btnBorrarTodo.Name = "btnBorrarTodo"
        Me.btnBorrarTodo.Size = New System.Drawing.Size(118, 51)
        Me.btnBorrarTodo.TabIndex = 6
        Me.btnBorrarTodo.Text = "Borrar todo"
        Me.btnBorrarTodo.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(12, 231)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(620, 175)
        Me.ListView1.TabIndex = 7
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(664, 222)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(118, 51)
        Me.btnGuardar.TabIndex = 8
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(664, 289)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(118, 51)
        Me.btnBorrar.TabIndex = 9
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(819, 418)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.btnBorrarTodo)
        Me.Controls.Add(Me.btnAñadir)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnAñadir As System.Windows.Forms.Button
    Friend WithEvents btnBorrarTodo As System.Windows.Forms.Button
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnBorrar As System.Windows.Forms.Button

End Class

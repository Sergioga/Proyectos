<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserManForm
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
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.UserIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SurnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoginNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasswdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LvlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoginBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db1SQLDataSet = New db.db1SQLDataSet()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.grpBoxRights = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkBoxPasswd = New System.Windows.Forms.CheckBox()
        Me.chkBoxLevel = New System.Windows.Forms.CheckBox()
        Me.LoginTableAdapter = New db.db1SQLDataSetTableAdapters.loginTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoginBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db1SQLDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBoxRights.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UserIdDataGridViewTextBoxColumn, Me.UserNameDataGridViewTextBoxColumn, Me.SurnameDataGridViewTextBoxColumn, Me.LoginNameDataGridViewTextBoxColumn, Me.PasswdDataGridViewTextBoxColumn, Me.LvlDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.LoginBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Top
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(648, 307)
        Me.DataGridView1.TabIndex = 25
        '
        'UserIdDataGridViewTextBoxColumn
        '
        Me.UserIdDataGridViewTextBoxColumn.DataPropertyName = "userId"
        Me.UserIdDataGridViewTextBoxColumn.HeaderText = "text"
        Me.UserIdDataGridViewTextBoxColumn.Name = "UserIdDataGridViewTextBoxColumn"
        '
        'UserNameDataGridViewTextBoxColumn
        '
        Me.UserNameDataGridViewTextBoxColumn.DataPropertyName = "userName"
        Me.UserNameDataGridViewTextBoxColumn.HeaderText = "text"
        Me.UserNameDataGridViewTextBoxColumn.Name = "UserNameDataGridViewTextBoxColumn"
        '
        'SurnameDataGridViewTextBoxColumn
        '
        Me.SurnameDataGridViewTextBoxColumn.DataPropertyName = "surname"
        Me.SurnameDataGridViewTextBoxColumn.HeaderText = "text"
        Me.SurnameDataGridViewTextBoxColumn.Name = "SurnameDataGridViewTextBoxColumn"
        '
        'LoginNameDataGridViewTextBoxColumn
        '
        Me.LoginNameDataGridViewTextBoxColumn.DataPropertyName = "loginName"
        Me.LoginNameDataGridViewTextBoxColumn.HeaderText = "text"
        Me.LoginNameDataGridViewTextBoxColumn.Name = "LoginNameDataGridViewTextBoxColumn"
        '
        'PasswdDataGridViewTextBoxColumn
        '
        Me.PasswdDataGridViewTextBoxColumn.DataPropertyName = "passwd"
        Me.PasswdDataGridViewTextBoxColumn.HeaderText = "text"
        Me.PasswdDataGridViewTextBoxColumn.Name = "PasswdDataGridViewTextBoxColumn"
        Me.PasswdDataGridViewTextBoxColumn.Visible = False
        '
        'LvlDataGridViewTextBoxColumn
        '
        Me.LvlDataGridViewTextBoxColumn.DataPropertyName = "lvl"
        Me.LvlDataGridViewTextBoxColumn.HeaderText = "text"
        Me.LvlDataGridViewTextBoxColumn.Name = "LvlDataGridViewTextBoxColumn"
        Me.LvlDataGridViewTextBoxColumn.Visible = False
        '
        'LoginBindingSource
        '
        Me.LoginBindingSource.DataMember = "login"
        Me.LoginBindingSource.DataSource = Me.Db1SQLDataSet
        '
        'Db1SQLDataSet
        '
        Me.Db1SQLDataSet.DataSetName = "db1SQLDataSet"
        Me.Db1SQLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(13, 339)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(235, 60)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "text"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(13, 425)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(235, 63)
        Me.Button2.TabIndex = 27
        Me.Button2.Text = "text"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'grpBoxRights
        '
        Me.grpBoxRights.Controls.Add(Me.Label3)
        Me.grpBoxRights.Controls.Add(Me.Label5)
        Me.grpBoxRights.Controls.Add(Me.Label4)
        Me.grpBoxRights.Controls.Add(Me.Label2)
        Me.grpBoxRights.Controls.Add(Me.Label1)
        Me.grpBoxRights.Location = New System.Drawing.Point(437, 345)
        Me.grpBoxRights.Name = "grpBoxRights"
        Me.grpBoxRights.Size = New System.Drawing.Size(206, 179)
        Me.grpBoxRights.TabIndex = 30
        Me.grpBoxRights.TabStop = False
        Me.grpBoxRights.Text = "text"
        Me.grpBoxRights.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "text"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "text"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "text"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "text"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "text"
        '
        'chkBoxPasswd
        '
        Me.chkBoxPasswd.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkBoxPasswd.AutoSize = True
        Me.chkBoxPasswd.Location = New System.Drawing.Point(324, 368)
        Me.chkBoxPasswd.Name = "chkBoxPasswd"
        Me.chkBoxPasswd.Size = New System.Drawing.Size(43, 17)
        Me.chkBoxPasswd.TabIndex = 29
        Me.chkBoxPasswd.Text = "text"
        Me.chkBoxPasswd.UseVisualStyleBackColor = True
        '
        'chkBoxLevel
        '
        Me.chkBoxLevel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkBoxLevel.AutoSize = True
        Me.chkBoxLevel.Checked = True
        Me.chkBoxLevel.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkBoxLevel.Location = New System.Drawing.Point(324, 345)
        Me.chkBoxLevel.Name = "chkBoxLevel"
        Me.chkBoxLevel.Size = New System.Drawing.Size(43, 17)
        Me.chkBoxLevel.TabIndex = 28
        Me.chkBoxLevel.Text = "text"
        Me.chkBoxLevel.UseVisualStyleBackColor = True
        '
        'LoginTableAdapter
        '
        Me.LoginTableAdapter.ClearBeforeFill = True
        '
        'UserManForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(648, 534)
        Me.ControlBox = False
        Me.Controls.Add(Me.grpBoxRights)
        Me.Controls.Add(Me.chkBoxPasswd)
        Me.Controls.Add(Me.chkBoxLevel)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "UserManForm"
        Me.Text = "text"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoginBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db1SQLDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBoxRights.ResumeLayout(False)
        Me.grpBoxRights.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Db1SQLDataSet As db.db1SQLDataSet
    Friend WithEvents LoginBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LoginTableAdapter As db.db1SQLDataSetTableAdapters.loginTableAdapter
    Friend WithEvents grpBoxRights As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkBoxPasswd As System.Windows.Forms.CheckBox
    Friend WithEvents chkBoxLevel As System.Windows.Forms.CheckBox
    Friend WithEvents UserIdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UserNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SurnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LoginNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PasswdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LvlDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

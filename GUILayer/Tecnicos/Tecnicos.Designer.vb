<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tecnicos
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
        Me.txt_doc = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_fecha_ingreso = New System.Windows.Forms.MaskedTextBox()
        Me.FechaIngreso = New System.Windows.Forms.Label()
        Me.chk_todos = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbo_sucursal = New System.Windows.Forms.ComboBox()
        Me.dgv_tecnicos = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_quitar = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.col_nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_doc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_fecha_ingreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_suc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_tel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_mail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_obs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_tipo_doc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_fecha_nacim = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv_tecnicos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_doc
        '
        Me.txt_doc.Location = New System.Drawing.Point(124, 50)
        Me.txt_doc.Name = "txt_doc"
        Me.txt_doc.Size = New System.Drawing.Size(153, 20)
        Me.txt_doc.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "NumeroDocumento:"
        '
        'txt_fecha_ingreso
        '
        Me.txt_fecha_ingreso.Location = New System.Drawing.Point(124, 22)
        Me.txt_fecha_ingreso.Mask = "00/00/0000"
        Me.txt_fecha_ingreso.Name = "txt_fecha_ingreso"
        Me.txt_fecha_ingreso.Size = New System.Drawing.Size(153, 20)
        Me.txt_fecha_ingreso.TabIndex = 2
        '
        'FechaIngreso
        '
        Me.FechaIngreso.AutoSize = True
        Me.FechaIngreso.Location = New System.Drawing.Point(43, 25)
        Me.FechaIngreso.Name = "FechaIngreso"
        Me.FechaIngreso.Size = New System.Drawing.Size(75, 13)
        Me.FechaIngreso.TabIndex = 3
        Me.FechaIngreso.Text = "FechaIngreso:"
        '
        'chk_todos
        '
        Me.chk_todos.AutoSize = True
        Me.chk_todos.Location = New System.Drawing.Point(62, 117)
        Me.chk_todos.Name = "chk_todos"
        Me.chk_todos.Size = New System.Drawing.Size(56, 17)
        Me.chk_todos.TabIndex = 4
        Me.chk_todos.Text = "Todos"
        Me.chk_todos.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cbo_sucursal)
        Me.Panel1.Controls.Add(Me.dgv_tecnicos)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.chk_todos)
        Me.Panel1.Controls.Add(Me.FechaIngreso)
        Me.Panel1.Controls.Add(Me.txt_fecha_ingreso)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txt_doc)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(462, 325)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(67, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Sucursal:"
        '
        'cbo_sucursal
        '
        Me.cbo_sucursal.FormattingEnabled = True
        Me.cbo_sucursal.Location = New System.Drawing.Point(124, 76)
        Me.cbo_sucursal.Name = "cbo_sucursal"
        Me.cbo_sucursal.Size = New System.Drawing.Size(153, 21)
        Me.cbo_sucursal.TabIndex = 7
        '
        'dgv_tecnicos
        '
        Me.dgv_tecnicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_tecnicos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_nombre, Me.col_doc, Me.col_fecha_ingreso, Me.col_suc, Me.col_tel, Me.col_mail, Me.col_estado, Me.col_obs, Me.col_id, Me.col_tipo_doc, Me.col_fecha_nacim})
        Me.dgv_tecnicos.Location = New System.Drawing.Point(19, 161)
        Me.dgv_tecnicos.Name = "dgv_tecnicos"
        Me.dgv_tecnicos.Size = New System.Drawing.Size(417, 150)
        Me.dgv_tecnicos.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(252, 113)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Consultar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_quitar
        '
        Me.btn_quitar.Enabled = False
        Me.btn_quitar.Image = Global.App_BugTracker.My.Resources.Resources.eliminar
        Me.btn_quitar.Location = New System.Drawing.Point(104, 343)
        Me.btn_quitar.Name = "btn_quitar"
        Me.btn_quitar.Size = New System.Drawing.Size(40, 40)
        Me.btn_quitar.TabIndex = 10
        Me.btn_quitar.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.Image = Global.App_BugTracker.My.Resources.Resources.salir
        Me.btn_salir.Location = New System.Drawing.Point(434, 343)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(40, 40)
        Me.btn_salir.TabIndex = 11
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_editar
        '
        Me.btn_editar.Enabled = False
        Me.btn_editar.Image = Global.App_BugTracker.My.Resources.Resources.editar
        Me.btn_editar.Location = New System.Drawing.Point(58, 343)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(40, 40)
        Me.btn_editar.TabIndex = 9
        Me.btn_editar.UseVisualStyleBackColor = True
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Image = Global.App_BugTracker.My.Resources.Resources.agregar
        Me.btn_nuevo.Location = New System.Drawing.Point(12, 343)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(40, 40)
        Me.btn_nuevo.TabIndex = 8
        Me.btn_nuevo.UseVisualStyleBackColor = True
        '
        'col_nombre
        '
        Me.col_nombre.HeaderText = "Nombre"
        Me.col_nombre.Name = "col_nombre"
        '
        'col_doc
        '
        Me.col_doc.HeaderText = "Documento"
        Me.col_doc.Name = "col_doc"
        '
        'col_fecha_ingreso
        '
        Me.col_fecha_ingreso.HeaderText = "FechaIngreso"
        Me.col_fecha_ingreso.Name = "col_fecha_ingreso"
        '
        'col_suc
        '
        Me.col_suc.HeaderText = "Sucursal"
        Me.col_suc.Name = "col_suc"
        '
        'col_tel
        '
        Me.col_tel.HeaderText = "Telefono"
        Me.col_tel.Name = "col_tel"
        '
        'col_mail
        '
        Me.col_mail.HeaderText = "Mail"
        Me.col_mail.Name = "col_mail"
        '
        'col_estado
        '
        Me.col_estado.HeaderText = "Estado"
        Me.col_estado.Name = "col_estado"
        '
        'col_obs
        '
        Me.col_obs.HeaderText = "Observaciones"
        Me.col_obs.Name = "col_obs"
        '
        'col_id
        '
        Me.col_id.HeaderText = "Id"
        Me.col_id.Name = "col_id"
        Me.col_id.Visible = False
        '
        'col_tipo_doc
        '
        Me.col_tipo_doc.HeaderText = "TipoDoc"
        Me.col_tipo_doc.Name = "col_tipo_doc"
        Me.col_tipo_doc.Visible = False
        '
        'col_fecha_nacim
        '
        Me.col_fecha_nacim.HeaderText = "FechaNacimiento"
        Me.col_fecha_nacim.Name = "col_fecha_nacim"
        Me.col_fecha_nacim.Visible = False
        '
        'Tecnicos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 395)
        Me.Controls.Add(Me.btn_quitar)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_editar)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Tecnicos"
        Me.Text = "Tecnicos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgv_tecnicos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt_doc As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_fecha_ingreso As System.Windows.Forms.MaskedTextBox
    Friend WithEvents FechaIngreso As System.Windows.Forms.Label
    Friend WithEvents chk_todos As System.Windows.Forms.CheckBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbo_sucursal As System.Windows.Forms.ComboBox
    Friend WithEvents dgv_tecnicos As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btn_quitar As System.Windows.Forms.Button
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents btn_editar As System.Windows.Forms.Button
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents col_nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_doc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_fecha_ingreso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_suc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_tel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_mail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_estado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_obs As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_tipo_doc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_fecha_nacim As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

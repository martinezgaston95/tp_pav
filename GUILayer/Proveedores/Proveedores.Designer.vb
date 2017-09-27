<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Proveedores
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
        Me.chk_todas = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_consultar = New System.Windows.Forms.Button()
        Me.btn_quitar = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.dgv_proveedores = New System.Windows.Forms.DataGridView()
        Me.cbo_tipo_prov = New System.Windows.Forms.ComboBox()
        Me.col_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_tipo_prov = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_razon_social = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_calle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_nro_calle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_tel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_mail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv_proveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chk_todas
        '
        Me.chk_todas.AutoSize = True
        Me.chk_todas.Location = New System.Drawing.Point(66, 56)
        Me.chk_todas.Name = "chk_todas"
        Me.chk_todas.Size = New System.Drawing.Size(56, 17)
        Me.chk_todas.TabIndex = 28
        Me.chk_todas.Text = "Todas"
        Me.chk_todas.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Tipo:"
        '
        'btn_consultar
        '
        Me.btn_consultar.Location = New System.Drawing.Point(328, 50)
        Me.btn_consultar.Name = "btn_consultar"
        Me.btn_consultar.Size = New System.Drawing.Size(75, 23)
        Me.btn_consultar.TabIndex = 25
        Me.btn_consultar.Text = "Consultar"
        Me.btn_consultar.UseVisualStyleBackColor = True
        '
        'btn_quitar
        '
        Me.btn_quitar.Enabled = False
        Me.btn_quitar.Image = Global.App_BugTracker.My.Resources.Resources.eliminar
        Me.btn_quitar.Location = New System.Drawing.Point(104, 248)
        Me.btn_quitar.Name = "btn_quitar"
        Me.btn_quitar.Size = New System.Drawing.Size(40, 40)
        Me.btn_quitar.TabIndex = 23
        Me.btn_quitar.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.Image = Global.App_BugTracker.My.Resources.Resources.salir
        Me.btn_salir.Location = New System.Drawing.Point(389, 248)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(40, 40)
        Me.btn_salir.TabIndex = 24
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_editar
        '
        Me.btn_editar.Enabled = False
        Me.btn_editar.Image = Global.App_BugTracker.My.Resources.Resources.editar
        Me.btn_editar.Location = New System.Drawing.Point(58, 248)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(40, 40)
        Me.btn_editar.TabIndex = 22
        Me.btn_editar.UseVisualStyleBackColor = True
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Image = Global.App_BugTracker.My.Resources.Resources.agregar
        Me.btn_nuevo.Location = New System.Drawing.Point(12, 248)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(40, 40)
        Me.btn_nuevo.TabIndex = 21
        Me.btn_nuevo.UseVisualStyleBackColor = True
        '
        'dgv_proveedores
        '
        Me.dgv_proveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_proveedores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_id, Me.col_tipo_prov, Me.col_razon_social, Me.col_calle, Me.col_nro_calle, Me.col_tel, Me.col_estado, Me.col_mail})
        Me.dgv_proveedores.Location = New System.Drawing.Point(12, 91)
        Me.dgv_proveedores.Name = "dgv_proveedores"
        Me.dgv_proveedores.Size = New System.Drawing.Size(417, 151)
        Me.dgv_proveedores.TabIndex = 20
        '
        'cbo_tipo_prov
        '
        Me.cbo_tipo_prov.FormattingEnabled = True
        Me.cbo_tipo_prov.Location = New System.Drawing.Point(76, 19)
        Me.cbo_tipo_prov.Name = "cbo_tipo_prov"
        Me.cbo_tipo_prov.Size = New System.Drawing.Size(121, 21)
        Me.cbo_tipo_prov.TabIndex = 29
        '
        'col_id
        '
        Me.col_id.HeaderText = "Id"
        Me.col_id.Name = "col_id"
        Me.col_id.Visible = False
        '
        'col_tipo_prov
        '
        Me.col_tipo_prov.HeaderText = "Tipo"
        Me.col_tipo_prov.Name = "col_tipo_prov"
        '
        'col_razon_social
        '
        Me.col_razon_social.HeaderText = "Razon Social"
        Me.col_razon_social.Name = "col_razon_social"
        '
        'col_calle
        '
        Me.col_calle.HeaderText = "Calle"
        Me.col_calle.Name = "col_calle"
        '
        'col_nro_calle
        '
        Me.col_nro_calle.HeaderText = "NroCalle"
        Me.col_nro_calle.Name = "col_nro_calle"
        '
        'col_tel
        '
        Me.col_tel.HeaderText = "Telefono"
        Me.col_tel.Name = "col_tel"
        '
        'col_estado
        '
        Me.col_estado.HeaderText = "Estado"
        Me.col_estado.Name = "col_estado"
        '
        'col_mail
        '
        Me.col_mail.HeaderText = "Mail"
        Me.col_mail.Name = "col_mail"
        Me.col_mail.Visible = False
        '
        'Proveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 321)
        Me.Controls.Add(Me.cbo_tipo_prov)
        Me.Controls.Add(Me.chk_todas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_consultar)
        Me.Controls.Add(Me.btn_quitar)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_editar)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.dgv_proveedores)
        Me.Name = "Proveedores"
        Me.Text = "Proveedores"
        CType(Me.dgv_proveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chk_todas As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_consultar As System.Windows.Forms.Button
    Friend WithEvents btn_quitar As System.Windows.Forms.Button
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents btn_editar As System.Windows.Forms.Button
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents dgv_proveedores As System.Windows.Forms.DataGridView
    Friend WithEvents cbo_tipo_prov As System.Windows.Forms.ComboBox
    Friend WithEvents col_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_tipo_prov As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_razon_social As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_calle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_nro_calle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_tel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_estado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_mail As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

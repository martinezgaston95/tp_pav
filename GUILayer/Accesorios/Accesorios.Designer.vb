<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Accesorios
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
        Me.pnl_filtros = New System.Windows.Forms.GroupBox()
        Me.txt_modelo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbo_tipo = New System.Windows.Forms.ComboBox()
        Me.cbo_marca = New System.Windows.Forms.ComboBox()
        Me.dgv_accesorios = New System.Windows.Forms.DataGridView()
        Me.col_tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_modelo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chk_todos = New System.Windows.Forms.CheckBox()
        Me.btn_consultar = New System.Windows.Forms.Button()
        Me.btn_quitar = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.pnl_filtros.SuspendLayout()
        CType(Me.dgv_accesorios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl_filtros
        '
        Me.pnl_filtros.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnl_filtros.Controls.Add(Me.txt_modelo)
        Me.pnl_filtros.Controls.Add(Me.Label3)
        Me.pnl_filtros.Controls.Add(Me.Label2)
        Me.pnl_filtros.Controls.Add(Me.Label1)
        Me.pnl_filtros.Controls.Add(Me.cbo_tipo)
        Me.pnl_filtros.Controls.Add(Me.cbo_marca)
        Me.pnl_filtros.Controls.Add(Me.dgv_accesorios)
        Me.pnl_filtros.Controls.Add(Me.chk_todos)
        Me.pnl_filtros.Controls.Add(Me.btn_consultar)
        Me.pnl_filtros.Location = New System.Drawing.Point(12, 12)
        Me.pnl_filtros.Name = "pnl_filtros"
        Me.pnl_filtros.Size = New System.Drawing.Size(459, 381)
        Me.pnl_filtros.TabIndex = 8
        Me.pnl_filtros.TabStop = False
        Me.pnl_filtros.Text = "Filtros"
        '
        'txt_modelo
        '
        Me.txt_modelo.Location = New System.Drawing.Point(81, 90)
        Me.txt_modelo.Name = "txt_modelo"
        Me.txt_modelo.Size = New System.Drawing.Size(181, 20)
        Me.txt_modelo.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Modelo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Marca:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Tipo:"
        '
        'cbo_tipo
        '
        Me.cbo_tipo.FormattingEnabled = True
        Me.cbo_tipo.Location = New System.Drawing.Point(81, 19)
        Me.cbo_tipo.Name = "cbo_tipo"
        Me.cbo_tipo.Size = New System.Drawing.Size(181, 21)
        Me.cbo_tipo.TabIndex = 10
        '
        'cbo_marca
        '
        Me.cbo_marca.FormattingEnabled = True
        Me.cbo_marca.Location = New System.Drawing.Point(81, 52)
        Me.cbo_marca.Name = "cbo_marca"
        Me.cbo_marca.Size = New System.Drawing.Size(181, 21)
        Me.cbo_marca.TabIndex = 9
        '
        'dgv_accesorios
        '
        Me.dgv_accesorios.AllowUserToAddRows = False
        Me.dgv_accesorios.AllowUserToDeleteRows = False
        Me.dgv_accesorios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_accesorios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_tipo, Me.col_marca, Me.col_modelo, Me.col_cantidad, Me.col_estado, Me.col_id})
        Me.dgv_accesorios.Location = New System.Drawing.Point(6, 173)
        Me.dgv_accesorios.Name = "dgv_accesorios"
        Me.dgv_accesorios.ReadOnly = True
        Me.dgv_accesorios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_accesorios.Size = New System.Drawing.Size(424, 192)
        Me.dgv_accesorios.TabIndex = 8
        '
        'col_tipo
        '
        Me.col_tipo.HeaderText = "Tipo"
        Me.col_tipo.Name = "col_tipo"
        Me.col_tipo.ReadOnly = True
        '
        'col_marca
        '
        Me.col_marca.HeaderText = "Marca"
        Me.col_marca.Name = "col_marca"
        Me.col_marca.ReadOnly = True
        '
        'col_modelo
        '
        Me.col_modelo.HeaderText = "Modelo"
        Me.col_modelo.Name = "col_modelo"
        Me.col_modelo.ReadOnly = True
        '
        'col_cantidad
        '
        Me.col_cantidad.HeaderText = "Cantidad"
        Me.col_cantidad.Name = "col_cantidad"
        Me.col_cantidad.ReadOnly = True
        '
        'col_estado
        '
        Me.col_estado.HeaderText = "Estado"
        Me.col_estado.Name = "col_estado"
        Me.col_estado.ReadOnly = True
        '
        'col_id
        '
        Me.col_id.HeaderText = "Id"
        Me.col_id.Name = "col_id"
        Me.col_id.ReadOnly = True
        Me.col_id.Visible = False
        '
        'chk_todos
        '
        Me.chk_todos.AutoSize = True
        Me.chk_todos.Location = New System.Drawing.Point(28, 127)
        Me.chk_todos.Name = "chk_todos"
        Me.chk_todos.Size = New System.Drawing.Size(56, 17)
        Me.chk_todos.TabIndex = 2
        Me.chk_todos.Text = "Todos"
        Me.chk_todos.UseVisualStyleBackColor = True
        '
        'btn_consultar
        '
        Me.btn_consultar.Location = New System.Drawing.Point(297, 121)
        Me.btn_consultar.Name = "btn_consultar"
        Me.btn_consultar.Size = New System.Drawing.Size(87, 23)
        Me.btn_consultar.TabIndex = 3
        Me.btn_consultar.Text = "Consultar"
        Me.btn_consultar.UseVisualStyleBackColor = True
        '
        'btn_quitar
        '
        Me.btn_quitar.Enabled = False
        Me.btn_quitar.Image = Global.App_BugTracker.My.Resources.Resources.eliminar
        Me.btn_quitar.Location = New System.Drawing.Point(102, 399)
        Me.btn_quitar.Name = "btn_quitar"
        Me.btn_quitar.Size = New System.Drawing.Size(40, 40)
        Me.btn_quitar.TabIndex = 11
        Me.btn_quitar.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.Image = Global.App_BugTracker.My.Resources.Resources.salir
        Me.btn_salir.Location = New System.Drawing.Point(431, 399)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(40, 40)
        Me.btn_salir.TabIndex = 12
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_editar
        '
        Me.btn_editar.Enabled = False
        Me.btn_editar.Image = Global.App_BugTracker.My.Resources.Resources.editar
        Me.btn_editar.Location = New System.Drawing.Point(56, 399)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(40, 40)
        Me.btn_editar.TabIndex = 10
        Me.btn_editar.UseVisualStyleBackColor = True
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Image = Global.App_BugTracker.My.Resources.Resources.agregar
        Me.btn_nuevo.Location = New System.Drawing.Point(10, 399)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(40, 40)
        Me.btn_nuevo.TabIndex = 9
        Me.btn_nuevo.UseVisualStyleBackColor = True
        '
        'Accesorios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 463)
        Me.Controls.Add(Me.btn_quitar)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_editar)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.pnl_filtros)
        Me.Name = "Accesorios"
        Me.Text = "Accesorios"
        Me.pnl_filtros.ResumeLayout(False)
        Me.pnl_filtros.PerformLayout()
        CType(Me.dgv_accesorios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_quitar As System.Windows.Forms.Button
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents btn_editar As System.Windows.Forms.Button
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents pnl_filtros As System.Windows.Forms.GroupBox
    Friend WithEvents txt_modelo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbo_tipo As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_marca As System.Windows.Forms.ComboBox
    Friend WithEvents dgv_accesorios As System.Windows.Forms.DataGridView
    Friend WithEvents col_tipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_marca As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_modelo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_estado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chk_todos As System.Windows.Forms.CheckBox
    Friend WithEvents btn_consultar As System.Windows.Forms.Button
End Class

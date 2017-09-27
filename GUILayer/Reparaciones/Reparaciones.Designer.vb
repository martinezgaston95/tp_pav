<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reparaciones
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
        Me.txt_fecha_fin = New System.Windows.Forms.MaskedTextBox()
        Me.txt_fecha_inicio = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbo_tecnico = New System.Windows.Forms.ComboBox()
        Me.cbo_estado = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btn_consultar = New System.Windows.Forms.Button()
        Me.col_id_repa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_fecha_inicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_nombre_cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_nomb_tec = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_repuesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_fecha_fin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_coment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_td_cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_nro_cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_id_tec = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_fecha_fin
        '
        Me.txt_fecha_fin.Location = New System.Drawing.Point(369, 26)
        Me.txt_fecha_fin.Mask = "00/00/0000"
        Me.txt_fecha_fin.Name = "txt_fecha_fin"
        Me.txt_fecha_fin.Size = New System.Drawing.Size(137, 20)
        Me.txt_fecha_fin.TabIndex = 1
        '
        'txt_fecha_inicio
        '
        Me.txt_fecha_inicio.Location = New System.Drawing.Point(96, 26)
        Me.txt_fecha_inicio.Mask = "00/00/0000"
        Me.txt_fecha_inicio.Name = "txt_fecha_inicio"
        Me.txt_fecha_inicio.Size = New System.Drawing.Size(168, 20)
        Me.txt_fecha_inicio.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Fecha Inicio:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(283, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fecha Entrega:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(65, 118)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(476, 54)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cliente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Tipo Doc:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(86, 20)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(91, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(226, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Numero Doc:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(302, 20)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(137, 20)
        Me.TextBox1.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(41, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Tecnico:"
        '
        'cbo_tecnico
        '
        Me.cbo_tecnico.FormattingEnabled = True
        Me.cbo_tecnico.Location = New System.Drawing.Point(96, 52)
        Me.cbo_tecnico.Name = "cbo_tecnico"
        Me.cbo_tecnico.Size = New System.Drawing.Size(168, 21)
        Me.cbo_tecnico.TabIndex = 6
        '
        'cbo_estado
        '
        Me.cbo_estado.FormattingEnabled = True
        Me.cbo_estado.Location = New System.Drawing.Point(96, 79)
        Me.cbo_estado.Name = "cbo_estado"
        Me.cbo_estado.Size = New System.Drawing.Size(168, 21)
        Me.cbo_estado.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(47, 82)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Estado:"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_id_repa, Me.col_fecha_inicio, Me.col_estado, Me.col_nombre_cliente, Me.col_nomb_tec, Me.col_repuesto, Me.col_fecha_fin, Me.col_coment, Me.col_td_cliente, Me.col_nro_cliente, Me.col_id_tec})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 221)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(746, 280)
        Me.DataGridView1.TabIndex = 9
        '
        'btn_consultar
        '
        Me.btn_consultar.Location = New System.Drawing.Point(553, 182)
        Me.btn_consultar.Name = "btn_consultar"
        Me.btn_consultar.Size = New System.Drawing.Size(75, 23)
        Me.btn_consultar.TabIndex = 10
        Me.btn_consultar.Text = "Consultar"
        Me.btn_consultar.UseVisualStyleBackColor = True
        '
        'col_id_repa
        '
        Me.col_id_repa.HeaderText = "Id"
        Me.col_id_repa.Name = "col_id_repa"
        Me.col_id_repa.Visible = False
        '
        'col_fecha_inicio
        '
        Me.col_fecha_inicio.HeaderText = "Fecha Inicio"
        Me.col_fecha_inicio.Name = "col_fecha_inicio"
        '
        'col_estado
        '
        Me.col_estado.HeaderText = "Estado"
        Me.col_estado.Name = "col_estado"
        '
        'col_nombre_cliente
        '
        Me.col_nombre_cliente.HeaderText = "Nombre Cliente"
        Me.col_nombre_cliente.Name = "col_nombre_cliente"
        '
        'col_nomb_tec
        '
        Me.col_nomb_tec.HeaderText = "Nombre Tecnico"
        Me.col_nomb_tec.Name = "col_nomb_tec"
        '
        'col_repuesto
        '
        Me.col_repuesto.HeaderText = "Repuesto "
        Me.col_repuesto.Name = "col_repuesto"
        '
        'col_fecha_fin
        '
        Me.col_fecha_fin.HeaderText = "Fecha Entrega"
        Me.col_fecha_fin.Name = "col_fecha_fin"
        '
        'col_coment
        '
        Me.col_coment.HeaderText = "Comentario"
        Me.col_coment.Name = "col_coment"
        '
        'col_td_cliente
        '
        Me.col_td_cliente.HeaderText = "Tipo Doc Cliente"
        Me.col_td_cliente.Name = "col_td_cliente"
        Me.col_td_cliente.Visible = False
        '
        'col_nro_cliente
        '
        Me.col_nro_cliente.HeaderText = "Nro Doc Cliente"
        Me.col_nro_cliente.Name = "col_nro_cliente"
        Me.col_nro_cliente.Visible = False
        '
        'col_id_tec
        '
        Me.col_id_tec.HeaderText = "Id Tecnico"
        Me.col_id_tec.Name = "col_id_tec"
        Me.col_id_tec.Visible = False
        '
        'Reparaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(763, 513)
        Me.Controls.Add(Me.btn_consultar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbo_estado)
        Me.Controls.Add(Me.cbo_tecnico)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_fecha_fin)
        Me.Controls.Add(Me.txt_fecha_inicio)
        Me.Name = "Reparaciones"
        Me.Text = "Reparaciones"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_fecha_fin As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_fecha_inicio As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbo_tecnico As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_estado As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents col_id_repa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_fecha_inicio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_estado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_nombre_cliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_nomb_tec As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_repuesto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_fecha_fin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_coment As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_td_cliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_nro_cliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_id_tec As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btn_consultar As System.Windows.Forms.Button
End Class

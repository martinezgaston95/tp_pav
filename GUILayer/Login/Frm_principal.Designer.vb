<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Principal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Principal))
        Me.pnl_info_user = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_user = New System.Windows.Forms.Label()
        Me.Mnu_principal = New System.Windows.Forms.MenuStrip()
        Me.SoporteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TenicosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SucursalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccesoriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProovedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReparacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnl_info_user.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Mnu_principal.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_info_user
        '
        Me.pnl_info_user.BackColor = System.Drawing.Color.LightSeaGreen
        Me.pnl_info_user.Controls.Add(Me.PictureBox1)
        Me.pnl_info_user.Controls.Add(Me.lbl_user)
        Me.pnl_info_user.ForeColor = System.Drawing.Color.White
        Me.pnl_info_user.Location = New System.Drawing.Point(1, 27)
        Me.pnl_info_user.Name = "pnl_info_user"
        Me.pnl_info_user.Size = New System.Drawing.Size(461, 35)
        Me.pnl_info_user.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 35)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'lbl_user
        '
        Me.lbl_user.AutoSize = True
        Me.lbl_user.Location = New System.Drawing.Point(37, 14)
        Me.lbl_user.Name = "lbl_user"
        Me.lbl_user.Size = New System.Drawing.Size(55, 13)
        Me.lbl_user.TabIndex = 0
        Me.lbl_user.Text = "Sin sesión"
        '
        'Mnu_principal
        '
        Me.Mnu_principal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.SoporteToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.Mnu_principal.Location = New System.Drawing.Point(0, 0)
        Me.Mnu_principal.Name = "Mnu_principal"
        Me.Mnu_principal.Size = New System.Drawing.Size(461, 24)
        Me.Mnu_principal.TabIndex = 1
        Me.Mnu_principal.Text = "MenuStrip1"
        '
        'SoporteToolStripMenuItem
        '
        Me.SoporteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuariosToolStripMenuItem, Me.TenicosToolStripMenuItem, Me.SucursalesToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.AccesoriosToolStripMenuItem, Me.ProovedoresToolStripMenuItem})
        Me.SoporteToolStripMenuItem.Name = "SoporteToolStripMenuItem"
        Me.SoporteToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.SoporteToolStripMenuItem.Text = "&Soporte"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.Image = CType(resources.GetObject("UsuariosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.UsuariosToolStripMenuItem.Text = "Repuestos"
        '
        'TenicosToolStripMenuItem
        '
        Me.TenicosToolStripMenuItem.Image = CType(resources.GetObject("TenicosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TenicosToolStripMenuItem.Name = "TenicosToolStripMenuItem"
        Me.TenicosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.TenicosToolStripMenuItem.Text = "Tenicos"
        '
        'SucursalesToolStripMenuItem
        '
        Me.SucursalesToolStripMenuItem.Image = CType(resources.GetObject("SucursalesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SucursalesToolStripMenuItem.Name = "SucursalesToolStripMenuItem"
        Me.SucursalesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SucursalesToolStripMenuItem.Text = "Sucursales"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Image = CType(resources.GetObject("ClientesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'AccesoriosToolStripMenuItem
        '
        Me.AccesoriosToolStripMenuItem.Image = CType(resources.GetObject("AccesoriosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AccesoriosToolStripMenuItem.Name = "AccesoriosToolStripMenuItem"
        Me.AccesoriosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AccesoriosToolStripMenuItem.Text = "Accesorios"
        '
        'ProovedoresToolStripMenuItem
        '
        Me.ProovedoresToolStripMenuItem.Name = "ProovedoresToolStripMenuItem"
        Me.ProovedoresToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ProovedoresToolStripMenuItem.Text = "Proovedores"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "&Salir"
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReparacionesToolStripMenuItem})
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.InicioToolStripMenuItem.Text = "Inicio"
        '
        'ReparacionesToolStripMenuItem
        '
        Me.ReparacionesToolStripMenuItem.Image = CType(resources.GetObject("ReparacionesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ReparacionesToolStripMenuItem.Name = "ReparacionesToolStripMenuItem"
        Me.ReparacionesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ReparacionesToolStripMenuItem.Text = "Reparaciones"
        '
        'Frm_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(461, 262)
        Me.Controls.Add(Me.pnl_info_user)
        Me.Controls.Add(Me.Mnu_principal)
        Me.MainMenuStrip = Me.Mnu_principal
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Principal"
        Me.Text = "Principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnl_info_user.ResumeLayout(False)
        Me.pnl_info_user.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Mnu_principal.ResumeLayout(False)
        Me.Mnu_principal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnl_info_user As System.Windows.Forms.Panel
    Friend WithEvents lbl_user As System.Windows.Forms.Label
    Friend WithEvents Mnu_principal As System.Windows.Forms.MenuStrip
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SoporteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TenicosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SucursalesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AccesoriosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProovedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InicioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReparacionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class

Public Class Frm_Principal

    Private Sub Frm_Principal_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MsgBox("Seguro que desea salir de la aplicación?", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "Aviso") = 1 Then
            End
        Else
            'La propiedad e.Cancel permite cancelar el evento recibido.
            e.Cancel = True
        End If
    End Sub
    Private Sub Frm_Principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Al cargar el formulario principal cargamos y mostramos el formulario: Frm_login en forma MODAL.
        pnl_info_user.Width = Me.Width
        Mnu_principal.Visible = False
        Frm_login.ShowDialog()
    End Sub

    Public Sub actualizarUsuarioLogueado(ByVal userLogin As String)
        lbl_user.Text = userLogin
        Mnu_principal.Visible = True
    End Sub

    

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuariosToolStripMenuItem.Click
        Frm_Repuestos.ShowDialog()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TenicosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TenicosToolStripMenuItem.Click
        Tecnicos.ShowDialog()
    End Sub

    Private Sub SucursalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SucursalesToolStripMenuItem.Click
        Sucursales.ShowDialog()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        Clientes.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AccesoriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccesoriosToolStripMenuItem.Click
        Accesorios.ShowDialog()

    End Sub

    Private Sub ProovedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProovedoresToolStripMenuItem.Click
        Proveedores.ShowDialog()

    End Sub

    Private Sub ReparacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReparacionesToolStripMenuItem.Click
        Reparaciones.ShowDialog()
    End Sub
End Class
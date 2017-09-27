Public Class Proveedores

    Private Sub btn_consultar_Click(sender As Object, e As EventArgs) Handles btn_consultar.Click
        
        Dim sql As String = "select p.id_prov, p.razon_social, p.cuit, p.calle, p.nro_calle,p.mail, p.nro_contacto, p.estado, t.n_tipo from Proveedores p join Tipo_proveedor t on p.tipo_prov=t.id_tipo where 1=1"
        Dim filters As New List(Of Object)
        Dim flag_filtros As Boolean = False

        If Not chk_todas.Checked Then
            'Validar si el combo 'Perfiles' esta seleccionado.

            If cbo_tipo_prov.Text.ToString <> String.Empty Then
                'Si el cbo tiene un texto no vacìo entonces recuperamos el valor de la propiedad ValueMember
                filters.Add(cbo_tipo_prov.SelectedValue)
                sql += " AND p.tipo_prov=@param1"
                flag_filtros = True
            Else
                filters.Add(Nothing)
            End If


            If flag_filtros Then
                llenar_grid(BDHelper.getDBHelper.ConsultarSQLConParametros(sql, filters.ToArray))
            Else
                MessageBox.Show("Debe ingresar al menos un criterio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            llenar_grid(BDHelper.getDBHelper.ConsultaSQL(sql))
        End If
    End Sub


    Private Sub llenar_grid(ByVal source As Object)
        dgv_proveedores.Rows.Clear()
        For Each row As DataRow In source.Rows
            dgv_proveedores.Rows.Add(New String() {row.Item("id_prov").ToString, row.Item("n_tipo").ToString, row.Item("razon_social").ToString, row.Item("calle").ToString, row.Item("nro_calle").ToString, row.Item("nro_contacto"), row.Item("estado").ToString, row.Item("mail").ToString})
        Next
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        If MessageBox.Show("Seguro que desea salir?", _
              "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question _
              , MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
            Me.Close()
        End If
    End Sub

    Private Sub dgv_proveedores_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_proveedores.CellContentClick
        btn_editar.Enabled = True
        btn_quitar.Enabled = True
    End Sub

    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        Proveedores_abm.seleccionar_proveedor(Proveedores_abm.Opcion.update, dgv_proveedores.CurrentRow)
        Proveedores_abm.ShowDialog()
        btn_consultar_Click(sender, e)
    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        Proveedores_abm.ShowDialog()
    End Sub

    Private Sub btn_quitar_Click(sender As Object, e As EventArgs) Handles btn_quitar.Click
        Proveedores_abm.seleccionar_proveedor(Proveedores_abm.Opcion.delete, dgv_proveedores.CurrentRow)
        Proveedores_abm.ShowDialog()
        btn_consultar_Click(sender, e)
    End Sub

    Private Sub Proveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Frm_Repuestos.llenarCombo(cbo_tipo_prov, BDHelper.getDBHelper.ConsultaSQL("SELECT * From Tipo_proveedor "), "n_tipo", "id_tipo")

    End Sub
End Class


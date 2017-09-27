Public Class Sucursales

    Private Sub btn_consultar_Click(sender As Object, e As EventArgs) Handles btn_consultar.Click

        Dim sql As String = "select id_suc, descripcion, calle, nro_calle,tel_suc,estado from Sucursales where 1=1"
        Dim filters As New List(Of Object)
        Dim flag_filtros As Boolean = False

        If Not chk_todas.Checked Then
            'Validar si el combo 'Perfiles' esta seleccionado.

            If txt_descripcion.Text <> String.Empty Then
                'Si el cbo tiene un texto no vacìo entonces recuperamos el valor de la propiedad ValueMember
                filters.Add(txt_descripcion.Text)
                sql += " AND descripcion=@param1"
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
        dgv_sucursales.Rows.Clear()
        For Each row As DataRow In source.Rows
            dgv_sucursales.Rows.Add(New String() {row.Item("id_suc").ToString, row.Item("descripcion").ToString, row.Item("calle").ToString, row.Item("nro_calle").ToString, row.Item("tel_suc").ToString, row.Item("estado")})
        Next
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        If MessageBox.Show("Seguro que desea salir?", _
              "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question _
              , MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
            Me.Close()
        End If
    End Sub

    Private Sub dgv_sucursales_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_sucursales.CellContentClick
        btn_editar.Enabled = True
        btn_quitar.Enabled = True
    End Sub

    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        Sucursales_abm.seleccionar_sucursal(Sucursales_abm.Opcion.update, dgv_sucursales.CurrentRow)
        Sucursales_abm.ShowDialog()
        btn_consultar_Click(sender, e)
    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        Sucursales_abm.ShowDialog()
    End Sub

    Private Sub btn_quitar_Click(sender As Object, e As EventArgs) Handles btn_quitar.Click
        Sucursales_abm.seleccionar_sucursal(Sucursales_abm.Opcion.delete, dgv_sucursales.CurrentRow)
        Sucursales_abm.ShowDialog()
        btn_consultar_Click(sender, e)
    End Sub
End Class


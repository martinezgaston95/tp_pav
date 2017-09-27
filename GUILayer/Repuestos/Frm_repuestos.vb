Public Class Frm_Repuestos

    Private Sub btn_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nuevo.Click
        Frm_abm_repuesto.ShowDialog()
    End Sub

    Private Sub Frm_Repuestos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenarCombo(cbo_marca, BDHelper.getDBHelper.ConsultaSQL("SELECT * From Marca "), "n_marca", "id_marca")
        llenarCombo(cbo_tipo, BDHelper.getDBHelper.ConsultaSQL("SELECT * FROM Tipo_repuesto"), "descripcion", "id_tipo")

    End Sub

    ' Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_todos.CheckedChanged
    '    If chk_todos.Checked Then
    '       txt_nombre.Enabled = False
    '      cbo_perfiles.Enabled = False
    ' Else
    '    txt_nombre.Enabled = True
    '   cbo_perfiles.Enabled = True
    '    End If
    ' End Sub

    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        'Confirmación de salida.
        If MessageBox.Show("Seguro que desea salir?", _
                "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question _
                , MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
            Me.Close()
        End If
    End Sub

    Private Sub btn_consultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_consultar.Click
        Dim sql As String = "select r.id_rep,r.estado,r.modelo,r.cantidad,t.descripcion,m.n_marca from Repuestos r join Tipo_repuesto t on r.tipo_rep=t.id_tipo join Marca m on r.marca=m.id_marca where 1=1"
        Dim filters As New List(Of Object)
        Dim flag_filtros As Boolean = False

        If Not chk_todos.Checked Then
            'Validar si el combo 'Perfiles' esta seleccionado.
            If cbo_tipo.Text <> String.Empty Then
                'Si el cbo tiene un texto no vacìo entonces recuperamos el valor de la propiedad ValueMember
                filters.Add(cbo_tipo.SelectedValue)
                sql += " AND t.id_tipo=@param1"
                flag_filtros = True
            Else
                filters.Add(Nothing)
            End If

            If cbo_marca.Text <> String.Empty Then
                'Si el cbo tiene un texto no vacìo entonces recuperamos el valor de la propiedad ValueMember
                filters.Add(cbo_marca.SelectedValue)
                sql += " AND m.id_marca=@param2"
                flag_filtros = True
            Else
                filters.Add(Nothing)
            End If

            If txt_modelo.Text <> String.Empty Then
                'Si el cbo tiene un texto no vacìo entonces recuperamos el valor de la propiedad ValueMember
                filters.Add(txt_modelo.Text)
                sql += " AND r.modelo=@param3"
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
        dgv_repuestos.Rows.Clear()
        For Each row As DataRow In source.Rows
            dgv_repuestos.Rows.Add(New String() {row.Item("descripcion").ToString, row.Item("n_marca").ToString, row.Item("modelo").ToString, row.Item("cantidad").ToString, row.Item("estado").ToString, row.Item("id_rep").ToString})
        Next
    End Sub

    Private Sub btn_editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_editar.Click
        Frm_abm_repuesto.seleccionar_repuesto(Frm_abm_repuesto.Opcion.update, dgv_repuestos.CurrentRow)
        Frm_abm_repuesto.ShowDialog()
        btn_consultar_Click(sender, e)
    End Sub


    Private Sub dgv_users_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_repuestos.CellContentClick
        btn_editar.Enabled = True
        btn_quitar.Enabled = True
    End Sub

    Private Sub btn_quitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_quitar.Click
        Frm_abm_repuesto.seleccionar_repuesto(Frm_abm_repuesto.Opcion.delete, dgv_repuestos.CurrentRow)
        Frm_abm_repuesto.ShowDialog()
        btn_consultar_Click(sender, e)
    End Sub

    Private Sub cbo_perfiles_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub pnl_filtros_Enter(sender As Object, e As EventArgs) Handles pnl_filtros.Enter

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_tipo.SelectedIndexChanged

    End Sub
    Friend Sub llenarCombo(ByVal cbo As ComboBox, ByVal source As Object, ByVal display As String, ByVal value As String)
        cbo.DataSource = source
        cbo.DisplayMember = display
        cbo.ValueMember = value
        cbo.SelectedIndex = -1
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_marca.SelectedIndexChanged

    End Sub
End Class
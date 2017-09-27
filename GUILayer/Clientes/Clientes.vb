Public Class Clientes
    Private Sub Clientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Frm_Repuestos.llenarCombo(cbo_tipo_doc, BDHelper.getDBHelper.ConsultaSQL("SELECT * From Tipo_doc "), "n_tipo", "id_tipo")
    End Sub

    Private Sub dgv_cientes_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_clientes.CellContentClick
        btn_editar.Enabled = True
        btn_quitar.Enabled = True
    End Sub

    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        'Confirmación de salida.
        If MessageBox.Show("Seguro que desea salir?", _
                "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question _
                , MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
            Me.Close()
        End If
    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        Clientes_abm.ShowDialog()
    End Sub

    Private Sub llenar_grid(ByVal source As Object)
        dgv_clientes.Rows.Clear()
        For Each row As DataRow In source.Rows
            dgv_clientes.Rows.Add(New String() {row.Item("n_tipo").ToString, row.Item("doc").ToString, row.Item("nombre").ToString, row.Item("tel_contacto").ToString, row.Item("mail").ToString, row.Item("observaciones").ToString, row.Item("fecha_alta").ToString, row.Item("fecha_nacimiento").ToString, row.Item("estado").ToString, row.Item("tipo_doc").ToString})
        Next
    End Sub
    Private Sub btn_consultar_Click(sender As Object, e As EventArgs) Handles btn_consultar.Click
        Dim sql As String = "select t.tipo_doc, t.doc, t.nombre, t.tel_contacto, t.mail , t.estado,t.observaciones,t.fecha_alta, t.tipo_doc, t.fecha_nacimiento, td.n_tipo from Clientes t join Tipo_doc td on t.tipo_doc=td.id_tipo where 1=1"
        Dim filters As New List(Of Object)
        Dim flag_filtros As Boolean = False

        If Not chk_todos.Checked Then
            'Validar si el combo 'Perfiles' esta seleccionado.

            If IsDate(txt_fecha_alta.Text) Then
                filters.Add(txt_fecha_alta.Text.ToString)
                sql += " AND t.fecha_alta=@param1"
                flag_filtros = True
            Else
                filters.Add(Nothing)
            End If


            If txt_doc.Text <> String.Empty Then
                'Si el cbo tiene un texto no vacìo entonces recuperamos el valor de la propiedad ValueMember
                filters.Add(txt_doc.Text)
                sql += " AND t.doc=@param2"
                flag_filtros = True
            Else
                filters.Add(Nothing)
            End If

            If cbo_tipo_doc.Text <> String.Empty Then
                'Si el cbo tiene un texto no vacìo entonces recuperamos el valor de la propiedad ValueMember
                filters.Add(cbo_tipo_doc.SelectedValue)
                sql += " AND t.tipo_doc=@param3"
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


    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        Clientes_abm.seleccionar_cliente(Clientes_abm.Opcion.update, dgv_clientes.CurrentRow)
        Clientes_abm.ShowDialog()
        btn_consultar_Click(sender, e)
    End Sub

    Private Sub btn_quitar_Click(sender As Object, e As EventArgs) Handles btn_quitar.Click
        Clientes_abm.seleccionar_cliente(Clientes_abm.Opcion.delete, dgv_clientes.CurrentRow)
        Clientes_abm.ShowDialog()
        btn_consultar_Click(sender, e)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Shared Sub mostrar_datos()
        Throw New NotImplementedException
    End Sub

End Class
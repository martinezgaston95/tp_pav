Public Class Tecnicos

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
    Private Sub Tecnicos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Frm_Repuestos.llenarCombo(cbo_sucursal, BDHelper.getDBHelper.ConsultaSQL("SELECT * From Sucursales "), "descripcion", "id_suc")
    End Sub

    Private Sub dgv_tecnicos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_tecnicos.CellContentClick
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
        Tecnicos_abm.ShowDialog()
    End Sub

    
    Private Sub btn_consultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sql As String = "select t.n_tecnico, t.doc, t.fecha_ingreso, s.descripcion, t.tel_contacto, t.mail , t.estado,t.observaciones,t.id_tecnico, t.tipo_doc, t.fecha_nacimiento, td.n_tipo from Tecnicos t join Sucursales s on t.id_sucursal=s.id_suc join Tipo_doc td on t.tipo_doc=td.id_tipo where 1=1"
        Dim filters As New List(Of Object)
        Dim flag_filtros As Boolean = False

        If Not chk_todos.Checked Then
            'Validar si el combo 'Perfiles' esta seleccionado.

            If IsDate(txt_fecha_ingreso.Text) Then
                filters.Add(txt_fecha_ingreso.Text.ToString)
                sql += " AND t.fecha_ingreso=@param1"
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

            If cbo_sucursal.Text <> String.Empty Then
                'Si el cbo tiene un texto no vacìo entonces recuperamos el valor de la propiedad ValueMember
                filters.Add(cbo_sucursal.SelectedValue)
                sql += " AND t.id_sucursal=@param3"
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
        dgv_tecnicos.Rows.Clear()
        For Each row As DataRow In source.Rows
            dgv_tecnicos.Rows.Add(New String() {row.Item("n_tecnico").ToString, row.Item("doc").ToString, row.Item("fecha_ingreso").ToString, row.Item("descripcion").ToString, row.Item("tel_contacto").ToString, row.Item("mail").ToString, row.Item("estado").ToString, row.Item("observaciones").ToString, row.Item("id_tecnico").ToString, row.Item("n_tipo").ToString, row.Item("fecha_nacimiento").ToString})
        Next
    End Sub


    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        Tecnicos_abm.seleccionar_tecnico(Tecnicos_abm.Opcion.update, dgv_tecnicos.CurrentRow)
        Tecnicos_abm.ShowDialog()
        btn_consultar_Click(sender, e)
    End Sub

    Private Sub btn_quitar_Click(sender As Object, e As EventArgs) Handles btn_quitar.Click
        Tecnicos_abm.seleccionar_tecnico(Tecnicos_abm.Opcion.delete, dgv_tecnicos.CurrentRow)
        Tecnicos_abm.ShowDialog()
        btn_consultar_Click(sender, e)
    End Sub
End Class
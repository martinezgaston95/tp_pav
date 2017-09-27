Public Class Abm_accesorio
    Enum Opcion
        insert
        update
        delete
    End Enum

    Private _action As Opcion = Opcion.insert
    Private _row_selected As DataGridViewRow

    Private Sub Abm_Accesorio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Frm_Repuestos.llenarCombo(cmb_marca, BDHelper.getDBHelper.ConsultaSQL("SELECT * From Marca "), "n_marca", "id_marca")
        Frm_Repuestos.llenarCombo(cmb_tipo, BDHelper.getDBHelper.ConsultaSQL("SELECT * FROM Tipo_accesorio"), "n_tipo", "id_tipo")
        Select Case _action
            Case Opcion.insert
                Me.Text = "Nuevo accesorio"
                _row_selected = Nothing

            Case Opcion.update
                Me.Text = "Actualizar accesorio"
                'Recuperar accesorio seleccionado en la grilla 
                mostrar_datos()
                cmb_tipo.Enabled = True
                cmb_marca.Enabled = True
                txt_modelo.Enabled = True

            Case Opcion.delete
                mostrar_datos()
                Me.Text = "Habilitar/Deshabilitar accesorio"
                cmb_tipo.Enabled = False
                cmb_marca.Enabled = False
                txt_modelo.Enabled = False
        End Select

    End Sub

    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Me.Dispose()
    End Sub


    Public Sub seleccionar_accesorio(ByVal op As Opcion, ByVal row_selected As DataGridViewRow)
        _action = op
        _row_selected = row_selected
    End Sub

    Friend Sub mostrar_datos()
        If Not IsNothing(_row_selected) Then
            cmb_tipo.Text = _row_selected.Cells("col_tipo").Value
            cmb_marca.Text = _row_selected.Cells("col_marca").Value
            txt_modelo.Text = _row_selected.Cells("col_modelo").Value

        End If
    End Sub

    Private Sub btn_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.Click
        Dim str_sql As String = ""
        Dim estado As String


        Select Case _action
            Case Opcion.insert 'en el bdHelper hacemos BDHelper.getInstancia.EjecutarSql(sql_str)
                If existe_nombre() = False Then
                    If validar_campos() Then 'cbo_perfil.SelectedValue.ToString seleccionamos el valor por detras del combo y lo transformamos en ToString  para que sean del mismo tipo antes y dsp del += me deje concatenar
                        str_sql = "INSERT INTO Accesorios (tipo_acc, modelo, marca, estado) VALUES ("
                        str_sql += cmb_tipo.SelectedValue.ToString + ",'"
                        str_sql += txt_modelo.Text.ToString + "',"
                        str_sql += cmb_marca.SelectedValue.ToString + ","
                        str_sql += "'D')"
                        If BDHelper.getDBHelper.EjecutarSQL(str_sql) > 0 Then
                            MessageBox.Show("Accesorio añadido!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Me.Close()
                        End If
                    End If
                Else
                    MessageBox.Show("Accesorio ya existente!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If


            Case Opcion.update
                If validar_campos() Then
                    str_sql = "UPDATE Accesorios SET tipo_acc= "
                    str_sql += cmb_tipo.SelectedValue.ToString + ", modelo='"
                    str_sql += txt_modelo.Text.ToString + "', marca="
                    str_sql += cmb_marca.SelectedValue.ToString + "WHERE (id_acc="
                    str_sql += _row_selected.Cells("col_id").Value.ToString + ")"
                    If BDHelper.getDBHelper.EjecutarSQL(str_sql) > 0 Then
                        MessageBox.Show("Accesorio modificado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Dispose()
                    Else
                        MessageBox.Show("Error al actualizar el Accesorio!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If


            Case Opcion.delete
                If MessageBox.Show("Seguro que desea habilitar/deshabilitar el Accesorio seleccionado?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                    estado = BDHelper.getDBHelper.ConsultaSQL("Select estado from Accesorios where id_acc = " + _row_selected.Cells("col_id").Value).Rows(0).Item("estado")
                    If estado = "D" Then
                        estado = "N"
                    Else
                        estado = "D"
                    End If
                    str_sql = "UPDATE Accesorios SET estado = '" + estado + "' WHERE id_acc = " + _row_selected.Cells("col_id").Value
                    If BDHelper.getDBHelper.EjecutarSQL(str_sql) > 0 Then
                        MessageBox.Show("Accesorio Habilitado/Deshabilitado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Dispose()
                    Else
                        MessageBox.Show("Error al actualizar el Accesorio!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If


        End Select
    End Sub

    Private Function validar_campos() As Boolean
        'campos obligatorios
        If cmb_tipo.Text = String.Empty Then
            MessageBox.Show("Ingresar tipo de Accesorio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cmb_tipo.Focus()
            Return False
        Else
            cmb_tipo.BackColor = Color.White
        End If

        If cmb_marca.Text = String.Empty Then
            MessageBox.Show("Ingresar marca de Accesorio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cmb_marca.Focus()
            Return False
        Else
            cmb_marca.BackColor = Color.White
        End If

        If txt_modelo.Text = String.Empty Then
            MessageBox.Show("Ingresar modelo de Accesorio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_modelo.Focus()
            Return False
        Else
            txt_modelo.BackColor = Color.White
        End If

        Return True
    End Function
    Private Function existe_nombre() As Boolean
        Return BDHelper.getDBHelper.ConsultaSQL("select * from Accesorios where tipo_acc ='" + cmb_tipo.SelectedValue.ToString + "' and marca ='" + cmb_marca.SelectedValue.ToString + "' and modelo ='" + txt_modelo.Text + "'").Rows.Count > 0
    End Function

    Private Sub cbo_perfil_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub cmb_tipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_tipo.SelectedIndexChanged

    End Sub
End Class
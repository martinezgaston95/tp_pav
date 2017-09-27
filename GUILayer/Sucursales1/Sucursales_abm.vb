Public Class Sucursales_abm
    Enum Opcion
        insert
        update
        delete
    End Enum

    Private _action As Opcion = Opcion.insert
    Private _row_selected As DataGridViewRow

    Private Sub Sucursales_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Select Case _action
            Case Opcion.insert
                Me.Text = "Nueva Sucursal"
                _row_selected = Nothing

            Case Opcion.update
                Me.Text = "Actualizar Sucursal"
                'Recuperar repuesto seleccionado en la grilla 
                mostrar_datos()
                txt_descripcion.Enabled = True
                txt_calle.Enabled = True
                txt_nro_calle.Enabled = True
                txt_tel.Enabled = True




            Case Opcion.delete
                mostrar_datos()
                Me.Text = "Habilitar/Deshabilitar Sucursal"
                txt_descripcion.Enabled = False
                txt_calle.Enabled = False
                txt_nro_calle.Enabled = False
                txt_tel.Enabled = False

        End Select
    End Sub

    Friend Sub mostrar_datos()
        If Not IsNothing(_row_selected) Then
            txt_descripcion.Text = _row_selected.Cells("col_descripcion").Value
            txt_calle.Text = _row_selected.Cells("col_calle").Value
            txt_nro_calle.Text = _row_selected.Cells("col_nro_calle").Value
            txt_tel.Text = _row_selected.Cells("col_tel").Value
        End If
    End Sub
    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        Dim str_sql As String = ""
        Dim estado As String


        Select Case _action
            Case Opcion.insert 'en el bdHelper hacemos BDHelper.getInstancia.EjecutarSql(sql_str)

                If validar_campos() Then 'cbo_perfil.SelectedValue.ToString seleccionamos el valor por detras del combo y lo transformamos en ToString  para que sean del mismo tipo antes y dsp del += me deje concatenar
                    str_sql = "INSERT INTO Sucursales (descripcion,calle,nro_calle,tel_suc,estado )VALUES ('"
                    str_sql += txt_descripcion.Text.ToString + "',"
                    str_sql += txt_calle.Text.ToString + ","
                    str_sql += txt_nro_calle.Text.ToString + ",'"
                    str_sql += txt_tel.Text.ToString + "',"
                    str_sql += "'H')"
                    

                    If BDHelper.getDBHelper.EjecutarSQL(str_sql) > 0 Then
                        MessageBox.Show("Sucursa añadida!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Close()
                    End If
                End If
               


            Case Opcion.update
                If validar_campos() Then
                    str_sql = "UPDATE Sucursales SET descripcion='"
                    str_sql += txt_descripcion.Text.ToString + "', calle='"
                    str_sql += txt_calle.Text.ToString + "', nro_calle="
                    str_sql += txt_nro_calle.Text.ToString + ", tel_suc="
                    str_sql += txt_tel.Text.ToString + " WHERE (id_suc="
                    str_sql += _row_selected.Cells("col_id").Value.ToString + ")"
                    If BDHelper.getDBHelper.EjecutarSQL(str_sql) > 0 Then
                        MessageBox.Show("Sucursal modificada!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Dispose()
                    Else
                        MessageBox.Show("Error al actualizar la sucursal!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If


            Case Opcion.delete
                If MessageBox.Show("Seguro que desea habilitar/deshabilitar la sucursal seleccionada?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                    estado = BDHelper.getDBHelper.ConsultaSQL("Select estado from Sucursales where id_suc = " + _row_selected.Cells("col_id").Value).Rows(0).Item("estado")
                    If estado = "H" Then
                        estado = "D"
                    Else
                        estado = "H"
                    End If
                    str_sql = "UPDATE Sucursales SET estado = '" + estado + "' WHERE id_suc = " + _row_selected.Cells("col_id").Value
                    If BDHelper.getDBHelper.EjecutarSQL(str_sql) > 0 Then
                        MessageBox.Show("Sucursal Habilitada/Deshabilitada!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Dispose()
                    Else
                        MessageBox.Show("Error al actualizar la sucursal!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
        End Select
    End Sub

    Public Sub seleccionar_sucursal(ByVal op As Opcion, ByVal row_selected As DataGridViewRow)
        _action = op
        _row_selected = row_selected
    End Sub

    Private Function validar_campos() As Boolean
        'campos obligatorios
        If txt_descripcion.Text = String.Empty Then
            MessageBox.Show("Ingresar nombre", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_descripcion.Focus()
            Return False
        Else
            txt_descripcion.BackColor = Color.White
        End If

        If txt_calle.Text = String.Empty Then
            MessageBox.Show("Ingresar calle", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_calle.Focus()
            Return False
        Else
            txt_calle.BackColor = Color.White
        End If

        If txt_nro_calle.Text = String.Empty Then
            MessageBox.Show("Ingresar numero calle", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_nro_calle.Focus()
            Return False
        Else
            txt_nro_calle.BackColor = Color.White
        End If

        If txt_tel.Text = String.Empty Then
            MessageBox.Show("Ingresar telefono", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_tel.Focus()
            Return False
        Else
            txt_tel.BackColor = Color.White
        End If

        Return True
    End Function

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Dispose()
    End Sub
End Class
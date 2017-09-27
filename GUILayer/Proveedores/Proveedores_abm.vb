Public Class Proveedores_abm
    Enum Opcion
        insert
        update
        delete
    End Enum

    Private _action As Opcion = Opcion.insert
    Private _row_selected As DataGridViewRow

    Private Sub Proveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Frm_Repuestos.llenarCombo(cbo_tipo, BDHelper.getDBHelper.ConsultaSQL("select * from Tipo_proveedor"), "n_tipo", "id_tipo")
        Select Case _action
            Case Opcion.insert
                Me.Text = "Nuevo Proveedor"
                _row_selected = Nothing

            Case Opcion.update
                Me.Text = "Actualizar Proveedor"
                'Recuperar repuesto seleccionado en la grilla 
                mostrar_datos()
                txt_razon.Enabled = True
                txt_calle.Enabled = True
                txt_nro_calle.Enabled = True
                txt_tel.Enabled = True
                txt_mail.Enabled = True
                cbo_tipo.Enabled = True




            Case Opcion.delete
                mostrar_datos()
                Me.Text = "Habilitar/Deshabilitar Proveedor"
                txt_razon.Enabled = False
                txt_calle.Enabled = False
                txt_nro_calle.Enabled = False
                txt_tel.Enabled = False
                txt_mail.Enabled = False
                cbo_tipo.Enabled = False

        End Select
    End Sub

    Friend Sub mostrar_datos()
        If Not IsNothing(_row_selected) Then

            txt_razon.Text = _row_selected.Cells("col_razon_social").Value
            txt_calle.Text = _row_selected.Cells("col_calle").Value
            txt_nro_calle.Text = _row_selected.Cells("col_nro_calle").Value
            txt_mail.Text = _row_selected.Cells("col_mail").Value
            cbo_tipo.Text = _row_selected.Cells("col_tipo_prov").Value
            txt_tel.Text = _row_selected.Cells("col_tel").Value


        End If
    End Sub
    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        Dim str_sql As String = ""
        Dim estado As String


        Select Case _action
            Case Opcion.insert 'en el bdHelper hacemos BDHelper.getInstancia.EjecutarSql(sql_str)

                If validar_campos() Then 'cbo_perfil.SelectedValue.ToString seleccionamos el valor por detras del combo y lo transformamos en ToString  para que sean del mismo tipo antes y dsp del += me deje concatenar
                    str_sql = "INSERT INTO Proveedores (descripcion,calle,nro_calle,tel_prov,estado )VALUES ('"
                    str_sql += txt_razon.Text.ToString + "',"
                    str_sql += txt_calle.Text.ToString + ","
                    str_sql += txt_nro_calle.Text.ToString + ",'"
                    str_sql += txt_tel.Text.ToString + "',"
                    str_sql += "'H')"


                    If BDHelper.getDBHelper.EjecutarSQL(str_sql) > 0 Then
                        MessageBox.Show("Proveedor añadido!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Close()
                    End If
                End If



            Case Opcion.update
                If validar_campos() Then
                    str_sql = "UPDATE Proveedores SET descripcion='"
                    str_sql += txt_razon.Text.ToString + "', calle='"
                    str_sql += txt_calle.Text.ToString + "', nro_calle="
                    str_sql += txt_nro_calle.Text.ToString + ", tel_prov="
                    str_sql += txt_tel.Text.ToString + " WHERE (id_prov="
                    str_sql += _row_selected.Cells("col_id").Value.ToString + ")"
                    If BDHelper.getDBHelper.EjecutarSQL(str_sql) > 0 Then
                        MessageBox.Show("Proveedor modificada!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Dispose()
                    Else
                        MessageBox.Show("Error al actualizar el Proveedor!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If


            Case Opcion.delete
                If MessageBox.Show("Seguro que desea habilitar/deshabilitar la Proveedor seleccionada?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                    estado = BDHelper.getDBHelper.ConsultaSQL("Select estado from Proveedores where id_prov = " + _row_selected.Cells("col_id").Value).Rows(0).Item("estado")
                    If estado = "H" Then
                        estado = "D"
                    Else
                        estado = "H"
                    End If
                    str_sql = "UPDATE Proveedores SET estado = '" + estado + "' WHERE id_prov = " + _row_selected.Cells("col_id").Value
                    If BDHelper.getDBHelper.EjecutarSQL(str_sql) > 0 Then
                        MessageBox.Show("Proveedor Habilitada/Deshabilitada!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Dispose()
                    Else
                        MessageBox.Show("Error al actualizar el Proveedor!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
        End Select
    End Sub

    Public Sub seleccionar_Proveedor(ByVal op As Opcion, ByVal row_selected As DataGridViewRow)
        _action = op
        _row_selected = row_selected
    End Sub

    Private Function validar_campos() As Boolean
        'campos obligatorios
        If txt_razon.Text = String.Empty Then
            MessageBox.Show("Ingresar nombre", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_razon.Focus()
            Return False
        Else
            txt_razon.BackColor = Color.White
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
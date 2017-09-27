Public Class Clientes_abm
    Enum Opcion
        insert
        update
        delete
    End Enum

    Private _action As Opcion = Opcion.insert
    Private _row_selected As DataGridViewRow

    Public Sub seleccionar_cliente(ByVal op As Opcion, ByVal row_selected As DataGridViewRow)
        _action = op
        _row_selected = row_selected
    End Sub

    Friend Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Frm_Repuestos.llenarCombo(cbo_tipo_doc, BDHelper.getDBHelper.ConsultaSQL("SELECT * From Tipo_doc "), "n_tipo", "id_tipo")

        Select Case _action
            Case Opcion.insert
                Me.Text = "Nuevo Cliente"
                _row_selected = Nothing

            Case Opcion.update
                Me.Text = "Actualizar Cliente"
                'Recuperar repuesto seleccionado en la grilla 
                mostrarDatos()
                cbo_tipo_doc.Enabled = True
                txt_fecha_alta.Enabled = True
                txt_fecha_nac.Enabled = True
                txt_mail.Enabled = True
                txt_nombre.Enabled = True
                txt_nro_doc.Enabled = True
                txt_obs.Enabled = True
                txt_tel.Enabled = True


            Case Opcion.delete
                Me.mostrarDatos()
                Me.Text = "Habilitar/Deshabilitar Cliente"
                cbo_tipo_doc.Enabled = False
                txt_fecha_alta.Enabled = False
                txt_fecha_nac.Enabled = False
                txt_mail.Enabled = False
                txt_nombre.Enabled = False
                txt_nro_doc.Enabled = False
                txt_obs.Enabled = False
                txt_tel.Enabled = False
        End Select
    End Sub

    Friend Sub mostrarDatos()
        If Not IsNothing(_row_selected) Then
            cbo_tipo_doc.Text = _row_selected.Cells("col_tipo_doc").Value
            txt_nro_doc.Text = _row_selected.Cells("col_doc").Value
            txt_nombre.Text = _row_selected.Cells("col_nombre").Value
            txt_mail.Text = _row_selected.Cells("col_mail").Value
            txt_tel.Text = _row_selected.Cells("col_tel").Value

            txt_fecha_alta.Text = _row_selected.Cells("col_alta").Value
            txt_fecha_nac.Text = _row_selected.Cells("col_fecha_nac").Value
            txt_obs.Text = _row_selected.Cells("col_obs").Value
        End If
    End Sub
    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        Dim str_sql As String = ""
        Dim estado As String


        Select Case _action
            Case Opcion.insert 'en el bdHelper hacemos BDHelper.getInstancia.EjecutarSql(sql_str)
                If existe_doc() = False Then
                    If validar_campos() Then 'cbo_perfil.SelectedValue.ToString seleccionamos el valor por detras del combo y lo transformamos en ToString  para que sean del mismo tipo antes y dsp del += me deje concatenar
                        str_sql = "INSERT INTO Clientes(tipo_doc,doc ,nombre , mail , estado ,fecha_nacimiento , fecha_alta,observaciones, tel_contacto) VALUES("
                       
                        str_sql += cbo_tipo_doc.SelectedValue.ToString + ","
                        str_sql += txt_nro_doc.Text.ToString + ",'"
                        str_sql += txt_nombre.Text.ToString + "','"
                        str_sql += txt_mail.Text.ToString + "',"
                        str_sql += "'H','"
                        str_sql += txt_fecha_nac.Text.ToString + "','"
                        str_sql += txt_fecha_alta.Text.ToString + "','"
                        str_sql += txt_obs.Text.ToString + "',"
                        str_sql += txt_tel.Text.ToString + ")"

                        MsgBox(str_sql)
                        If BDHelper.getDBHelper.EjecutarSQL(str_sql) > 0 Then
                            MessageBox.Show("Cliente añadido!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Me.Close()
                        End If
                    End If
                Else
                    MessageBox.Show("Cliente ya existente!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If


            Case Opcion.update
                If validar_campos() Then
                    str_sql = "UPDATE Clientes SET nombre= '"
                    str_sql += txt_nombre.Text.ToString + "', tipo_doc="
                    str_sql += cbo_tipo_doc.SelectedValue.ToString + ", doc='"
                    str_sql += txt_nro_doc.Text.ToString + "', fecha_alta='"
                    str_sql += txt_fecha_alta.Text.ToString + "', mail='"
                    str_sql += txt_mail.Text.ToString + "', fecha_nacimiento ='"
                    str_sql += txt_fecha_nac.Text.ToString + "',observaciones='"
                    str_sql += txt_obs.Text.ToString + "', tel_contacto="
                    str_sql += txt_tel.Text.ToString + " WHERE (doc="
                    str_sql += _row_selected.Cells("col_doc").Value.ToString + ")"
                    If BDHelper.getDBHelper.EjecutarSQL(str_sql) > 0 Then
                        MessageBox.Show("Cliente modificado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Dispose()
                    Else
                        MessageBox.Show("Error al actualizar el cliente!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If


            Case Opcion.delete
                If MessageBox.Show("Seguro que desea habilitar/deshabilitar el cliente seleccionado?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                    estado = BDHelper.getDBHelper.ConsultaSQL("Select estado from Clientes where doc = " + _row_selected.Cells("col_doc").Value).Rows(0).Item("estado")
                    If estado = "H" Then
                        estado = "D"
                    Else
                        estado = "H"
                    End If
                    str_sql = "UPDATE Clientes SET estado = '" + estado + "' WHERE (doc = " + _row_selected.Cells("col_doc").Value + ")"
                    If BDHelper.getDBHelper.EjecutarSQL(str_sql) > 0 Then
                        MessageBox.Show("Cliente Habilitado/Deshabilitado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Dispose()
                    Else
                        MessageBox.Show("Error al actualizar el cliente!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
        End Select
    End Sub

    Private Function validar_campos() As Boolean
        'campos obligatorios
        If cbo_tipo_doc.Text = String.Empty Then
            MessageBox.Show("Ingresar tipo de documento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cbo_tipo_doc.Focus()
            Return False
        Else
            cbo_tipo_doc.BackColor = Color.White
        End If

        If txt_nro_doc.Text = String.Empty Then
            MessageBox.Show("Ingresar numero de documento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_nro_doc.Focus()
            Return False
        Else
            txt_nro_doc.BackColor = Color.White
        End If

        If txt_nombre.Text = String.Empty Then
            MessageBox.Show("Ingresar nombre", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_nombre.Focus()
            Return False
        Else
            txt_nombre.BackColor = Color.White
        End If

       

        If txt_fecha_alta.Text = String.Empty Then
            MessageBox.Show("Ingresar fecha de alta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_fecha_alta.Focus()
            Return False
        Else
            txt_fecha_alta.BackColor = Color.White
        End If

        If txt_fecha_nac.Text = String.Empty Then
            MessageBox.Show("Ingresar fecha de nacimiento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_fecha_nac.Focus()
            Return False
        Else
            txt_fecha_nac.BackColor = Color.White
        End If
        Return True
    End Function

    Private Function existe_doc() As Boolean
        Return BDHelper.getDBHelper.ConsultaSQL("select * from Clientes where doc =" + txt_nro_doc.Text + "AND tipo_doc=" + cbo_tipo_doc.SelectedValue.ToString).Rows.Count > 0
    End Function

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Dispose()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
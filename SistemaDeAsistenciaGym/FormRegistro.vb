Imports MySql.Data.MySqlClient
Public Class FormRegistro
    Private vista As New DataView
    Public Property accion As Boolean
    Public Property idFila As String


    Private Sub FormRegistro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormInicial.Hide()
        CargaInicial()
    End Sub
    Sub activarTextBox(ByVal activo As Boolean)
        If activo = True Then

            tbNombre.Enabled = True
            tbApellido.Enabled = True
            tbDni.Enabled = True
            tbEdad.Enabled = True
            tbDireccion.Enabled = True
            tbTelefono.Enabled = True
            tbEmail.Enabled = True

        Else

            tbNombre.Enabled = False
            tbApellido.Enabled = False
            tbDni.Enabled = False
            tbEdad.Enabled = False
            tbDireccion.Enabled = False
            tbTelefono.Enabled = False
            tbEmail.Enabled = False
        End If
    End Sub
    Sub cancelar()
        activarTextBox(False)
        btnNuevo.Enabled = True
        btnEditar.Enabled = True
        btnGuardar.Enabled = False
        btnBorrar.Enabled = True
        btnCancelar.Enabled = False

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        accion = True
        activarTextBox(True)
        btnEditar.Enabled = False
        btnBorrar.Enabled = False
        btnCancelar.Enabled = True
        btnGuardar.Enabled = True
        Btnqr.Enabled = True
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        cancelar()
    End Sub

    Private Sub Btnqr_Click(sender As Object, e As EventArgs) Handles Btnqr.Click
        FormCodigoQr.Show()
    End Sub
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        FormInicial.Show()
        Me.Hide()
    End Sub

    Private Sub pbFoto1_Click(sender As Object, e As EventArgs) Handles pbFoto1.Click
        FormFoto.Show()
    End Sub
    Public Sub CargaInicial()
        conectarse()
        FormInicial.erbpilatesDataSet.Tables("Alumno").Clear()
        FormInicial.alumnoDataAdapter.SelectCommand = New MySqlCommand("SELECT * FROM alumno", conexion)
        FormInicial.alumnoDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey
        FormInicial.alumnoDataAdapter.Fill(FormInicial.erbpilatesDataSet.Tables("Alumno"))
        vista = FormInicial.erbpilatesDataSet.Tables("Alumno").DefaultView
        dgvListado.DataSource = vista
        dgvListado.Columns(0).Visible = False
        dgvListado.Columns(8).Visible = False
        dgvListado.Columns(9).Visible = False
        dgvListado.ClearSelection()
        desconectarse()
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        If (MessageBox.Show("Está seguro de borrar este cliente?", "Borrar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) = DialogResult.Yes) Then
            Try
                FormInicial.erbpilatesDataSet.Tables("alumno").Rows.Find(idFila).Delete()
                FormInicial.alumnoDataAdapter.DeleteCommand = New MySqlCommand("DELETE FROM alumno WHERE id_alumno= @id", conexion)
                FormInicial.alumnoDataAdapter.DeleteCommand.Parameters.Add("@id_alumno", MySqlDbType.Int32, 0, "id")
                FormInicial.alumnoDataAdapter.Update(FormInicial.erbpilatesDataSet.Tables("Alumno"))

            Catch ex As Exception
                MsgBox(ex)
                MsgBox("No se puede borrar porque el cliente tiene ventas relacionadas")
            End Try
        End If
        dgvListado.CurrentCell = dgvListado.Rows(0).Cells(1)
        idFila = dgvListado.CurrentRow.Cells(0).Value
    End Sub
    Private Sub dgvListado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListado.CellClick
        dgvListado.Columns(0).Visible = False

    End Sub
    Private Sub tbBuscar_TextChanged(sender As Object, e As EventArgs) Handles tbBuscar.TextChanged
        vista.RowFilter = cbBuscarCampo.Text & " LIKE '" + tbBuscar.Text + "%'"
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim fila As DataRow
        Dim consulta As String

        Try
            If accion = True Then
                '1. Crear una nueva fila'
                fila = FormInicial.erbpilatesDataSet.Tables("Alumno").NewRow

                '2. Rellenar la fila con información
                fila("nombre") = tbNombre.Text
                fila("apellido") = tbApellido.Text
                fila("dni") = tbDni.Text
                fila("edad") = tbEdad.Text
                fila("direccion") = tbDireccion.Text
                fila("telefono") = tbTelefono.Text
                fila("email") = tbEmail.Text

                '3. Agregar fila a la tabla del DataSet
                FormInicial.erbpilatesDataSet.Tables("alumno").Rows.Add(fila)

                '4. Crear Comando para agregar a la BD la fila nueva

                consulta = "INSERT INTO alumno (nombre, apellido,dni, edad, direccion ,telefono,email) VALUES ( @nom, @ape,@dni, @ed,@dir,@tel,@em)"
                FormInicial.alumnoDataAdapter.InsertCommand = New MySqlCommand(consulta, conexion)
                FormInicial.alumnoDataAdapter.InsertCommand.Parameters.Add("@nom", MySqlDbType.VarChar, 45, "nombre")
                FormInicial.alumnoDataAdapter.InsertCommand.Parameters.Add("@ape", MySqlDbType.VarChar, 45, "apellido")
                FormInicial.alumnoDataAdapter.InsertCommand.Parameters.Add("@dni", MySqlDbType.Int32, 0, "dni")
                FormInicial.alumnoDataAdapter.InsertCommand.Parameters.Add("@ed", MySqlDbType.Int32, 0, "edad")
                FormInicial.alumnoDataAdapter.InsertCommand.Parameters.Add("@dir", MySqlDbType.VarChar, 100, "direccion")
                FormInicial.alumnoDataAdapter.InsertCommand.Parameters.Add("@tel", MySqlDbType.Int32, 11, "telefono")
                FormInicial.alumnoDataAdapter.InsertCommand.Parameters.Add("@em", MySqlDbType.VarChar, 45, "email")

                '5. Guardar los cambios en la base de datos
                FormInicial.alumnoDataAdapter.Update(FormInicial.erbpilatesDataSet.Tables("alumno"))

                '6. Actualiza la tabla del formulario listado de clientes
                CargaInicial()

                'Limpiamos los textbox para poder cargar otro cliente            
                tbNombre.Text = ""
                tbApellido.Text = ""
                tbDni.Text = ""
                tbEdad.Text = ""
                tbDireccion.Text = ""
                tbTelefono.Text = ""
                tbEmail.Text = ""

            Else
                '1. Seleccionar fila a editar
                fila = FormInicial.erbpilatesDataSet.Tables("alumno").Rows.Find(idFila)



                '2. Rellenar la fila con información   
                fila("Nombre") = tbNombre.Text
                fila("apellido") = tbApellido.Text
                fila("dni") = tbDni.Text
                fila("edad") = tbEdad.Text
                fila("direccion") = tbDireccion.Text
                fila("telefono") = tbTelefono.Text
                fila("email") = tbEmail.Text


                '3. Crear Comando para modificar la fila en la BD

                consulta = "UPDATE alumno SET nombre=@nom, apellido=@ape, dni=@dni ,edad=@ed, direccion =@dir, telefono=@tel, email =@em WHERE id_alumno=@id"
                FormInicial.alumnoDataAdapter.UpdateCommand = New MySqlCommand(consulta, conexion)
                FormInicial.alumnoDataAdapter.UpdateCommand.Parameters.Add("@nom", MySqlDbType.VarChar, 45, "nombre")
                FormInicial.alumnoDataAdapter.UpdateCommand.Parameters.Add("@ape", MySqlDbType.VarChar, 45, "apellido")
                FormInicial.alumnoDataAdapter.UpdateCommand.Parameters.Add("@dni", MySqlDbType.Int32, 0, "dni")
                FormInicial.alumnoDataAdapter.UpdateCommand.Parameters.Add("@ed", MySqlDbType.Int32, 0, "edad")
                FormInicial.alumnoDataAdapter.UpdateCommand.Parameters.Add("@dir", MySqlDbType.VarChar, 100, "direccion")
                FormInicial.alumnoDataAdapter.UpdateCommand.Parameters.Add("@tel", MySqlDbType.Int32, 11, "telefono")
                FormInicial.alumnoDataAdapter.UpdateCommand.Parameters.Add("@em", MySqlDbType.VarChar, 45, "email")

                FormInicial.alumnoDataAdapter.UpdateCommand.Parameters.Add("@id", MySqlDbType.Int32, 0, "id_alumno")

                '4. Guardar los cambios en la base de datos
                FormInicial.alumnoDataAdapter.Update(FormInicial.erbpilatesDataSet.Tables("alumno"))
                '5. Actualiza la tabla del formulario listado de clientes
                CargaInicial()
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("Error espacio en blanco", MsgBoxStyle.Critical)

        End Try
    End Sub

    Private Sub dgvListado2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListado2.CellContentClick

    End Sub
End Class
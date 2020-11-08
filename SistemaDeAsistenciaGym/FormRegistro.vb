Imports MySql.Data.MySqlClient
Public Class FormRegistro
    Private vista As New DataView
    Public Property accion As Boolean
    Public Property idFila As String


    Private Sub FormRegistro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormInicial.Hide()
        CargaInicial()

    End Sub
    Public Sub CargaInicial()
        '-------Alumno----------'
        conectarse()
        FormInicial.erbpilatesDataSet.Tables("Alumno").Clear()
        FormInicial.alumnoDataAdapter.SelectCommand = New MySqlCommand("SELECT *FROM alumno", conexion)
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
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        accion = True
        activarTextBox(True)
        btnEditar.Enabled = False
        btnBorrar.Enabled = False
        btnCancelar.Enabled = True
        btnGuardar.Enabled = True
        'Btnqr.Enabled = True
    End Sub
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        activarTextBox(True)
        btnNuevo.Enabled = False
        btnEditar.Enabled = False
        btnBorrar.Enabled = False
        btnGuardar.Enabled = True
        btnCancelar.Enabled = True
        accion = False
        cargarTextBox()

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
    Sub cargarTextBox()
        Dim fila As DataGridViewRow = dgvListado.CurrentRow
        idFila = fila.Cells(0).Value
        tbNombre.Text = fila.Cells(1).Value
        tbApellido.Text = fila.Cells(2).Value
        tbDni.Text = fila.Cells(3).Value
        tbEdad.Text = fila.Cells(4).Value
        tbDireccion.Text = fila.Cells(5).Value
        tbTelefono.Text = fila.Cells(6).Value
        tbEmail.Text = fila.Cells(7).Value
        'pbFoto1.Image = fila.Cells(9).Value


    End Sub

    Sub cancelar()
        activarTextBox(False)
        btnNuevo.Enabled = True
        btnEditar.Enabled = True
        btnGuardar.Enabled = False
        btnBorrar.Enabled = True
        btnCancelar.Enabled = False
        tbNombre.Text = ""
        tbApellido.Text = ""
        tbDni.Text = ""
        tbDireccion.Text = ""
        tbEdad.Text = ""
        tbTelefono.Text = ""
        tbEmail.Text = ""
        Btnqr.Enabled = False
    End Sub


    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        cancelar()
    End Sub

    Private Sub Btnqr_Click(sender As Object, e As EventArgs) Handles Btnqr.Click
        FormCodigoQr.Show()
    End Sub


    Private Sub pbFoto1_Click(sender As Object, e As EventArgs) Handles pbFoto1.Click
        FormFoto.Show()
    End Sub

    Private Sub dgvListado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListado.CellClick
        dgvListado.Columns(0).Visible = False

    End Sub




    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Dim consulta As String
        Dim repetido As Integer = 0
        Dim fila As DataRow
        Try
            If accion = True Then
                Dim filadni As DataGridViewRow = New DataGridViewRow
                Dim documento As String
                For Each filadni In dgvListado.Rows
                    documento = (filadni.Cells("DNI").Value)
                    If tbDni.Text = documento Then
                        MsgBox("DNI Ya registrado, vuelva a intentarlo.")
                        repetido = 1
                        cancelar()
                    End If
                Next

                If repetido = 0 Then
                    '1. Crear una nueva fila'
                    fila = FormInicial.erbpilatesDataSet.Tables("Alumno").NewRow

                    '2. Rellenar la fila con información
                    fila("nombre") = tbNombre.Text
                    fila("apellido") = tbApellido.Text
                    fila("DNI") = tbDni.Text
                    fila("edad") = tbEdad.Text
                    fila("direccion") = tbDireccion.Text
                    fila("telefono") = tbTelefono.Text
                    fila("email") = tbEmail.Text
                    'fila("foto") = pbFoto1.Image

                    '3. Agregar fila a la tabla del DataSet
                    FormInicial.erbpilatesDataSet.Tables("alumno").Rows.Add(fila)

                    '4. Crear Comando para agregar a la BD la fila nueva

                    consulta = "INSERT INTO alumno (nombre, apellido,DNI, edad, direccion ,telefono,email) VALUES ( @nom, @ape,@dni, @ed,@dir,@tel,@em)"
                    FormInicial.alumnoDataAdapter.InsertCommand = New MySqlCommand(consulta, conexion)
                    FormInicial.alumnoDataAdapter.InsertCommand.Parameters.Add("@nom", MySqlDbType.VarChar, 45, "nombre")
                    FormInicial.alumnoDataAdapter.InsertCommand.Parameters.Add("@ape", MySqlDbType.VarChar, 45, "apellido")
                    FormInicial.alumnoDataAdapter.InsertCommand.Parameters.Add("@dni", MySqlDbType.Int32, 8, "DNI")
                    FormInicial.alumnoDataAdapter.InsertCommand.Parameters.Add("@ed", MySqlDbType.Int32, 2, "edad")
                    FormInicial.alumnoDataAdapter.InsertCommand.Parameters.Add("@dir", MySqlDbType.VarChar, 250, "direccion")
                    FormInicial.alumnoDataAdapter.InsertCommand.Parameters.Add("@tel", MySqlDbType.Int64, 10, "telefono")
                    FormInicial.alumnoDataAdapter.InsertCommand.Parameters.Add("@em", MySqlDbType.VarChar, 250, "email")
                    'FormInicial.alumnoDataAdapter.InsertCommand.Parameters.Add("@fot", MySqlDbType.Blob, "foto")

                    '5. Guardar los cambios en la base de datos
                    FormInicial.alumnoDataAdapter.Update(FormInicial.erbpilatesDataSet.Tables("alumno"))

                    '6. Actualiza la tabla del formulario listado de clientes
                    '6. Volver a cargar la tabla del dataset para obtener los ultimos cambios de la BD
                    'FormInicial.erbpilatesDataSet.Tables("alumno").Clear()
                    'FormInicial.alumnoDataAdapter.SelectCommand = New MySqlCommand("SELECT * FROM alumno", conexion)
                    'FormInicial.alumnoDataAdapter.Fill(FormInicial.erbpilatesDataSet.Tables("alumno"))

                    CargaInicial()

                    'Limpiamos los textbox para poder cargar otro cliente            
                    tbNombre.Text = ""
                    tbApellido.Text = ""
                    tbDni.Text = ""
                    tbEdad.Text = ""
                    tbDireccion.Text = ""
                    tbTelefono.Text = ""
                    tbEmail.Text = ""

                End If
            Else
                '1. Seleccionar fila a editar
                fila = FormInicial.erbpilatesDataSet.Tables("alumno").Rows.Find(idFila)


                '2. Rellenar la fila con información   
                fila("Nombre") = tbNombre.Text
                fila("apellido") = tbApellido.Text
                fila("DNI") = tbDni.Text
                fila("edad") = tbEdad.Text
                fila("direccion") = tbDireccion.Text
                fila("telefono") = tbTelefono.Text
                fila("email") = tbEmail.Text
                'fila("foto") = pbFoto1.Image

                '3. Crear Comando para modificar la fila en la BD

                consulta = "UPDATE alumno SET nombre=@nom, apellido=@ape, DNI=@dni ,edad=@ed, direccion =@dir, telefono=@tel, email =@em  WHERE id_alumno=@id"
                FormInicial.alumnoDataAdapter.UpdateCommand = New MySqlCommand(consulta, conexion)
                FormInicial.alumnoDataAdapter.UpdateCommand.Parameters.Add("@nom", MySqlDbType.VarChar, 45, "nombre")
                FormInicial.alumnoDataAdapter.UpdateCommand.Parameters.Add("@ape", MySqlDbType.VarChar, 45, "apellido")
                FormInicial.alumnoDataAdapter.UpdateCommand.Parameters.Add("@dni", MySqlDbType.Int32, 8, "DNI")
                FormInicial.alumnoDataAdapter.UpdateCommand.Parameters.Add("@ed", MySqlDbType.Int32, 2, "edad")
                FormInicial.alumnoDataAdapter.UpdateCommand.Parameters.Add("@dir", MySqlDbType.VarChar, 250, "direccion")
                FormInicial.alumnoDataAdapter.UpdateCommand.Parameters.Add("@tel", MySqlDbType.Int64, 10, "telefono")
                FormInicial.alumnoDataAdapter.UpdateCommand.Parameters.Add("@em", MySqlDbType.VarChar, 250, "email")
                'FormInicial.alumnoDataAdapter.InsertCommand.Parameters.Add("@fot", MySqlDbType.Blob, "foto")

                FormInicial.alumnoDataAdapter.UpdateCommand.Parameters.Add("@id", MySqlDbType.Int32, 0, "id_alumno")

                '4. Guardar los cambios en la base de datos
                FormInicial.alumnoDataAdapter.Update(FormInicial.erbpilatesDataSet.Tables("alumno"))
                '5. Actualiza la tabla del formulario listado de clientes
                CargaInicial()
                'Me.Close()
            End If

        Catch ex As Exception
            MsgBox("Error espacio en blanco", MsgBoxStyle.Critical)

        End Try

        cancelar()
    End Sub
    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        If (MessageBox.Show("Está seguro de borrar este cliente?", "Borrar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) = DialogResult.Yes) Then
            Try
                FormInicial.erbpilatesDataSet.Tables("alumno").Rows.Find(idFila).Delete()
                FormInicial.alumnoDataAdapter.DeleteCommand = New MySqlCommand("DELETE FROM alumno WHERE id_alumno = @id", conexion)
                FormInicial.alumnoDataAdapter.DeleteCommand.Parameters.Add("@id", MySqlDbType.Int32, 0, "id_alumno")
                FormInicial.alumnoDataAdapter.Update(FormInicial.erbpilatesDataSet.Tables("Alumno"))

            Catch ex As Exception
                MsgBox(ex)
                MsgBox("No se puede borrar porque el cliente tiene ventas relacionadas")
            End Try
        End If
        dgvListado.CurrentCell = dgvListado.Rows(0).Cells(1)
        idFila = dgvListado.CurrentRow.Cells(0).Value
        cancelar()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        FormEjercicio.ShowDialog()
    End Sub



    Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnRestaurar_Click(sender As Object, e As EventArgs) Handles btnRestaurar.Click
        btnRestaurar.Visible = False
        btnMax.Visible = True
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub btnMax_Click(sender As Object, e As EventArgs) Handles btnMax.Click
        btnMax.Visible = False
        btnRestaurar.Visible = True
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
        desconectarse()
        FormInicial.Show()
    End Sub

    Private Sub tbDni_TextChanged(sender As Object, e As EventArgs) Handles tbDni.TextChanged
        Btnqr.Enabled = True
    End Sub

    Private Sub tbBuscar_TextChanged(sender As Object, e As EventArgs) Handles tbBuscar.TextChanged
        vista.RowFilter = cbBuscarCampo.Text & " LIKE '" + tbBuscar.Text + "%'"
    End Sub

    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        OpenFileDialog1.InitialDirectory = "C:\Users\exequ\Documents\Imagix"
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            pbFoto1.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub dgvListado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListado.CellDoubleClick
        FormDatos.ShowDialog()
    End Sub
End Class
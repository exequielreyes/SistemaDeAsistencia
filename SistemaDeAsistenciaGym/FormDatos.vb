Imports MySql.Data.MySqlClient
Public Class FormDatos
    Private vista As New DataView
    Public Property accion As Boolean
    Public Property idFila As String
    Private Sub FormDatos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargaInicial()
        idFila = FormRegistro.dgvListado.CurrentRow.Cells(0).Value
        tbNombre.Text = FormRegistro.dgvListado.CurrentRow.Cells(1).Value
        tbApellido.Text = FormRegistro.dgvListado.CurrentRow.Cells(2).Value
    End Sub
    Public Sub CargaInicial()

        FormInicial.erbpilatesDataSet.Tables("capacidad").Clear()
        FormInicial.capacidadDataAdapter.SelectCommand = New MySqlCommand("SELECT capacidad.total as 'Total', capacidad.cantidad as 'Cantidad', DATE_FORMAT(turno.dia, '%W-%M-%Y') as 'Dia' , turno.hora FROM capacidad  INNER JOIN turno on capacidad.Turno_idTurno = turno.idTurno ", conexion)
        FormInicial.capacidadDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey
        FormInicial.capacidadDataAdapter.Fill(FormInicial.erbpilatesDataSet.Tables("capacidad"))
        vista = FormInicial.erbpilatesDataSet.Tables("capacidad").DefaultView
        dgvListado2.DataSource = vista
        dgvListado2.ClearSelection()


        '------Historia clinica y patologia-------'
        FormInicial.erbpilatesDataSet.Tables("Patologias").Clear()
        FormInicial.patologiasDataAdapter.SelectCommand = New MySqlCommand("SELECT  patologias.cardiacas as 'Cardiacas' , patologias.lesiones_recientes as 'Lesiones recientes', patologias.columna as 'Columna',patologias.otros as 'Otros', patologias.detalles as 'Detalles', historia_clinica.altura_cm as 'Altura(cm)',historia_clinica.peso as 'Peso', historia_clinica.grupo_sanguineo as 'Grupo sanguineo' FROM patologias INNER JOIN historia_clinica on patologias.idHistoria =historia_clinica.idHistoria_Clinica  ", conexion)
        FormInicial.patologiasDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey
        FormInicial.patologiasDataAdapter.Fill(FormInicial.erbpilatesDataSet.Tables("Patologias"))
        vista = FormInicial.erbpilatesDataSet.Tables("Patologias").DefaultView
        dgvListado3.DataSource = vista
        dgvListado3.Columns(0).Visible = False
        dgvListado3.ClearSelection()

        desconectarse()
    End Sub

    Private Sub btnGuardar2_Click(sender As Object, e As EventArgs) Handles btnGuardar2.Click
        Dim fila As DataRow
        Dim consulta As String

        'Try
        If accion = True Then
            '1. Crear una nueva fila'
            fila = FormInicial.erbpilatesDataSet.Tables("capacidad").NewRow

            '2. Rellenar la fila con información
            fila("dia") = cbDia.Text
            fila("hora") = cbHora.Text
            fila("clase_abonadas") = tbAbonadas.Text
            fila("total") = lbTotal.Text
            'fila("cantidad") = RbsemanaDos.Text & rbsemanaTres.Text & rbSemanaCuatro.Text


            '        '3. Agregar fila a la tabla del DataSet
            FormInicial.erbpilatesDataSet.Tables("capacidad").Rows.Add(fila)

            '4. Crear Comando para agregar a la BD la fila nueva


            consulta = "INSERT INTO capacidad , turno (total , cantidad, dia , hora ) VALUES ( @tot , @cant , @dia , @hor)"

            FormInicial.capacidadDataAdapter.InsertCommand = New MySqlCommand(consulta, conexion)

            FormInicial.capacidadDataAdapter.InsertCommand.Parameters.Add("@tot", MySqlDbType.Int32, 0, "total")
            FormInicial.capacidadDataAdapter.InsertCommand.Parameters.Add("@cant", MySqlDbType.Int32, 0, "cantidad")
            FormInicial.capacidadDataAdapter.InsertCommand.Parameters.Add("@dia", MySqlDbType.DateTime, "dia")
            FormInicial.capacidadDataAdapter.InsertCommand.Parameters.Add("@hor", MySqlDbType.Int32, 0, "hora")

            '5. Guardar los cambios en la base de datos
            FormInicial.capacidadDataAdapter.Update(FormInicial.erbpilatesDataSet.Tables("capacidad"))

            '6. Actualiza la tabla del formulario listado de clientes
            CargaInicial()

            '        'Limpiamos los textbox para poder cargar otro cliente            
            lbTotal.Text = ""
            'RbsemanaDos.Text = ""
            'rbsemanaTres.Text = ""
            'rbSemanaCuatro.Text = ""
            dtpFechaInicio.Refresh()
            cbHora.Text = ""

        Else
            '1. Seleccionar fila a editar
            fila = FormInicial.erbpilatesDataSet.Tables("capacidad").Rows.Find(idFila)



            '2. Rellenar la fila con información   
            fila("total") = lbTotal.Text
            'fila("cantidad") = RbsemanaDos.Text & rbsemanaTres.Text & rbSemanaCuatro.Text
            fila("dia") = dtpFechaInicio.ToString
            fila("hora") = cbHora.Text


            '3. Crear Comando para modificar la fila en la BD

            consulta = "UPDATE capacidad , turno SET total=@tot, cantidad=@cant, dia=@dia ,hora=@hor WHERE Turno_idTurno=@id"
            FormInicial.capacidadDataAdapter.UpdateCommand = New MySqlCommand(consulta, conexion)
            FormInicial.capacidadDataAdapter.UpdateCommand.Parameters.Add("@tot", MySqlDbType.Int32, 0, "total")
            FormInicial.capacidadDataAdapter.UpdateCommand.Parameters.Add("@cant", MySqlDbType.Int32, 0, "cantidad")
            FormInicial.capacidadDataAdapter.UpdateCommand.Parameters.Add("@dia", MySqlDbType.DateTime, "dia")
            FormInicial.capacidadDataAdapter.UpdateCommand.Parameters.Add("@hor", MySqlDbType.Int32, 0, "hora")
            FormInicial.capacidadDataAdapter.UpdateCommand.Parameters.Add("@id", MySqlDbType.Int32, 0, "Turno_idTurno")

            '        '4. Guardar los cambios en la base de datos
            FormInicial.capacidadDataAdapter.Update(FormInicial.erbpilatesDataSet.Tables("capacidad"))
            '        '5. Actualiza la tabla del formulario listado de clientes
            CargaInicial()
            Me.Close()
        End If
        'Catch ex As Exception
        '    MsgBox("Error espacio en blanco", MsgBoxStyle.Critical)

        'End Try
    End Sub
    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbClases.SelectedIndexChanged
        If cbClases.Text = "2 veces a la semana" Then
            lbTotal.Text = "400"
        ElseIf cbClases.Text = "3 veces a la semana" Then
            lbTotal.Text = "450"
        ElseIf cbClases.Text = "4 veces a la semana" Then
            lbTotal.Text = "500"
        End If
    End Sub

    Private Sub cbPatologia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPatologia.SelectedIndexChanged
        If cbPatologia.Text = "Si" Then
            rbDetalles.Enabled = True
            cbColumna.Enabled = True
            cbCardiaco.Enabled = True
            cbLesiones.Enabled = True
            cbOtros.Enabled = True
        Else
            cbPatologia.Text = "No"
            rbDetalles.Enabled = False
            cbColumna.Enabled = False
            cbCardiaco.Enabled = False
            cbLesiones.Enabled = False
            cbOtros.Enabled = False
        End If
    End Sub
End Class
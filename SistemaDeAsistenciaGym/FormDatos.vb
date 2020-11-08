Imports MySql.Data.MySqlClient
Public Class FormDatos
    Private vista As New DataView
    Public Property accion As Boolean
    Public Property idFila As String
    Private cmd As MySqlCommand
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

        Dim consulta As String

        Dim fila As DataRow

        'If accion = True Then


        '    '1. Crear una nueva fila'
        '    fila = FormInicial.erbpilatesDataSet.Tables("capacidad").NewRow

        '    fila("hora") = cbHora.Text
        '    fila("clase_abonadas") = tbAbonadas.Text
        '    fila("cantidad") = cbClases.Text
        '    fila("total") = lbTotal.Text



        '    '        '3. Agregar fila a la tabla del DataSet
        '    FormInicial.erbpilatesDataSet.Tables("capacidad").Rows.Add(fila)

        '    '4. Crear Comando para agregar a la BD la fila nueva


        '    consulta = "INSERT INTO capacidad (total , cantidad) VALUES ( @id, @tot , @cant)"


        '    FormInicial.capacidadDataAdapter.InsertCommand = New MySqlCommand(consulta, conexion)
        '    'FormInicial.capacidadDataAdapter.InsertCommand.Parameters.Add("@id", MySqlDbType.Int32, 0, "Alumno_id_alumno")
        '    FormInicial.capacidadDataAdapter.InsertCommand.Parameters.Add("@tot", MySqlDbType.Int32, 0, "total")
        '    FormInicial.capacidadDataAdapter.InsertCommand.Parameters.Add("@cant", MySqlDbType.Int32, 0, "cantidad")
        '    'FormInicial.capacidadDataAdapter.InsertCommand.Parameters.Add("@dia", MySqlDbType.DateTime, "dia")
        '    'FormInicial.capacidadDataAdapter.InsertCommand.Parameters.Add("@hor", MySqlDbType.Int32, 0, "hora")

        '    '5. Guardar los cambios en la base de datos
        '    FormInicial.capacidadDataAdapter.Update(FormInicial.erbpilatesDataSet.Tables("capacidad"))

        '    '6. Actualiza la tabla del formulario listado de clientes
        '    CargaInicial()

        '    '        'Limpiamos los textbox para poder cargar otro cliente            
        '    lbTotal.Text = ""
        '    cbClases.Text = ""

        'Else
        '    '1. Seleccionar fila a editar
        '    'fila = FormInicial.erbpilatesDataSet.Tables("capacidad").Rows.Find(idFila)



        '    '2. Rellenar la fila con información   
        '    fila("total") = lbTotal.Text
        'fila("cantidad") = cbClases.Text

        ''3. Crear Comando para modificar la fila en la BD

        'consulta = "UPDATE capacidad SET total=@tot, cantidad=@cant WHERE Alumno_id_alumno=@id"
        'FormInicial.capacidadDataAdapter.UpdateCommand = New MySqlCommand(consulta, conexion)
        'FormInicial.capacidadDataAdapter.UpdateCommand.Parameters.Add("@tot", MySqlDbType.Int32, 0, "total")
        'FormInicial.capacidadDataAdapter.UpdateCommand.Parameters.Add("@cant", MySqlDbType.Int32, 0, "cantidad")
        ''FormInicial.capacidadDataAdapter.UpdateCommand.Parameters.Add("@dia", MySqlDbType.DateTime, "dia")
        ''FormInicial.capacidadDataAdapter.UpdateCommand.Parameters.Add("@hor", MySqlDbType.Int32, 0, "hora")
        'FormInicial.capacidadDataAdapter.UpdateCommand.Parameters.Add("@id", MySqlDbType.Int32, 0, "Alumno_id_alumno")

        ''        '4. Guardar los cambios en la base de datos
        'FormInicial.capacidadDataAdapter.Update(FormInicial.erbpilatesDataSet.Tables("capacidad"))
        ''        '5. Actualiza la tabla del formulario listado de clientes
        'CargaInicial()
        'Me.Close()
        'End If
        'Catch ex As Exception
        '    MsgBox("Error espacio en blanco", MsgBoxStyle.Critical)

        'End Try
    End Sub
    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbClases.SelectedIndexChanged
        If cbClases.Text = "2 veces a la semana" Then
            lbTotal.Text = "1100"
        ElseIf cbClases.Text = "3 veces a la semana" Then
            lbTotal.Text = "1300"
        ElseIf cbClases.Text = "4 veces a la semana" Then
            lbTotal.Text = "1500"
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
    Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
        desconectarse()
        FormRegistro.Show()
    End Sub

    Private Sub btnMax_Click(sender As Object, e As EventArgs) Handles btnMax.Click
        btnMax.Visible = False
        btnRestaurar.Visible = True
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnRestaurar_Click(sender As Object, e As EventArgs) Handles btnRestaurar.Click
        btnRestaurar.Visible = False
        btnMax.Visible = True
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        CheckBox1.Enabled = True
        CheckBox2.Enabled = True
        CheckBox3.Enabled = True
        CheckBox4.Enabled = True
        CheckBox5.Enabled = True

        If ComboBox1.Text = "Piernas" Then
            CheckBox1.Text = "Reformer con sogas y tabla de pique"
            CheckBox2.Text = "Cadillac con resorte para resistencia"
            CheckBox3.Text = "Parado con resortes cortos para gluteos"
            CheckBox4.Visible = False
            CheckBox5.Visible = False

        ElseIf ComboBox1.Text = "Bíceps" Then
            CheckBox1.Text = "Reformer en decubito dorsal"
            CheckBox2.Text = "reformer en box o cajon"
            CheckBox3.Text = "combinados de sogas y mancuernas"
            CheckBox4.Visible = False
            CheckBox5.Visible = False

        ElseIf ComboBox1.Text = "Tríceps" Then
            CheckBox4.Visible = True
            CheckBox5.Visible = True
            CheckBox1.Text = "Reformer en decubito dorsal"
            CheckBox2.Text = "Reformer con box invertido y con soga"
            CheckBox3.Text = "Reformer con box sin asistencia"
            CheckBox4.Text = "Reformer con box combinados con oblicuos"
            CheckBox5.Text = "Reformer con combo chair combinados con biceps"

        ElseIf ComboBox1.Text = "Espalda" Then
            CheckBox1.Text = "Reformer en decubito dorsal"
            CheckBox2.Text = "Sentado en box y sogas"
            CheckBox3.Text = "Cadillac en suspension sobre trapecio"
            CheckBox4.Text = "Laddel Barrel"
            CheckBox5.Text = "Combo chair"

        ElseIf ComboBox1.Text = "Pecho" Then
            CheckBox1.Text = "Reformer en decubito dorsal"
            CheckBox2.Text = "box y sogas"
            CheckBox3.Text = "Cadillac, suspendido en trapecio"
            CheckBox4.Text = "Combo Chair combinado con biceps y triceps"
            CheckBox5.Visible = False

        ElseIf ComboBox1.Text = "Elongación" Then
            CheckBox1.Text = "Reformer con sogas para piernas"
            CheckBox2.Text = "Reformer sin asistencia"
            CheckBox3.Text = "Cadillac sin asistencia"
            CheckBox4.Text = "Laddel Barrel para columna vertebral"
            CheckBox5.Visible = False

        ElseIf ComboBox1.Text = "Pelota" Then
            CheckBox5.Visible = True
            CheckBox1.Text = "Como elemento complementario para piernas"
            CheckBox2.Text = "Como elemento complementario en cadillac para brazos"
            CheckBox3.Text = "Sola contra de la pared en trabajo para piernas"
            CheckBox4.Text = "Complemento con combo chair para trabajo de pecho"
            CheckBox5.Text = "Para elongacion integral para abdominales"

        ElseIf ComboBox1.Text = "Abdominales" Then
            CheckBox5.Visible = True
            CheckBox1.Text = "En reformer simple"
            CheckBox2.Text = "Reformer con piernas sujetada, con soga, invertido"
            CheckBox3.Text = "En cadillac suspendidos y con asistenci"
            CheckBox4.Text = "En laddel Barrel de frente e invertido"
            CheckBox5.Text = "En combo Chair de frente"
        End If

    End Sub

    Private Sub CheckBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles CheckBox1.MouseMove

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        If ComboBox1.Text = "Piernas" Then

            If CheckBox1.Checked = True Then

                pbEjercicios.Visible = True
            Else

                pbEjercicios.Visible = False

            End If
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged

        If CheckBox2.Checked = True Then

            pbEjercicio2.Visible = True
        Else

            pbEjercicio2.Visible = False

        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then

            pbEjercicio3.Visible = True
        Else

            pbEjercicio3.Visible = False

        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged


        If ComboBox1.Text = "Piernas" Then
            CheckBox1.Text = "Reformer con sogas y tabla de pique"
            CheckBox2.Text = "Cadillac con resorte para resistencia"
            CheckBox3.Text = "Parado con resortes cortos para gluteos"
            CheckBox4.Visible = False
            CheckBox5.Visible = False

        ElseIf ComboBox1.Text = "Bíceps" Then
            CheckBox1.Text = "Reformer en decubito dorsal"
            CheckBox2.Text = "reformer en box o cajon"
            CheckBox3.Text = "combinados de sogas y mancuernas"
            CheckBox4.Visible = False
            CheckBox5.Visible = False

        ElseIf ComboBox1.Text = "Tríceps" Then
            CheckBox4.Visible = True
            CheckBox5.Visible = True
            CheckBox1.Text = "Reformer en decubito dorsal"
            CheckBox2.Text = "Reformer con box invertido y con soga"
            CheckBox3.Text = "Reformer con box sin asistencia"
            CheckBox4.Text = "Reformer con box combinados con oblicuos"
            CheckBox5.Text = "Reformer con combo chair combinados con biceps"

        ElseIf ComboBox1.Text = "Espalda" Then
            CheckBox1.Text = "Reformer en decubito dorsal"
            CheckBox2.Text = "Sentado en box y sogas"
            CheckBox3.Text = "Cadillac en suspension sobre trapecio"
            CheckBox4.Text = "Laddel Barrel"
            CheckBox5.Text = "Combo chair"

        ElseIf ComboBox1.Text = "Pecho" Then
            CheckBox1.Text = "Reformer en decubito dorsal"
            CheckBox2.Text = "box y sogas"
            CheckBox3.Text = "Cadillac, suspendido en trapecio"
            CheckBox4.Text = "Combo Chair combinado con biceps y triceps"
            CheckBox5.Visible = False

        ElseIf ComboBox1.Text = "Elongación" Then
            CheckBox1.Text = "Reformer con sogas para piernas"
            CheckBox2.Text = "Reformer sin asistencia"
            CheckBox3.Text = "Cadillac sin asistencia"
            CheckBox4.Text = "Laddel Barrel para columna vertebral"
            CheckBox5.Visible = False

        ElseIf ComboBox1.Text = "Pelota" Then
            CheckBox5.Visible = True
            CheckBox1.Text = "Como elemento complementario para piernas"
            CheckBox2.Text = "Como elemento complementario en cadillac para brazos"
            CheckBox3.Text = "Sola contra de la pared en trabajo para piernas"
            CheckBox4.Text = "Complemento con combo chair para trabajo de pecho"
            CheckBox5.Text = "Para elongacion integral para abdominales"

        ElseIf ComboBox1.Text = "Abdominales" Then
            CheckBox5.Visible = True
            CheckBox1.Text = "En reformer simple"
            CheckBox2.Text = "Reformer con piernas sujetada, con soga, invertido"
            CheckBox3.Text = "En cadillac suspendidos y con asistenci"
            CheckBox4.Text = "En laddel Barrel de frente e invertido"
            CheckBox5.Text = "En combo Chair de frente"
        End If

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        ComboBox2.Enabled = False
        If ComboBox1.Text = "Piernas" Then
            CheckBox1.Text = "Reformer con sogas y tabla de pique"
            CheckBox2.Text = "Cadillac con resorte para resistencia"
            CheckBox3.Text = "Parado con resortes cortos para gluteos"
            CheckBox4.Visible = False
            CheckBox5.Visible = False

        ElseIf ComboBox1.Text = "Bíceps" Then
            CheckBox1.Text = "Reformer en decubito dorsal"
            CheckBox2.Text = "reformer en box o cajon"
            CheckBox3.Text = "combinados de sogas y mancuernas"
            CheckBox4.Visible = False
            CheckBox5.Visible = False

        ElseIf ComboBox1.Text = "Tríceps" Then
            CheckBox4.Visible = True
            CheckBox5.Visible = True
            CheckBox1.Text = "Reformer en decubito dorsal"
            CheckBox2.Text = "Reformer con box invertido y con soga"
            CheckBox3.Text = "Reformer con box sin asistencia"
            CheckBox4.Text = "Reformer con box combinados con oblicuos"
            CheckBox5.Text = "Reformer con combo chair combinados con biceps"

        ElseIf ComboBox1.Text = "Espalda" Then
            CheckBox1.Text = "Reformer en decubito dorsal"
            CheckBox2.Text = "Sentado en box y sogas"
            CheckBox3.Text = "Cadillac en suspension sobre trapecio"
            CheckBox4.Text = "Laddel Barrel"
            CheckBox5.Text = "Combo chair"

        ElseIf ComboBox1.Text = "Pecho" Then
            CheckBox1.Text = "Reformer en decubito dorsal"
            CheckBox2.Text = "box y sogas"
            CheckBox3.Text = "Cadillac, suspendido en trapecio"
            CheckBox4.Text = "Combo Chair combinado con biceps y triceps"
            CheckBox5.Visible = False

        ElseIf ComboBox1.Text = "Elongación" Then
            CheckBox1.Text = "Reformer con sogas para piernas"
            CheckBox2.Text = "Reformer sin asistencia"
            CheckBox3.Text = "Cadillac sin asistencia"
            CheckBox4.Text = "Laddel Barrel para columna vertebral"
            CheckBox5.Visible = False

        ElseIf ComboBox1.Text = "Pelota" Then
            CheckBox5.Visible = True
            CheckBox1.Text = "Como elemento complementario para piernas"
            CheckBox2.Text = "Como elemento complementario en cadillac para brazos"
            CheckBox3.Text = "Sola contra de la pared en trabajo para piernas"
            CheckBox4.Text = "Complemento con combo chair para trabajo de pecho"
            CheckBox5.Text = "Para elongacion integral para abdominales"

        ElseIf ComboBox1.Text = "Abdominales" Then
            CheckBox5.Visible = True
            CheckBox1.Text = "En reformer simple"
            CheckBox2.Text = "Reformer con piernas sujetada, con soga, invertido"
            CheckBox3.Text = "En cadillac suspendidos y con asistenci"
            CheckBox4.Text = "En laddel Barrel de frente e invertido"
            CheckBox5.Text = "En combo Chair de frente"
        End If

    End Sub

    Private Sub btnGuardar3_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Dim consulta As String
        Dim fila As DataRow
        Try
            If accion = True Then

                '1. Crear una nueva fila'
                fila = FormInicial.erbpilatesDataSet.Tables("Alumno").NewRow

                '2. Rellenar la fila con información

                fila("cardiacas") = cbCardiaco.Text
                fila("lesiones_reciente") = cbLesiones.Text
                fila("columna") = cbColumna.Text
                fila("otros") = cbOtros.Text
                fila("detalles") = rbDetalles.Text
                fila("altura_cm") = tbAltura.Text
                fila("peso") = tbPeso.Text
                fila("grupo_sanguineo") = tbGrupo.Text


                '3. Agregar fila a la tabla del DataSet
                FormInicial.erbpilatesDataSet.Tables("alumno").Rows.Add(fila)

                '4. Crear Comando para agregar a la BD la fila nueva

                consulta = "INSERT INTO patologias (idHistoria, cardiacas,lesiones_recientes, columna, otros ,detalles,altura_cm, peso , grupo_sanguineo) VALUES ( @idHis, @car,@les, @col,@otr,@det,@alt, @pes ,@grup)"
                FormInicial.patologiasDataAdapter.InsertCommand = New MySqlCommand(consulta, conexion)
                FormInicial.patologiasDataAdapter.InsertCommand.Parameters.Add("@car", MySqlDbType.Int32, 0, "cardiacas")
                FormInicial.patologiasDataAdapter.InsertCommand.Parameters.Add("@les", MySqlDbType.Int32, 0, "lesiones_recientes")
                FormInicial.patologiasDataAdapter.InsertCommand.Parameters.Add("@col", MySqlDbType.Int32, 0, "columna")
                FormInicial.patologiasDataAdapter.InsertCommand.Parameters.Add("@otr", MySqlDbType.Int32, 0, "otros")
                FormInicial.patologiasDataAdapter.InsertCommand.Parameters.Add("@det", MySqlDbType.VarChar, 250, "detalles")
                FormInicial.patologiasDataAdapter.InsertCommand.Parameters.Add("@alt", MySqlDbType.Int32, 0, "altura_cm")
                FormInicial.patologiasDataAdapter.InsertCommand.Parameters.Add("@pes", MySqlDbType.Decimal, 10, "peso")
                FormInicial.patologiasDataAdapter.InsertCommand.Parameters.Add("@grup", MySqlDbType.VarChar, 45, "grupo_sanguineo")


                '5. Guardar los cambios en la base de datos
                FormInicial.patologiasDataAdapter.Update(FormInicial.erbpilatesDataSet.Tables("patologias"))


                CargaInicial()

                'Limpiamos los textbox para poder cargar otro cliente            
                cbCardiaco.Text = ""
                cbLesiones.Text = ""
                cbColumna.Text = ""
                cbOtros.Text = ""
                rbDetalles.Text = ""
                tbAltura.Text = ""
                tbPeso.Text = ""
                tbGrupo.Text = ""


            Else
                '1. Seleccionar fila a editar
                fila = FormInicial.erbpilatesDataSet.Tables("patologias").Rows.Find(idFila)


                '2. Rellenar la fila con información   

                fila("cardiacas") = cbCardiaco.Text
                fila("lesiones_reciente") = cbLesiones.Text
                fila("columna") = cbColumna.Text
                fila("otros") = cbOtros.Text
                fila("detalles") = rbDetalles.Text
                fila("altura_cm") = tbAltura.Text
                fila("peso") = tbPeso.Text
                fila("grupo_sanguineo") = tbGrupo.Text

                '3. Crear Comando para modificar la fila en la BD

                consulta = "UPDATE patologia SET cardiaco=@car, lesiones_recientes=@les, columna=@col ,otros=@otr, detalles =@det, altura_cm=@alt, peso =@pes , grupo_sanguineo =@grup  WHERE id_alumno=@id"
                FormInicial.patologiasDataAdapter.UpdateCommand = New MySqlCommand(consulta, conexion)
                FormInicial.patologiasDataAdapter.UpdateCommand.Parameters.Add("@car", MySqlDbType.Int32, 0, "cardiacas")
                FormInicial.patologiasDataAdapter.UpdateCommand.Parameters.Add("@les", MySqlDbType.Int32, 0, "lesiones_recientes")
                FormInicial.patologiasDataAdapter.UpdateCommand.Parameters.Add("@col", MySqlDbType.Int32, 0, "columna")
                FormInicial.patologiasDataAdapter.UpdateCommand.Parameters.Add("@otr", MySqlDbType.Int32, 0, "otros")
                FormInicial.patologiasDataAdapter.UpdateCommand.Parameters.Add("@det", MySqlDbType.VarChar, 250, "detalles")
                FormInicial.patologiasDataAdapter.UpdateCommand.Parameters.Add("@alt", MySqlDbType.Int32, 0, "altura_cm")
                FormInicial.patologiasDataAdapter.UpdateCommand.Parameters.Add("@pes", MySqlDbType.Decimal, 10, "peso")
                FormInicial.patologiasDataAdapter.UpdateCommand.Parameters.Add("@grup", MySqlDbType.VarChar, 45, "grupo_sanguineo")

                FormInicial.patologiasDataAdapter.UpdateCommand.Parameters.Add("@id", MySqlDbType.Int32, 0, "id_alumno")

                '4. Guardar los cambios en la base de datos
                FormInicial.patologiasDataAdapter.Update(FormInicial.erbpilatesDataSet.Tables("alumno"))
                '5. Actualiza la tabla del formulario listado de clientes
                CargaInicial()
                'Me.Close()
            End If


        Catch ex As Exception
            MsgBox("Error espacio en blanco", MsgBoxStyle.Critical)

        End Try
    End Sub
    Sub cancelar()
        'activarTextBox(False)

        btnEditar.Enabled = True
        btnGuardar.Enabled = False
        'btnBorrar.Enabled = True
        btnCancelar.Enabled = False


        cbColumna.Text = ""
        cbCardiaco.Text = ""
        cbLesiones.Text = ""
        cbOtros.Text = ""
        tbAltura.Text = ""
        tbPeso.Text = ""
        tbGrupo.Text = ""

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        cancelar()
    End Sub
End Class
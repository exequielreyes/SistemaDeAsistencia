Imports MySql.Data.MySqlClient
Imports System.Runtime.InteropServices
Public Class FormInicial
    'Private vista As New DataView
    Public Property alumnoDataAdapter As New MySqlDataAdapter
    Public Property capacidadDataAdapter As New MySqlDataAdapter
    Public Property turnoDataAdapter As New MySqlDataAdapter
    Public Property patologiasDataAdapter As New MySqlDataAdapter
    Public Property historiaDataAdapter As New MySqlDataAdapter
    Public Property rutinaDataAdapter As New MySqlDataAdapter
    Public Property ejerciciosDataAdapter As New MySqlDataAdapter
    Public Property clasesDataAdapter As New MySqlDataAdapter

    Public Property erbpilatesDataSet As New DataSet


    Private Sub FormInicial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        erbpilatesDataSet.Tables.Add("alumno")
        erbpilatesDataSet.Tables.Add("capacidad")
        erbpilatesDataSet.Tables.Add("patologias")

        'conectarse()
        'erbpilatesDataSet.Tables("Alumno").Clear()
        'alumnoDataAdapter.SelectCommand = New MySqlCommand("SELECT * FROM alumno", conexion)
        'alumnoDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey
        'alumnoDataAdapter.Fill(erbpilatesDataSet.Tables("Alumno"))
        'vista = erbpilatesDataSet.Tables("Alumno").DefaultView
        'FormRegistro.dgvListado.DataSource = vista
        'FormRegistro.dgvListado.Columns(0).Visible = False
        'FormRegistro.dgvListado.Columns(8).Visible = False
        'FormRegistro.dgvListado.Columns(9).Visible = False
        'FormRegistro.dgvListado.ClearSelection()
        'desconectarse()

    End Sub

    Private Sub btnRegistro_Click_1(sender As Object, e As EventArgs) Handles btnRegistro.Click
        FormRegistro.Show()
    End Sub
    Private Sub btnAsistencia_Click(sender As Object, e As EventArgs) Handles btnAsistencia.Click
        FormAsistencia.ShowDialog()
    End Sub
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub tmMostrar_Tick(sender As Object, e As EventArgs) Handles tmMostrar.Tick
        If Panel1.Width >= 179 Then
            Me.tmMostrar.Enabled = False
        Else
            Me.Panel1.Width = Panel1.Width + 20
        End If
    End Sub

    Private Sub tmOcultar_Tick(sender As Object, e As EventArgs) Handles tmOcultar.Tick
        If Panel1.Width <= 59 Then
            Me.tmOcultar.Enabled = False
        Else
            Me.Panel1.Width = Panel1.Width - 20
        End If
    End Sub

    Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
        desconectarse()
        'FormPrincipal.Show()
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



    Private Sub btnMenu_Click_1(sender As Object, e As EventArgs) Handles btnMenu.Click
        If Panel1.Width = 179 Then
            tmOcultar.Enabled = True
        ElseIf Panel1.Width = 59 Then
            tmMostrar.Enabled = True
        End If
    End Sub
End Class

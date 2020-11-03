Imports MySql.Data.MySqlClient

Public Class FormInicial
    Public Property alumnoDataAdapter As New MySqlDataAdapter
    Public Property capacidadDataAdapter As New MySqlDataAdapter
    Public Property erbpilatesDataSet As New DataSet
    Private Sub FormInicial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        erbpilatesDataSet.Tables.Add("alumno")
        erbpilatesDataSet.Tables.Add("capacidad")
    End Sub
    Private Sub btnRegistro_Click(sender As Object, e As EventArgs) Handles btnRegistro.Click
        FormRegistro.Show()
    End Sub
    Private Sub btnAsistencia_Click(sender As Object, e As EventArgs) Handles btnAsistencia.Click
        FormAsistencia.ShowDialog()
    End Sub
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub
End Class

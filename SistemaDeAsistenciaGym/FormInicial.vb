﻿Imports MySql.Data.MySqlClient
Imports System.Runtime.InteropServices
Public Class FormInicial
    Public Property alumnoDataAdapter As New MySqlDataAdapter
    Public Property capacidadDataAdapter As New MySqlDataAdapter
    Public Property erbpilatesDataSet As New DataSet
    Private Sub FormInicial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        erbpilatesDataSet.Tables.Add("alumno")
        erbpilatesDataSet.Tables.Add("capacidad")
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


    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        If Panel1.Width = 179 Then
            tmOcultar.Enabled = True
        ElseIf Panel1.Width = 59 Then
            tmMostrar.Enabled = True
        End If
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


End Class

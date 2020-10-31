Imports AForge.Video.DirectShow
Imports BarcodeLib.BarcodeReader

Public Class FormAsistencia
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        FormInicial.Show()
        Me.Hide()
    End Sub

    Private Sub FormAsistencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormInicial.Hide()

    End Sub
End Class
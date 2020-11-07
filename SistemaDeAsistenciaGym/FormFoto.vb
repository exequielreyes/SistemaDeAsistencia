Imports AForge.Video.DirectShow
Imports BarcodeLib.BarcodeReader
Imports MySql.Data.MySqlClient

Public Class FormFoto
    Private Sub btnGuardarFotoArchivo_Click(sender As Object, e As EventArgs) Handles btnGuardarFotoArchivo.Click

        Dim image As Image = pbFoto.Image
        image.Save("C:\Users\exequ\Documents\Imagix\image.jpg", System.Drawing.Imaging.ImageFormat.Jpeg)

    End Sub

    Private Sub cmdBorrar_Click(sender As Object, e As EventArgs) Handles cmdBorrar.Click
        pbFoto.Image = Nothing
    End Sub

    Private Sub cmdcamara_Click(sender As Object, e As EventArgs) Handles cmdcamara.Click
        FormCamaraWeb.OpenPreviewWindowCliente()
        cmdcamara.Enabled = False
    End Sub

    Private Sub cmdCapturar_Click(sender As Object, e As EventArgs) Handles cmdCapturar.Click
        FormCamaraWeb.CapturarCliente()
        FormCamaraWeb.ClosePreviewWindow()
        cmdcamara.Enabled = True

    End Sub

    Private Sub FormFoto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormRegistro.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
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
        FormRegistro.Show()
    End Sub


End Class
Imports AForge.Video.DirectShow
Imports BarcodeLib.BarcodeReader
Imports MySql.Data.MySqlClient

Public Class FormFoto
    Private Sub btnGuardarFotoArchivo_Click(sender As Object, e As EventArgs) Handles btnGuardarFotoArchivo.Click
        Try
            Dim sFD As New SaveFileDialog
            sFD.Title = "Guardar Imagen"
            sFD.Filter = "Imagenes|*.jpg;*.gif;*.png;*.bmp"
            If sFD.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.pbFoto.Image.Save(System.IO.Path.GetFullPath(sFD.FileName))
            End If
        Catch ex As Exception
            MessageBox.Show(Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim secondForm = New FormRegistro()
        'secondForm.Controls.Add(pbFoto)

        ''(( pbFoto ) secondForm.Controls("pbFoto1").Image = this.pictureBox1.Image
        'secondForm.Show()

        FormRegistro.ShowDialog()

    End Sub


End Class
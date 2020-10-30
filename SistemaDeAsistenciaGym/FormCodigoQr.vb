Public Class FormCodigoQr
    Dim QR_Generator As New MessagingToolkit.QRCode.Codec.QRCodeEncoder
    Private Sub FormCodigoQr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            PictureBox1.Image = QR_Generator.Encode(FormRegistro.tbDni.Text & "Dni ")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        Try
            Dim img As New Bitmap(PictureBox1.Image)
            img.Save(SaveFileDialog1.FileName, Imaging.ImageFormat.Png)

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub bGuardar_Click(sender As Object, e As EventArgs) Handles bGuardar.Click
        SaveFileDialog1.ShowDialog()
    End Sub

    Private Sub btnEmail_Click(sender As Object, e As EventArgs) Handles btnEmail.Click
        FormEmail.ShowDialog()
    End Sub
End Class
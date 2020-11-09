Public Class FormCodigoQr
    Dim QR_Generator As New MessagingToolkit.QRCode.Codec.QRCodeEncoder
    Private Sub FormCodigoQr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            PictureBox1.Image = QR_Generator.Encode(FormRegistro.tbDni.Text & "Dni ")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
    '    Try
    '        Dim img As New Bitmap(PictureBox1.Image)
    '        img.Save(SaveFileDialog1.FileName, Imaging.ImageFormat.Png)

    '    Catch ex As Exception
    '        MsgBox(ex.Message)

    '    End Try
    'End Sub

    Private Sub bGuardar_Click(sender As Object, e As EventArgs) Handles bGuardar.Click
        'SaveFileDialog1.ShowDialog()

        Dim image As Image = PictureBox1.Image
        image.Save("C:\Users\Doble G\Desktop\FOTO\qr\image.jpg", System.Drawing.Imaging.ImageFormat.Jpeg)

    End Sub

    Private Sub btnEmail_Click(sender As Object, e As EventArgs) Handles btnEmail.Click
        FormEmail.ShowDialog()
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
End Class
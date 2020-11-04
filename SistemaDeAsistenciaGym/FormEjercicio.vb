Public Class FormEjercicio
    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        OpenFileDialog1.InitialDirectory = "C: \Users\exeq\Imagenes"
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            pbFoto1.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub
End Class
Imports System.Net.Mail
Public Class FormEmail

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        enviarCorreo(CBMotivo.Text, "pilatesgym21@gmail.com", "alumnos1234", RichTextBox1.Text, TbAsunto.Text, TbPara.Text, Tbrutaarchivo.Text)
    End Sub
    Private Sub btnAdjuntarArchivo_Click(sender As Object, e As EventArgs) Handles btnAdjuntarArchivo.Click
        Try
            Me.OpenFileDialog1.ShowDialog()
            If Me.OpenFileDialog1.FileName <> "" Then
                Tbrutaarchivo.Text = Me.OpenFileDialog1.FileName
                PbArchivo.Visible = True
                lblArchivoCargado.Visible = True
            End If
        Catch ex As Exception

        End Try
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
Imports AForge.Video.DirectShow
Imports BarcodeLib.BarcodeReader

Public Class FormAsistencia
    Private dispositivos As FilterInfoCollection
    Private fuenteVideo As VideoCaptureDevice
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        FormInicial.Show()
        Me.Hide()
    End Sub

    Private Sub FormAsistencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormInicial.Hide()
        dispositivos = New FilterInfoCollection(FilterCategory.VideoInputDevice)
        For Each x As FilterInfo In dispositivos
            ComboBox1.Items.Add(x.Name)
        Next
        ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        Timer1.Enabled = True
        Timer1.Start()
        fuenteVideo = New VideoCaptureDevice(dispositivos(ComboBox1.SelectedIndex).MonikerString)
        vspQR.VideoSource = fuenteVideo
        vspQR.Start()
    End Sub

    Private Sub btnDetener_Click(sender As Object, e As EventArgs) Handles btnDetener.Click
        Timer1.Enabled = False
        vspQR.Stop()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If vspQR.GetCurrentVideoFrame() IsNot Nothing Then
            Dim img As New Bitmap(vspQR.GetCurrentVideoFrame)
            Dim resultados As String() = BarcodeReader.read(img, BarcodeReader.QRCODE)
            img.Dispose()
            If resultados IsNot Nothing AndAlso resultados.Count > 0 Then
                lbAlumno.Items.Add(resultados(0))
            End If
        End If
    End Sub
End Class
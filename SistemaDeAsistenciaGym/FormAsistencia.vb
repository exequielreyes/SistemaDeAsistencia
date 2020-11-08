Imports AForge.Video.DirectShow
Imports BarcodeLib.BarcodeReader
Imports MySql.Data.MySqlClient


Public Class FormAsistencia
    Private vista As New DataView
    Private accion As Boolean
    Private idFila As String
    Dim consulta As String

    Private dispositivos As FilterInfoCollection
    Private fuenteVideo As VideoCaptureDevice


    Private Sub btnVolver_Click(sender As Object, e As EventArgs)
        FormInicial.Show()
        Me.Hide()
    End Sub

    Private Sub FormAsistencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormInicial.Hide()
        'GroupBox1.Visible = False
        'dgvAlumnos.Visible = False
        conectarse()
        FormInicial.erbpilatesDataSet.Tables("Alumno").Clear()
        FormInicial.alumnoDataAdapter.SelectCommand = New MySqlCommand("SELECT *FROM alumno", conexion)
        FormInicial.alumnoDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey
        FormInicial.alumnoDataAdapter.Fill(FormInicial.erbpilatesDataSet.Tables("Alumno"))
        vista = FormInicial.erbpilatesDataSet.Tables("Alumno").DefaultView
        dgvAlumnos.DataSource = vista
        'dgvAlumnos.Columns(0).Visible = False
        desconectarse()


        cargarTextBox()
        dispositivos = New FilterInfoCollection(FilterCategory.VideoInputDevice)
        For Each x As FilterInfo In dispositivos
            ComboBox1.Items.Add(x.Name)
        Next
        ComboBox1.SelectedIndex = 0
        TimerActualizar.Start()

    End Sub

    Sub cargarTextBox()
        Dim fila As DataGridViewRow = dgvAlumnos.CurrentRow
        idFila = fila.Cells(0).Value
        tbNombre.Text = fila.Cells(1).Value
        tbApellido.Text = fila.Cells(2).Value
        tbDNI.Text = fila.Cells(3).Value
    End Sub

    Private Sub dgvAlumnos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAlumnos.CellContentClick
        If vista.Count > 0 Then
            cargarTextBox()
        End If
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
            Dim img As New Bitmap(vspQR.GetCurrentVideoFrame())
            Dim resultados As String() = BarcodeReader.read(img, BarcodeReader.QRCODE)
            img.Dispose()
            If resultados IsNot Nothing AndAlso resultados.Count() > 0 Then
                If resultados(0).IndexOf("1111") <> -1 Then

                    resultados(0) = resultados(0).Replace("1111", "")

                    lbAlumno.Items.Insert(0, resultados(0))
                End If
            End If
        End If
        'If VideoSourcePlayer1.GetCurrentVideoFrame() IsNot Nothing Then
        '    Dim img As New Bitmap(VideoSourcePlayer1.GetCurrentVideoFrame)
        '    Dim resultados As String() = BarcodeReader.read(img, BarcodeReader.QRCODE)
        '    img.Dispose()
        '    If resultados IsNot Nothing AndAlso resultados.Count > 0 Then
        '        ListBox1.Items.Add(resultados(0))
        '    End If
        'End If

        'lblTimerCamara.Text += 1
        'If lblTimerCamara.Text = 10 Then
        '    Timer1.Enabled = False
        '    VideoSourcePlayer1.Stop()
        '    lblTimerCamara.Text = 0
        'End If
    End Sub

    Private Sub lbAlumno_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbAlumno.SelectedIndexChanged

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
        FormInicial.Show()
    End Sub

    Public Function comparar()
        'Dim id As Integer
        Dim qr As Integer

        qr = BarcodeReader.QRCODE
        conectarse()
        FormInicial.erbpilatesDataSet.Tables("Alumno").Clear()
        FormInicial.alumnoDataAdapter.SelectCommand = New MySqlCommand("SELECT DNI FROM alumno", conexion)
        Try
            If qr = "@DNI" Then
                FormInicial.alumnoDataAdapter.SelectCommand = New MySqlCommand("SELECT DNI FROM alumno WHERE id_alumno=1")




            End If

        Catch ex As Exception

        End Try



        Return 0
    End Function

    Private Sub TimerActualizar_Tick(sender As Object, e As EventArgs) Handles TimerActualizar.Tick
        'lblTimer.Text += 1
        'If lblTimer.Text = 10 Then
        '    FormInicial.erbpilatesDataSet.Tables("alumno").Clear()
        '    FormInicial.alumnoDataAdapter.SelectCommand = New MySqlCommand("SELECT * FROM alumno", conexion)
        '    FormInicial.alumnoDataAdapter.Fill(FormInicial.erbpilatesDataSet.Tables("alumno"))
        '    lblTimer.Text = 0
        'End If
    End Sub


End Class
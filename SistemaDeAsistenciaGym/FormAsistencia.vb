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
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Enabled = True
        Timer1.Start()
        fuenteVideo = New VideoCaptureDevice(dispositivos(ComboBox1.SelectedIndex).MonikerString)
        VideoSourcePlayer1.VideoSource = fuenteVideo
        VideoSourcePlayer1.Start()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Timer1.Enabled = False
        VideoSourcePlayer1.Stop()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If VideoSourcePlayer1.GetCurrentVideoFrame() IsNot Nothing Then
            Dim img As New Bitmap(VideoSourcePlayer1.GetCurrentVideoFrame)
            Dim resultados As String() = BarcodeReader.read(img, BarcodeReader.QRCODE)
            img.Dispose()
            If resultados IsNot Nothing AndAlso resultados.Count > 0 Then
                'If resultados(0).IndexOf("0000") <> 1 Then

                '    resultados(0) = resultados(0).Replace("0000", "")
                '    ListBox1.Items.Add(resultados(0))
                'End If
            End If
        End If
    End Sub



    Private Sub lbAlumno_SelectedIndexChanged(sender As Object, e As EventArgs)

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

        'If  Then

        'End If

        Return 0
    End Function




    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        'For i = 0 To ListBox1.ListCount - 1
        '    If ListBox1.List(i)) = tbDni   .text Then

        '          End If
        'Next i

        'For j = 0 To ListBox2.Items.Count - 1
        For i = 0 To ListBox1.Items.Count - 1
            If ListBox1.Items(i).ToString = tbDNI.Text Then
                MsgBox("Bienvenido")
                ' MsgBox(ListBox1.Items(i).ToString & " = " & ListBox2.Items(j).ToString)
                ListBox1.Items.RemoveAt(i)
                Exit For
            End If
        Next i

    End Sub
End Class
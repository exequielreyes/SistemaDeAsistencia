Public Class FormRegistro


    Sub activarTextBox(ByVal activo As Boolean)
        If activo = True Then

            tbNombre.Enabled = True
            tbApellido.Enabled = True
            tbDni.Enabled = True
            tbEdad.Enabled = True
            tbDireccion.Enabled = True
            tbTelefono.Enabled = True
            tbEmail.Enabled = True

        Else

            tbNombre.Enabled = False
            tbApellido.Enabled = False
            tbDni.Enabled = False
            tbEdad.Enabled = False
            tbDireccion.Enabled = False
            tbTelefono.Enabled = False
            tbEmail.Enabled = False
        End If
    End Sub
    Sub cancelar()
        activarTextBox(False)
        btnNuevo.Enabled = True
        btnEditar.Enabled = True
        btnGuardar.Enabled = False
        btnBorrar.Enabled = True
        btnCancelar.Enabled = False

    End Sub


    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        activarTextBox(True)
        btnEditar.Enabled = False
        btnBorrar.Enabled = False
        btnCancelar.Enabled = True
        btnGuardar.Enabled = True
        Btnqr.Enabled = True
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        cancelar()
    End Sub

    Private Sub Btnqr_Click(sender As Object, e As EventArgs) Handles Btnqr.Click
        FormCodigoQr.Show()
    End Sub

    Private Sub FormRegistro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormInicial.Hide()


    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        FormInicial.Show()
        Me.Hide()

    End Sub

    Private Sub pbFoto_Click(sender As Object, e As EventArgs) Handles pbFoto.Click
        FormFoto.Show()

    End Sub
End Class
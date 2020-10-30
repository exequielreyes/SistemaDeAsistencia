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


    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        activarTextBox(True)
        btnEditar.Enabled = False
        btnBorrar.Enabled = False
        btnCancelar.Enabled = True
        btnGuardar.Enabled = True
        Btnqr.Enabled = False
    End Sub
End Class
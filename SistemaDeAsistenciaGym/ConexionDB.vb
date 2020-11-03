Imports MySql.Data.MySqlClient

Module ConexionDB
    Private miConexion As New MySqlConnection

    Public Sub conectarse()
        Try
            miConexion.ConnectionString = "server=localhost;database=erbpilates;user=root;password=;"
            miConexion.Open()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub desconectarse()
        miConexion.Close()

    End Sub

    Public Function conexion() As MySqlConnection
        Return miConexion
    End Function


End Module

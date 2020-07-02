Public Class conexion
    Public Function abrirConexion() As Npgsql.NpgsqlConnection
        Dim conexion As Npgsql.NpgsqlConnection
        Try

        Catch ex As Exception
            Throw ex
        End Try
        Return conexion
    End Function
End Class

Public Class conexion
    Public Function abrirConexion() As Npgsql.NpgsqlConnection
        Dim conexionPg As Npgsql.NpgsqlConnection
        Try
            conexionPg = New Npgsql.NpgsqlConnection()

            Dim cadenaDeConexion As String

            cadenaDeConexion = "server = 127.0.0.1; port = 5332 ; user = 'postgres' ; password = 'root' ; database = bdd1"

            conexionPg.ConnectionString = cadenaDeConexion

            conexionPg.Open()

        Catch ex As Exception
            Throw ex
        End Try
        Return conexionPg
    End Function
End Class

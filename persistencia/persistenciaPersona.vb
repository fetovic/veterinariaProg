Public Class persistenciaPersona
    Sub New()

    End Sub
    Dim conection = New Npgsql.NpgsqlConnection
    Public Sub AltaPersona(personaUser As clasePersona)
        Try
            Dim clasCnn = New conexion
            conection = clasCnn.abrirConexion()
            Dim cadenaDeComandos As String
            cadenaDeComandos = "insert into Persona(ci,nombre,direccion) values (@ci ,@nombre,@direccion)"
            Dim cmd As New Npgsql.NpgsqlCommand(cadenaDeComandos)

            cmd.Connection = conection
            cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = personaUser.Ci
            cmd.Parameters.Add("@nombre", NpgsqlTypes.NpgsqlDbType.Varchar, 100).Value = personaUser.Nombre
            cmd.Parameters.Add("@direccion", NpgsqlTypes.NpgsqlDbType.Varchar, 100).Value = personaUser.direccion
            Dim resultado As Integer
            resultado = cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            conection.close
        End Try

    End Sub
End Class

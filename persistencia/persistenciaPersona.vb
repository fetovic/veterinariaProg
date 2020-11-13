Public Class persistenciaPersona

    Dim conection = New Npgsql.NpgsqlConnection
    Public Sub AltaPersona(personaUser As clasePersona)
        Try
            Dim clasCnn = New conexion

            conection = clasCnn.abrirConexion()
            Dim cadenaDeComandos As String
            cadenaDeComandos = "insert into Persona(ci,nombre,direccion) values (@ci ,@nombre,@direccion);"
            Dim cmd As New Npgsql.NpgsqlCommand()
            cmd.CommandText = cadenaDeComandos
            cmd.Connection = conection
            cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = personaUser.Ci
            cmd.Parameters.Add("@nombre", NpgsqlTypes.NpgsqlDbType.Varchar, 100).Value = personaUser.Nombre
            cmd.Parameters.Add("@direccion", NpgsqlTypes.NpgsqlDbType.Varchar, 100).Value = personaUser.direccion
            Dim resultado As Integer
            resultado = cmd.ExecuteNonQuery()
            If resultado = 1 Then

            End If

        Catch ex As Exception
            Throw ex
        Finally
            conection.close
        End Try

    End Sub

    Public Function buscarPersona(ci As Integer) As clasePersona
        Dim newPersona As New clasePersona
        Try

            Dim clasCnn As New conexion
            Dim cadenaDeComandos As String


            Dim reader As Npgsql.NpgsqlDataReader
            conection = clasCnn.abrirConexion()
            Dim cmd As New Npgsql.NpgsqlCommand()

            cmd.Connection = conection

            cadenaDeComandos = "select * from persona where ci=@ci;"
            cmd.CommandText = cadenaDeComandos
            cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = ci
            reader = cmd.ExecuteReader

            If reader.HasRows Then
                reader.Read()
                newPersona.Ci = Convert.ToInt32(reader(0).ToString)
                newPersona.Nombre = reader(1).ToString
                newPersona.direccion = reader(2).ToString
            End If
            reader.Close()


        Catch ex As Exception
            Throw ex
        Finally
            conection.close
        End Try
        Return newPersona
    End Function
    Public Sub modificarParsona(personaUser As clasePersona)
        Try
            Dim clasCnn = New conexion

            conection = clasCnn.abrirConexion()
            Dim cadenaDeComandos As String
            cadenaDeComandos = "update persona set nombre=@nombre, direccion=@direccion where ci=@ci"
            Dim cmd As New Npgsql.NpgsqlCommand()
            cmd.CommandText = cadenaDeComandos
            cmd.Connection = conection
            cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = personaUser.Ci
            cmd.Parameters.Add("@nombre", NpgsqlTypes.NpgsqlDbType.Varchar, 100).Value = personaUser.Nombre
            cmd.Parameters.Add("@direccion", NpgsqlTypes.NpgsqlDbType.Varchar, 100).Value = personaUser.direccion
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            Throw ex
        Finally
            conection.close
        End Try

    End Sub


    Public Function listarPersona() As List(Of clasePersona)
        Dim listaPersona As New List(Of clasePersona)
        Try

            Dim ClaseSnl As New conexion
            conection = ClaseSnl.abrirConexion
            Dim cmd = New Npgsql.NpgsqlCommand
            cmd.Connection = conection

            Dim cadenaDeComandos = "select * from persona"

            cmd.CommandText = cadenaDeComandos
            Dim Lector As Npgsql.NpgsqlDataReader = cmd.ExecuteReader


            While Lector.Read()
                Dim newPersona As New clasePersona
                newPersona.Ci = Convert.ToInt32(Lector(0).ToString)
                newPersona.Nombre = Lector(1).ToString
                newPersona.direccion = Lector(2).ToString
                listaPersona.Add(newPersona)
            End While



        Catch ex As Exception
            Throw ex
        Finally
            conection.close
        End Try
        Return listaPersona
    End Function
    Public Sub borrarPersona(ci As Integer)
        Try
            Dim clasCnn = New conexion

            conection = clasCnn.abrirConexion()
            Dim cadenaDeComandos As String
            cadenaDeComandos = "delete from persona where ci = @ci"
            Dim cmd As New Npgsql.NpgsqlCommand()
            cmd.CommandText = cadenaDeComandos
            cmd.Connection = conection
            cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = ci

            cmd.ExecuteNonQuery()

        Catch ex As Exception
            Throw ex
        Finally
            conection.close
        End Try

    End Sub
End Class

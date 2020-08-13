Public Class persistenciaPersona
    Sub New()

    End Sub
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
                Dim i As Integer
                i = 0
                While i < personaUser.ListaTelefono.Count


                    cadenaDeComandos = "insert into telefono(cip,telefono) values (@cip ,@telefono);"
                    cmd.CommandText = cadenaDeComandos
                    cmd.Connection = conection
                    cmd.Parameters.Add("@cip", NpgsqlTypes.NpgsqlDbType.Integer).Value = personaUser.Ci
                    cmd.Parameters.Add("@telefono", NpgsqlTypes.NpgsqlDbType.Integer).Value = personaUser.ListaTelefono.Item(i)

                    resultado = cmd.ExecuteNonQuery()
                    i = i + 1

                End While
            End If

        Catch ex As Exception
            Throw ex
        Finally
            conection.close
        End Try

    End Sub
    Public Function buscarPersona(ci As Integer) As clasePersona

        Try
            Dim newPersona As New clasePersona
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
            If newPersona.Nombre = "" And newPersona.direccion = "" Then
            Else
                Return newPersona
            End If

        Catch ex As Exception
            Throw ex
        Finally
            conection.close
        End Try

    End Function
End Class

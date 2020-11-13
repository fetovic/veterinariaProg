Public Class persitenciaMascota

    Dim conection = New Npgsql.NpgsqlConnection
    Public Sub AltaMascota(Mascota As claseMascota)
        Try
            Dim clasCnn = New conexion

            conection = clasCnn.abrirConexion()
            Dim cadenaDeComandos As String
            cadenaDeComandos = "insert into mascota(cip,nombre,añonacimiento) values (@ci ,@nombre,@anio);"
            Dim cmd As New Npgsql.NpgsqlCommand()
            cmd.CommandText = cadenaDeComandos
            cmd.Connection = conection
            cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = Mascota.Dueño.Ci
            cmd.Parameters.Add("@nombre", NpgsqlTypes.NpgsqlDbType.Varchar, 100).Value = Mascota.NombreM
            cmd.Parameters.Add("@anio", NpgsqlTypes.NpgsqlDbType.Integer).Value = Mascota.FechaNac
            Dim resultado As Integer
            resultado = cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            conection.close
        End Try

    End Sub

    Public Function buscarMascota(id As Integer) As claseMascota
        Dim newmascota As New claseMascota
        Try

            Dim clasCnn As New conexion
            Dim cadenaDeComandos As String


            Dim reader As Npgsql.NpgsqlDataReader
            conection = clasCnn.abrirConexion()
            Dim cmd As New Npgsql.NpgsqlCommand()

            cmd.Connection = conection

            cadenaDeComandos = "select * from mascota where id=@id;"
            cmd.CommandText = cadenaDeComandos
            cmd.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = id
            reader = cmd.ExecuteReader

            If reader.HasRows Then
                reader.Read()
                newmascota.Id = Convert.ToInt32(reader(0).ToString)
                newmascota.NombreM = reader(1).ToString
                newmascota.FechaNac = Convert.ToInt32(reader(2).ToString)

                Dim persistenciaPersona As New persistenciaPersona
                newmascota.Dueño = persistenciaPersona.buscarPersona(Convert.ToInt32(reader(3).ToString))


            End If
            reader.Close()


        Catch ex As Exception
            Throw ex
        Finally
            conection.close
        End Try
        Return newmascota
    End Function
    Public Sub modificarMascota(Mascota As claseMascota)
        Try
            Dim clasCnn = New conexion

            conection = clasCnn.abrirConexion()
            Dim cadenaDeComandos As String
            cadenaDeComandos = "update mascota set nombre=@nombre, añonacimiento=@anionacimiento where id=@id"
            Dim cmd As New Npgsql.NpgsqlCommand()
            cmd.CommandText = cadenaDeComandos
            cmd.Connection = conection
            cmd.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = Mascota.Id
            cmd.Parameters.Add("@nombre", NpgsqlTypes.NpgsqlDbType.Varchar, 100).Value = Mascota.NombreM
            cmd.Parameters.Add("@anionacimiento", NpgsqlTypes.NpgsqlDbType.Integer).Value = Mascota.FechaNac
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            Throw ex
        Finally
            conection.close
        End Try

    End Sub


    Public Function listarMascota(ci As Integer) As List(Of claseMascota)
        Dim listaMascota As New List(Of claseMascota)
        Try

            Dim ClaseSnl As New conexion
            conection = ClaseSnl.abrirConexion
            Dim cmd = New Npgsql.NpgsqlCommand
            cmd.Connection = conection

            Dim cadenaDeComandos = "select * from mascota where cip=@ci"
            cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = ci
            cmd.CommandText = cadenaDeComandos
            Dim Lector As Npgsql.NpgsqlDataReader = cmd.ExecuteReader


            While Lector.Read()
                Dim newMascota As New claseMascota
                newMascota.Id = Convert.ToInt32(Lector(0).ToString)
                newMascota.NombreM = Lector(1).ToString
                newMascota.FechaNac = Convert.ToInt32(Lector(2).ToString)
                Dim persistenciaPersona As New persistenciaPersona
                newMascota.Dueño = persistenciaPersona.buscarPersona(Convert.ToInt32(Lector(3).ToString))
                listaMascota.Add(newMascota)
            End While



        Catch ex As Exception
            Throw ex
        Finally
            conection.close
        End Try
        Return listaMascota
    End Function
    Public Sub bajaMascotas(ci As Integer)
        Try
            Dim clasCnn = New conexion

            conection = clasCnn.abrirConexion()
            Dim cadenaDeComandos As String
            cadenaDeComandos = "delete from mascota where cip = @cip"
            Dim cmd As New Npgsql.NpgsqlCommand()
            cmd.CommandText = cadenaDeComandos
            cmd.Connection = conection
            cmd.Parameters.Add("@cip", NpgsqlTypes.NpgsqlDbType.Integer).Value = ci
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            Throw ex
        Finally
            conection.close
        End Try
    End Sub
    Public Sub borrarMascota(id As Integer)
        Dim clasCnn = New conexion

        conection = clasCnn.abrirConexion()
        Dim cadenaDeComandos As String
        cadenaDeComandos = "delete from mascota where id = @id"
        Dim cmd As New Npgsql.NpgsqlCommand()
        cmd.CommandText = cadenaDeComandos
        cmd.Connection = conection
        cmd.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = id
        cmd.ExecuteNonQuery()
    End Sub
End Class

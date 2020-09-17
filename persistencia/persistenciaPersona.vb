﻿Public Class persistenciaPersona

    Dim listaTelefono As New List(Of Integer)
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
            'alta telefono
            If resultado = 1 Then
                Dim i As Integer
                i = 0
                While i < personaUser.ListaTelefono.Count


                    cadenaDeComandos = "insert into telefono(cip,telefono) values (@cip ,@telefono);"
                    cmd.CommandText = cadenaDeComandos
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
            cadenaDeComandos = "select * from telefono where cip = @ci"
            cmd.CommandText = cadenaDeComandos
            reader = cmd.ExecuteReader

            While reader.Read()

                listaTelefono.Add(Convert.ToInt32(reader(1).ToString))


            End While
            If newPersona.Nombre = "" And newPersona.direccion = "" Then
            Else
                newPersona.ListaTelefono = listaTelefono

            End If


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
            Dim resultado As Integer
            resultado = cmd.ExecuteNonQuery()
            cadenaDeComandos = "delete from telefono where cip = @ci"
            cmd.CommandText = cadenaDeComandos
            resultado = cmd.ExecuteNonQuery()
            Dim i As Integer = 0


        Catch ex As Exception
            Throw ex
        Finally
            conection.close
        End Try

    End Sub
    Public Sub agregarTelefono(ci As Integer, telefono As Integer)
        Try


            Dim clasCnn = New conexion

            conection = clasCnn.abrirConexion()
            Dim cadenaDeComandos As String
            Dim cmd As New Npgsql.NpgsqlCommand()
            Dim resultado As Integer
            cmd.Connection = conection
            cadenaDeComandos = "insert into telefono(cip,telefono) values (@cip ,@telefono);"
            cmd.CommandText = cadenaDeComandos
            cmd.Parameters.Add("@cip", NpgsqlTypes.NpgsqlDbType.Integer).Value = ci
            cmd.Parameters.Add("@telefono", NpgsqlTypes.NpgsqlDbType.Integer).Value = telefono
            Debug.WriteLine(ci)
            Debug.WriteLine(telefono)
            resultado = cmd.ExecuteNonQuery()

        Catch ex As Exception
            Debug.WriteLine(ex)
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

End Class

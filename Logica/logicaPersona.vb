Public Class logicaPersona
    Public Sub AltaPersona(personaUser As clasePersona)
        Dim persistencia As New persistenciaPersona
        persistencia.AltaPersona(personaUser)
    End Sub
    Public Sub modificarPersona(personaUser As clasePersona)
        Dim persistencia As New persistenciaPersona
        persistencia.modificarParsona(personaUser)
        Dim persistenciaTel As New persistenciaTelefono
        Me.borrarTelefonos(personaUser.Ci)
        For index As Integer = 0 To personaUser.ListaTelefono.Count - 1
            persistenciaTel.AgregarTelefono(personaUser.Ci, personaUser.ListaTelefono(index))
        Next
    End Sub
    Public Function buscarPersona(ci As Integer) As clasePersona
        Dim perstencia As New persistenciaPersona
        Dim persistencia2 As New persistenciaTelefono
        Dim persona As New clasePersona
        persona = perstencia.buscarPersona(ci)
        persona.ListaTelefono = persistencia2.TraerTelefonos(ci)
        Return persona
    End Function
    Public Function logicaListarPersona() As List(Of clasePersona)

        Dim persistencia As New persistenciaPersona
        Return persistencia.listarPersona()


    End Function

    Public Sub borrarTelefonos(ci As Integer)
        Dim persistencia As New persistenciaTelefono
        persistencia.borrarTelefonos(ci)
    End Sub

    Public Sub borrarPersona(ci As Integer)
        Dim persistencia As New persistenciaPersona
        Me.borrarTelefonos(ci)
        persistencia.borrarPersona(ci)
    End Sub
End Class

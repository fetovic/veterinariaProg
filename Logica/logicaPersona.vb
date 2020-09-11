Public Class logicaPersona
    Public Sub AltaPersona(personaUser As clasePersona)
        Dim persistencia As New persistenciaPersona
        persistencia.AltaPersona(personaUser)
    End Sub
    Public Sub modificarPersona(personaUser As clasePersona)
        Dim persistencia As New persistenciaPersona
        persistencia.modificarParsona(personaUser)
        For index As Integer = 0 To personaUser.ListaTelefono.Count - 1
            persistencia.agregarTelefono(personaUser.Ci, personaUser.ListaTelefono(index))
        Next
    End Sub
    Public Function buscarPersona(ci As Integer) As clasePersona
        Dim perstencia As New persistenciaPersona
        Return perstencia.buscarPersona(ci)
    End Function
End Class

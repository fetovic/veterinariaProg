Public Class logicaPersona
    Public Sub AltaPersona(personaUser As clasePersona)
        Dim persistencia As New persistenciaPersona
        persistencia.AltaPersona(personaUser)
    End Sub
    Public Sub modificarPersona(personaUser As clasePersona)
        Dim persistencia As New persistenciaPersona
        persistencia.modificarParsona(personaUser)
    End Sub
    Public Function buscarPersona(ci As Integer) As clasePersona
        Dim perstencia As New persistenciaPersona
        Return perstencia.buscarPersona(ci)
    End Function
End Class

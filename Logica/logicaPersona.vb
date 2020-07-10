Public Class logicaPersona
    Public Sub AltaPersona(personaUser As clasePersona)
        Dim persistencia As New persistenciaPersona
        persistencia.AltaPersona(personaUser)
    End Sub
End Class

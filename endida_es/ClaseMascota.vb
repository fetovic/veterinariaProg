Public Class claseMascota
    Private _nombreM As String
    Private _fechaNac As Integer
    Private _dueño As clasePersona
    Private _id As Integer

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property NombreM As String
        Get
            Return _nombreM
        End Get
        Set(value As String)
            _nombreM = value
        End Set
    End Property
    Public Property FechaNac As Integer
        Get
            Return _fechaNac
        End Get
        Set(value As Integer)
            _fechaNac = value
        End Set
    End Property
    Public Property Dueño As clasePersona
        Get
            Return _dueño
        End Get
        Set(value As clasePersona)
            _dueño = value
        End Set
    End Property
    Public Sub Mascota(nombrem_ As String, fechaNac_ As Integer, dueño_ As clasePersona, id_ As Integer)
        NombreM = nombrem_
        FechaNac = fechaNac_
        Dueño = dueño_
        Id = id_
    End Sub

    Public Sub Mascota()

    End Sub

End Class

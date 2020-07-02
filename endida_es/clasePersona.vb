Public Class clasePersona

    Private _ci As Integer
    Private _nombre As Integer
    Private _telefono As Integer
    Private _direccion As Integer

    Public Property Ci As Integer
        Get
            Return _ci
        End Get
        Set(value As Integer)
            _ci = value
        End Set
    End Property
    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
    Public Property Telefono As Integer
        Get
            Return _telefono
        End Get
        Set(value As Integer)
            _telefono = value
        End Set
    End Property
    Public Property direccion As String
        Get
            Return _direccion
        End Get
        Set(value As String)
            _direccion = value
        End Set
    End Property
    Public Sub personas(ci_ As Integer, nombreP_ As String, tel_ As Integer, dir_ As String)
        Ci = ci_
        Nombre = nombreP_
        Telefono = tel_
        direccion = dir_
    End Sub

    Public Sub persona()

    End Sub


End Class

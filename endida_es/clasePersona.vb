Public Class clasePersona

    Private _ci As Integer
    Private _nombre As String
    Private _ListaTelefono As List(Of Integer)
    Private _direccion As String

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
    Public Property ListaTelefono As List(Of Integer)
        Get
            Return _ListaTelefono
        End Get
        Set(value As List(Of Integer))
            _ListaTelefono = value
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
    Public Sub clasePersona(ci_ As Integer, nombreP_ As String, tel_ As List(Of Integer), dir_ As String)
        Ci = ci_
        Nombre = nombreP_
        ListaTelefono = tel_
        direccion = dir_
    End Sub

    Public Sub clasePersona()

    End Sub


End Class

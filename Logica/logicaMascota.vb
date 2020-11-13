Public Class logicaMascota
    Public Sub altaMascota(mascota As claseMascota)
        Dim persistencia As New persitenciaMascota
        persistencia.AltaMascota(mascota)
    End Sub
    Public Function listarMascota(ci As Integer) As List(Of claseMascota)
        Dim pesistencaias As New persitenciaMascota
        Return pesistencaias.listarMascota(ci)
    End Function
    Public Sub modificarMascota(mascota As claseMascota)
        Dim persistencia As New persitenciaMascota
        persistencia.modificarMascota(mascota)
    End Sub
    Public Function buscarMascota(ci As Integer) As claseMascota
        Dim persistencias As New persitenciaMascota
        Return persistencias.buscarMascota(ci)
    End Function
    Public Sub bajaMascotas(ci As Integer)
        Dim persistencia As New persitenciaMascota
        persistencia.bajaMascotas(ci)
    End Sub
    Public Sub borrarMascota(id As Integer)
        Dim persistencias As New persitenciaMascota
        persistencias.borrarMascota(id)
    End Sub
End Class

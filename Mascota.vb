Public Class Mascota
    Dim nombreM As String
    Dim fechaNac As Integer
    Dim ciD As Integer
    Public id As Integer


    Private Sub lblfechanac_Click(sender As Object, e As EventArgs) Handles lblfechanac.Click


    End Sub

    Private Sub btnaceptarM_Click(sender As Object, e As EventArgs) Handles btnaceptarM.Click

        nombreM = (tbxnombreM.Text)
        fechaNac = CInt(tbxañoDeNac.Text)
        ciD = CInt(tbxciDueño.Text)
        Dim newMascota As New claseMascota
        Dim newlogicaPersona As New logicaPersona
        newMascota.Dueño = newlogicaPersona.buscarPersona(ciD)
        newMascota.NombreM = nombreM
        newMascota.FechaNac = fechaNac
        Dim logica As New logicaMascota()
        logica.altaMascota(newMascota)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles tbxnombreM.TextChanged


    End Sub

    Private Sub btncancelarM_Click(sender As Object, e As EventArgs) Handles btncancelarM.Click
        Me.Close()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        BuscarMascota.Show()


    End Sub

    Private Sub Mascota_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim newmascota As New claseMascota
        newmascota.NombreM = tbxnombreM.Text
        newmascota.FechaNac = CInt(tbxañoDeNac.Text)
        newmascota.Id = id
        Dim logica As New logicaMascota
        logica.modificarMascota(newmascota)
    End Sub
End Class
Public Class BuscarMascota
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        Dim newmascota As New claseMascota()
        Dim logica As New logicaMascota
        If tbxBuscar.Text = "" Then
            MessageBox.Show("ingrese una mascota")
        Else

            newmascota = logica.buscarMascota(Convert.ToInt32(tbxBuscar.Text))
            Mascota.Show()
            Mascota.tbxnombreM.Text = newmascota.NombreM
            Mascota.tbxañoDeNac.Text = newmascota.FechaNac
            Mascota.tbxciDueño.Enabled = False
        End If
    End Sub
End Class
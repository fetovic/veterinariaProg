Public Class Mascota
    Dim nombreM As String
    Dim fechaNac As Integer
    Dim ciD As Integer


    Private Sub lblfechanac_Click(sender As Object, e As EventArgs) Handles lblfechanac.Click


    End Sub

    Private Sub btnaceptarM_Click(sender As Object, e As EventArgs) Handles btnaceptarM.Click
        nombreM = (tbxnombreM.Text)
        fechaNac = CInt(tbxañoDeNac.Text)
        ciD = CInt(tbxciDueño.Text)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles tbxnombreM.TextChanged


    End Sub

    Private Sub btncancelarM_Click(sender As Object, e As EventArgs) Handles btncancelarM.Click
        Me.Close()
    End Sub
End Class
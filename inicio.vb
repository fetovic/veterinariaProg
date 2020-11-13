Public Class inicio
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub altaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaToolStripMenuItem.Click
        Persona.Show()
        Persona.Activate()

    End Sub
    Private Sub bajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarToolStripMenuItem.Click
        listaPersona.Show()
        listaPersona.Activate()

    End Sub

    Private Sub MascotaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MascotaToolStripMenuItem.Click
        Mascota.ShowDialog()
        Mascota.tbxciDueño.Enabled = True
        Mascota.btnModificar.Enabled = False
        Mascota.lblMascota.Text = "Alta Mascota"
    End Sub
End Class
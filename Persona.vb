Public Class Persona
    Dim listaTelefono As New List(Of Integer)





    Private Sub btnaceptarP_Click(sender As Object, e As EventArgs) Handles btnaceptarP.Click
        Dim ci As Integer
        ci = tbxci.Text
        Dim nombrep As String
        nombrep = tbxnombre.Text


        Dim direccion As String
        direccion = tbxdireccion.Text

        Dim newPersona As New clasePersona()
        newPersona.Ci = ci
        newPersona.Nombre = nombrep
        newPersona.direccion = direccion
        newPersona.ListaTelefono = listaTelefono

        Dim logicaPersona As New logicaPersona
        logicaPersona.AltaPersona(newPersona)


    End Sub

    Private Sub btncancelarp_Click(sender As Object, e As EventArgs) Handles btncancelarp.Click
        Me.Close()

    End Sub

    Private Sub tbxci_TextChanged(sender As Object, e As EventArgs) Handles tbxci.TextChanged
        Dim ci As Integer
        ci = tbxci.Text
        Dim newpersona As New clasePersona
        Dim logica As New logicaPersona
        newpersona = logica.buscarPersona(ci)
        If IsNothing(newpersona) Then
        Else
            tbxnombre.Text = newpersona.Nombre
            tbxdireccion.Text = newpersona.direccion
        End If
    End Sub

    Private Sub BtnTelefono_Click(sender As Object, e As EventArgs) Handles BtnTelefono.Click
        Dim telefonos As Integer

        telefonos = tbxtelefono.Text

        lVTelefonos.Items.Add(telefonos)

        listaTelefono.Add(telefonos)

        tbxtelefono.Text = ""

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim perosonaAModificar As New clasePersona
        perosonaAModificar.Ci = tbxci.Text
        perosonaAModificar.Nombre = tbxnombre.Text
        perosonaAModificar.direccion = tbxdireccion.Text

        Dim logica1 As New logicaPersona
        logica1.modificarPersona(perosonaAModificar)

    End Sub
End Class

Public Class Persona

    Dim ci As Integer
    Dim nombreP As String
    Dim telefono As Integer
    Dim direccion As String


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub


    Private Sub btnaceptarP_Click(sender As Object, e As EventArgs) Handles btnaceptarP.Click
        ci = CInt(tbxci.Text)
        nombreP = tbxnombre.Text
        telefono = CInt(tbxtelefono.Text)
        direccion = tbxdireccion.Text

        lblfin.Text = CStr(ci) + " " + nombreP + " " + CStr(telefono) + " " + direccion

        Dim newPersona As New clasePersona()
        newPersona.Ci = ci
        newPersona.Nombre = nombreP
        newPersona.direccion = direccion

        Dim logicaPersona As New logicaPersona
        logicaPersona.AltaPersona(newPersona)


    End Sub

    Private Sub btncancelarp_Click(sender As Object, e As EventArgs) Handles btncancelarp.Click
        Me.Close()

    End Sub

    Private Sub Persona_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

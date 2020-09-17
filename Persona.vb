Public Class Persona
    Dim listaTelefono As New List(Of Integer)





    Private Sub btnaceptarP_Click(sender As Object, e As EventArgs) Handles btnaceptarP.Click
        Try


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
        Catch ex As Exception
            MsgBox("hiciste cualquier cosa, :" + ex.Message)
        End Try

    End Sub

    Private Sub btncancelarp_Click(sender As Object, e As EventArgs) Handles btncancelarp.Click
        btnBuscar.Enabled = True
        tbxci.Enabled = True
        tbxdireccion.Enabled = False
        tbxnombre.Enabled = False
        tbxtelefono.Enabled = False
        lVTelefonos.Enabled = False
        btnaceptarP.Enabled = False
        btncancelarp.Enabled = False
        BtnTelefono.Enabled = False
        btnModificar.Enabled = False

        tbxci.Text = ""
        tbxdireccion.Text = ""
        tbxnombre.Text = ""
        tbxtelefono.Text = ""
        lVTelefonos.Clear()

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

        perosonaAModificar.ListaTelefono = listaTelefono

        Dim logica1 As New logicaPersona
        logica1.modificarPersona(perosonaAModificar)

    End Sub

    Private Sub lVTelefonos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lVTelefonos.SelectedIndexChanged
        Try
            Dim telefono As String
            Dim telefonoEleminado As Integer
            telefono = lVTelefonos.SelectedItems(0).SubItems(0).Text
            telefonoEleminado = Convert.ToInt32(telefono)
            Dim i As Integer = 0

            While listaTelefono.Count > i
                If listaTelefono.Item(i) = telefonoEleminado Then
                    listaTelefono.Remove(telefonoEleminado)
                    i = listaTelefono.Count
                End If
                i = i + 1
            End While
            lVTelefonos.Clear()
            i = 0
            While listaTelefono.Count > i
                lVTelefonos.Items.Add(listaTelefono.Item(i))
                i = i + 1

            End While

        Catch ex As Exception
            MsgBox("hiciste cualquier cosa, :" + ex.Message)
        End Try

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim ci As Integer
        ci = tbxci.Text
        Dim newpersona As New clasePersona
        Dim logica As New logicaPersona
        newpersona = logica.buscarPersona(ci)
        lVTelefonos.Clear()
        If IsNothing(newpersona) Then
            btnBuscar.Enabled = True
            tbxci.Enabled = True
            tbxdireccion.Enabled = True
            tbxnombre.Enabled = True
            tbxtelefono.Enabled = True
            lVTelefonos.Enabled = True
            btnaceptarP.Enabled = True
            btncancelarp.Enabled = True
            BtnTelefono.Enabled = True
            btnModificar.Enabled = False
        Else
            tbxnombre.Text = newpersona.Nombre
            tbxdireccion.Text = newpersona.direccion
            listaTelefono = newpersona.ListaTelefono
            Dim i As Integer = 0
            While listaTelefono.Count > i
                lVTelefonos.Items.Add(listaTelefono(i))
                i = i + 1

            End While
            btnBuscar.Enabled = False
            tbxci.Enabled = False
            tbxdireccion.Enabled = True
            tbxnombre.Enabled = True
            tbxtelefono.Enabled = True
            lVTelefonos.Enabled = True
            btnaceptarP.Enabled = False
            btncancelarp.Enabled = True
            BtnTelefono.Enabled = True
            btnModificar.Enabled = True
        End If

    End Sub

    Private Sub Persona_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnBuscar.Enabled = True
        tbxci.Enabled = True
        tbxdireccion.Enabled = False
        tbxnombre.Enabled = False
        tbxtelefono.Enabled = False
        lVTelefonos.Enabled = False
        btnaceptarP.Enabled = False
        btncancelarp.Enabled = False
        BtnTelefono.Enabled = False
        btnModificar.Enabled = False
    End Sub

    Private Sub lblfin_Click(sender As Object, e As EventArgs) Handles lblfin.Click

    End Sub
End Class

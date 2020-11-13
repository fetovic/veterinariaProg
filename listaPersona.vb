Public Class listaPersona
    Public Sub listarMascotas()
        lvTelefono.Items.Clear()
        Dim logica As New logicaMascota
        Dim listaMascota As List(Of claseMascota) = logica.listarMascota(CInt(lvListarPersona.FocusedItem.SubItems(0).Text))
        For index As Integer = 0 To listaMascota.Count - 1
            Dim arra(3) As String
            arra(0) = listaMascota(index).Id.ToString
            arra(1) = listaMascota(index).NombreM
            arra(2) = listaMascota(index).FechaNac.ToString
            Dim item As New ListViewItem(arra)
            lvTelefono.Items.Add(item)
        Next

    End Sub
    Public Sub listarPeronas()
        lvListarPersona.Items.Clear()
        Dim logica As New logicaPersona

        lista = logica.logicaListarPersona
        Dim i As Integer
        i = logica.logicaListarPersona.Count - 1
        Dim item As ListViewItem
        Dim arra(3) As String

        While i <> -1
            arra(0) = lista(i).Ci
            arra(1) = lista(i).Nombre
            arra(2) = lista(i).direccion


            item = New ListViewItem(arra)
            lvListarPersona.Items.Add(item)
            i = i - 1


        End While
    End Sub
    Dim lista As New List(Of clasePersona)
    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvListarPersona.SelectedIndexChanged

        lvTelefono.Items.Clear()
        Dim logica As New logicaMascota
        Dim listaMascota As New List(Of claseMascota)
        listaMascota = logica.listarMascota(CInt(lvListarPersona.FocusedItem.SubItems(0).Text))
        For index As Integer = 0 To listaMascota.Count - 1
            Dim arra(3) As String
            arra(0) = listaMascota(index).Id.ToString
            arra(1) = listaMascota(index).NombreM
            arra(2) = listaMascota(index).FechaNac.ToString
            Dim item As New ListViewItem(arra)
            lvTelefono.Items.Add(item)
        Next



    End Sub


    Private Sub listaPersona_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim logica As New logicaPersona

        lista = logica.logicaListarPersona
        Dim i As Integer
        i = logica.logicaListarPersona.Count - 1
        Dim item As ListViewItem
        Dim arra(3) As String

        While i <> -1
            arra(0) = lista(i).Ci
            arra(1) = lista(i).Nombre
            arra(2) = lista(i).direccion


            item = New ListViewItem(arra)
            lvListarPersona.Items.Add(item)
            i = i - 1


        End While

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnEliminarM_Click(sender As Object, e As EventArgs) Handles btnEliminarM.Click
        If lvTelefono.FocusedItem.SubItems(0).Text = "" Then
            MessageBox.Show("selecciona una mascota")
        Else
            Dim logica As New logicaMascota
            logica.borrarMascota(CInt(lvTelefono.FocusedItem.SubItems(0).Text))
        End If
    End Sub

    Private Sub btnModificarM_Click(sender As Object, e As EventArgs) Handles btnModificarM.Click
        If lvTelefono.FocusedItem.SubItems(0).Text = "" Then
            MessageBox.Show("selecciona una mascota")
        Else
            Dim logica As New logicaMascota

            Dim newMascotas As New claseMascota
            newMascotas = logica.buscarMascota(CInt(lvTelefono.FocusedItem.SubItems(0).Text))
            Mascota.tbxciDueño.Enabled = False
            Mascota.tbxciDueño.Text = newMascotas.Dueño.Ci.ToString
            Mascota.tbxañoDeNac.Text = newMascotas.FechaNac
            Mascota.tbxnombreM.Text = newMascotas.NombreM
            Mascota.btnaceptarM.Enabled = False
            Mascota.id = newMascotas.Id
            Mascota.Show()
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim logicaP As New logicaPersona
        Dim logicam As New logicaMascota
        Dim ci As Integer = CInt(lvListarPersona.FocusedItem.SubItems(0).Text)
        logicam.bajaMascotas(ci)
        logicaP.borrarPersona(ci)
        Me.listarPeronas()
        lvTelefono.Items.Clear()
    End Sub
End Class
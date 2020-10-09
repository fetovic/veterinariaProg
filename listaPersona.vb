Public Class listaPersona
    Dim lista As New List(Of clasePersona)
    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvListarPersona.SelectedIndexChanged
        lvTelefono.Items.Clear()
        Dim personas As New Persona
        Dim listaTelefonos As New List(Of Integer)
        For index As Integer = 0 To lista.Count
            If lista(index).Ci = Convert.ToInt32(lvListarPersona.FocusedItem.Text) Then

                listaTelefonos = lista(index).ListaTelefono
            End If
        Next
        For index As Integer = 0 To listaTelefonos.Count
            Convert.ToString(listaTelefonos(index))
            lvTelefono.Items.Add(listaTelefonos(index))
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
End Class
Public Class listaPersona
    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvListarPersona.SelectedIndexChanged

    End Sub

    Private Sub listaPersona_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim logica As New logicaPersona
        Dim lista As New List(Of clasePersona)
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
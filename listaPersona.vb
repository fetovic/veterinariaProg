Public Class listaPersona
    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvListarPersona.SelectedIndexChanged

    End Sub

    Private Sub listaPersona_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim logica As New logicaPersona
        Dim listaPersona As List(Of clasePersona)
        listaPersona = logica.logicaListarPersona
        For index As Integer = 0 To listaPersona.Count - 1
            Dim item = New ListViewItem
            item.listaPersona(index).Ci
            lvListarPersona.Items.Add(item)


        Next
    End Sub
End Class
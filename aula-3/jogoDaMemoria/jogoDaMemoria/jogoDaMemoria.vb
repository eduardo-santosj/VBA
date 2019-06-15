Public Class jogoDaMemoria

    Dim img(7) As Image
    Dim tags(2) As Integer
    Dim lista As New List(Of String)


    Private Sub jogoDaMemoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'define o modo de exibição do listview
        ListView1.View = View.Details
        ' cria tres itens e tres conjuntos de subitems para cada item
        Dim player = InputBox("Digite o nome do Jogador 1")
        Dim item1 As New ListViewItem(player, 0)
        item1.SubItems.Add("1")
        Dim item2 As New ListViewItem("item2", 1)
        item2.SubItems.Add("1")
        ' Cria coluna para os itens e subitens
        ListView1.Columns.Add("Nome Jogador", -2, HorizontalAlignment.Left)
        ListView1.Columns.Add("Numero de Vezes", -2, HorizontalAlignment.Left)
        'inclui os itens no listview
        ListView1.Items.AddRange(New ListViewItem() {item1, item2})
        Controls.Add(ListView1)


        Dim pontosX() As Integer = {39, 204, 368, 535}
        Dim pontosY() As Integer = {38, 188, 326, 460}

        For Each pbx As PictureBox In Controls.OfType(Of PictureBox)
            Dim rdn As Random = New Random()

            Dim x As Integer = pontosX(rdn.Next(4))
            Dim y As Integer = pontosY(rdn.Next(4))

            pbx.Location = New Point(x, y)
        Next
    End Sub
End Class

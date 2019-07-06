Imports System.Threading

Public Class jogoDaMemoria

    Dim listaImagens(8) As Image
    Dim tags(2), clicks, tagClick1, tagClick2, numeroJogadas, pontuacaoGanhou As Integer
    Dim posicoesEscolhidas As New List(Of String)
    Dim imgClick1, imgClick2 As PictureBox
    Dim item1 As New ListViewItem()
    Dim lblJogadas As New Label()

    Private Sub Pbx_Click(sender As Object, e As EventArgs) Handles Pbx1.Click, Pbx2.Click, Pbx3.Click, Pbx4.Click, Pbx5.Click, Pbx6.Click, Pbx7.Click, Pbx8.Click, Pbx9.Click, Pbx10.Click, Pbx11.Click, Pbx12.Click, Pbx13.Click, Pbx14.Click, Pbx15.Click, Pbx16.Click
        revelaImagem(sender)
    End Sub

    Private Sub jogoDaMemoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        novoJogo()
    End Sub

    Sub revelaImagem(pbx As PictureBox)
        clicks = clicks + 1
        numeroJogadas = numeroJogadas + 1

        pbx.Image = listaImagens(pbx.Tag)
        pbx.Enabled = False

        If (clicks = 1) Then
            tagClick1 = pbx.Tag
            imgClick1 = pbx

        Else
            tagClick2 = pbx.Tag
            imgClick2 = pbx

            Thread.Sleep(1000)

            Dim acertou As Boolean
            acertou = (tagClick1 = tagClick2)

            If (acertou) Then
                'acertou
                imgClick1.Enabled = False
                imgClick2.Enabled = False
                pontuacaoGanhou = pontuacaoGanhou + 1
                If (pontuacaoGanhou = 8) Then
                    Dim vitoria = MsgBox("Você Ganhou" & Chr(13) & Chr(13) & "Quer iniciar um novo jogo?", vbInformation + vbYesNo, "GANHOU")
                    If (vitoria = vbYes) Then
                        novoJogo()

                    Else
                        Close()
                    End If
                End If
            Else
                imgClick1.Image = My.Resources.verso
                imgClick2.Image = My.Resources.verso
                imgClick1.Enabled = True
                imgClick2.Enabled = True
            End If

            clicks = 0
        End If

        lblJogadas.Text = numeroJogadas

    End Sub

    Sub novoJogo()
        Dim player = InputBox("Digite o nome do Jogador 1")
        lblJogadas.Text = numeroJogadas
        Dim lblNome As New Label
        lblNome.Text = player
        TableLayoutPanel1.Controls.Add(lblNome, 0, 0)
        TableLayoutPanel1.Controls.Add(lblJogadas, 1, 0)

        Dim pontosX() As Integer = {39, 204, 368, 535}
        Dim pontosY() As Integer = {38, 188, 326, 460}
        posicoesEscolhidas.Clear()

        'percorre todas as picturesBox
        For Each pbx As PictureBox In Controls.OfType(Of PictureBox)
            'gerar possições aleatórias para as imagens
            Dim rdn As Random = New Random()
            Dim x, y As Integer
            Dim posicao As String

            Do
                x = pontosX(rdn.Next(4))
                y = pontosY(rdn.Next(4))
                posicao = x & "X" & y
                'Pode ser uma dessas duas opções
                'Loop Until (posicoesEscolhidas.Contains() = false)
            Loop Until (Not posicoesEscolhidas.Contains(posicao))

            pbx.Location = New Point(x, y)
            posicoesEscolhidas.Add(posicao)

            'deixar as imagens viradas
            listaImagens(pbx.Tag) = pbx.Image
            pbx.Image = My.Resources.verso
            pbx.Enabled = True
        Next
    End Sub


End Class

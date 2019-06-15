Public Class jogoDaVelha

    Dim player1, player2 As String
    Dim jogadorDaVez As Integer
    Dim resultado As MsgBoxResult
    Private Sub JogoDaVelha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NomeJogador()
        ClearButton()
    End Sub

    Private Sub BtnNovoJogo_Click(sender As Object, e As EventArgs) Handles BtnNovoJogo.Click

        ClearButton()

    End Sub

    Private Sub BtnA1_Click(sender As Object, e As EventArgs) Handles BtnA1.Click
        VerificarJogada(BtnA1)
    End Sub

    Private Sub BtnB1_Click(sender As Object, e As EventArgs) Handles BtnB1.Click
        VerificarJogada(BtnB1)
    End Sub

    Private Sub BtnC1_Click(sender As Object, e As EventArgs) Handles BtnC1.Click
        VerificarJogada(BtnC1)
    End Sub

    Private Sub BtnA2_Click(sender As Object, e As EventArgs) Handles BtnA2.Click
        VerificarJogada(BtnA2)
    End Sub

    Private Sub BtnB2_Click(sender As Object, e As EventArgs) Handles BtnB2.Click
        VerificarJogada(BtnB2)
    End Sub

    Private Sub BtnB3_Click(sender As Object, e As EventArgs) Handles BtnB3.Click
        VerificarJogada(BtnB3)
    End Sub

    Private Sub BtnC2_Click(sender As Object, e As EventArgs) Handles BtnC2.Click
        VerificarJogada(BtnC2)
    End Sub

    Private Sub BtnC3_Click(sender As Object, e As EventArgs) Handles BtnC3.Click
        VerificarJogada(BtnC3)
    End Sub

    Private Sub BtnA3_Click(sender As Object, e As EventArgs) Handles BtnA3.Click
        VerificarJogada(BtnA3)
    End Sub


    Private Sub VerificarJogada(botao As Button)
        If (botao.Text = "") Then
            If (jogadorDaVez = 1) Then
                botao.Text = "X"
                botao.BackColor = Color.FromArgb(255, 0, 0)
                botao.FlatAppearance.BorderColor = Color.FromArgb(255, 0, 0)
                VerificarGanhador("X")
                If (resultado = 6) Then
                    ClearButton()
                Else
                    LblJogador.Text = player2
                    jogadorDaVez = 2
                End If



            Else
                    botao.Text = "O"
                botao.BackColor = Color.FromArgb(0, 188, 0)
                botao.FlatAppearance.BorderColor = Color.FromArgb(0, 188, 0)
                VerificarGanhador("O")
                If (resultado = 6) Then
                    ClearButton()
                Else
                    LblJogador.Text = player1
                    jogadorDaVez = 1
                End If
            End If
        Else
            MsgBox("Opção já escolhida", vbCritical, "Campo já selecionado")
        End If
    End Sub


    Private Sub VerificarGanhador(simbolo As String)

        Dim flagGanhador As Boolean = False

        If (BtnA1.Text = simbolo And BtnA2.Text = simbolo And BtnA3.Text = simbolo) Then
            flagGanhador = True
        ElseIf (BtnB1.Text = simbolo And BtnB2.Text = simbolo And BtnB3.Text = simbolo) Then
            flagGanhador = True
        ElseIf (BtnC1.Text = simbolo And BtnC2.Text = simbolo And BtnC3.Text = simbolo) Then
            flagGanhador = True
        ElseIf (BtnA1.Text = simbolo And BtnB1.Text = simbolo And BtnC1.Text = simbolo) Then
            flagGanhador = True
        ElseIf (BtnA2.Text = simbolo And BtnB2.Text = simbolo And BtnC2.Text = simbolo) Then
            flagGanhador = True
        ElseIf (BtnA3.Text = simbolo And BtnB3.Text = simbolo And BtnC3.Text = simbolo) Then
            flagGanhador = True
        ElseIf (BtnA1.Text = simbolo And BtnB2.Text = simbolo And BtnC3.Text = simbolo) Then
            flagGanhador = True
        ElseIf (BtnA3.Text = simbolo And BtnB2.Text = simbolo And BtnC1.Text = simbolo) Then
            flagGanhador = True
        End If


        If (flagGanhador = True) Then

            resultado = MsgBox("O jogador ganhador foi: " & LblJogador.Text & Chr(13) & Chr(13) & "Quer iniciar novo jogo?", vbInformation + vbYesNo, "GANHADOR")
            If (jogadorDaVez = 1) Then
                LblVitoriaPlayer1.Text = LblVitoriaPlayer1.Text + 1
            Else
                LblVitoriaPlayer2.Text = LblVitoriaPlayer2.Text + 1
            End If
            If (resultado = vbYes) Then
                ClearButton()
            End If

            'Desabilita botões
            BtnA1.Enabled = False
            BtnA2.Enabled = False
            BtnA3.Enabled = False
            BtnB1.Enabled = False
            BtnB2.Enabled = False
            BtnB3.Enabled = False
            BtnC1.Enabled = False
            BtnC2.Enabled = False
            BtnC3.Enabled = False

        Else
            If (BtnA1.Text <> "" And BtnA2.Text <> "" And BtnA3.Text <> "" _
                And BtnB1.Text <> "" And BtnB2.Text <> "" And BtnB3.Text <> "" _
                And BtnC1.Text <> "" And BtnC2.Text <> "" And BtnC3.Text <> "") Then

                Dim empate As MsgBoxResult
                empate = MsgBox("Deu empate" & Chr(13) & Chr(13) & "Quer iniciar um novo jogo?", vbInformation + vbYesNo, "EMPATE")
                LblEmpate.Text = LblEmpate.Text + 1
                If (empate = vbYes) Then
                    ClearButton()
                End If

                BtnA1.Enabled = False
                BtnA2.Enabled = False
                BtnA3.Enabled = False
                BtnB1.Enabled = False
                BtnB2.Enabled = False
                BtnB3.Enabled = False
                BtnC1.Enabled = False
                BtnC2.Enabled = False
                BtnC3.Enabled = False
            End If
        End If
    End Sub


    Private Sub NomeJogador()
        player1 = InputBox("Digite o nome do Jogador 1")
        player2 = InputBox("Digite o nome do Jogador 2")
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If (jogadorDaVez = 1) Then
            player1 = InputBox("Digite o nome do Jogador 1")
            LblJogador.Text = player1
        Else
            player2 = InputBox("Digite o Nome do Jogador 2")
            LblJogador.Text = player2
        End If
    End Sub

    Private Sub ClearButton()
        LblJogador.Text = player1
        jogadorDaVez = 1

        BtnA1.Text = ""
        BtnA1.Enabled = True

        BtnA2.Text = ""
        BtnA2.Enabled = True

        BtnA3.Text = ""
        BtnA3.Enabled = True

        BtnB1.Text = ""
        BtnB1.Enabled = True

        BtnB2.Text = ""
        BtnB2.Enabled = True

        BtnB3.Text = ""
        BtnB3.Enabled = True

        BtnC1.Text = ""
        BtnC1.Enabled = True

        BtnC2.Text = ""
        BtnC2.Enabled = True

        BtnC3.Text = ""
        BtnC3.Enabled = True

        BtnA1.BackColor = Color.FromArgb(255, 255, 255)
        BtnA2.BackColor = Color.FromArgb(255, 255, 255)
        BtnA3.BackColor = Color.FromArgb(255, 255, 255)
        BtnB1.BackColor = Color.FromArgb(255, 255, 255)
        BtnB2.BackColor = Color.FromArgb(255, 255, 255)
        BtnB3.BackColor = Color.FromArgb(255, 255, 255)
        BtnC1.BackColor = Color.FromArgb(255, 255, 255)
        BtnC2.BackColor = Color.FromArgb(255, 255, 255)
        BtnC3.BackColor = Color.FromArgb(255, 255, 255)

        BtnA1.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0)
        BtnA2.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0)
        BtnA3.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0)
        BtnB1.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0)
        BtnB2.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0)
        BtnB3.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0)
        BtnC1.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0)
        BtnC2.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0)
        BtnC3.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0)
    End Sub

End Class


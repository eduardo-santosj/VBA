Public Class jogoDaForca
    Dim palavra As String
    Dim tentativas As Integer
    Dim listAcertos As String = ""
    Private Sub jogoDaForca_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        NovoJogo()

    End Sub

    Private Sub VisibilidadePbx()
        For Each pbx As PictureBox In Controls.OfType(Of PictureBox)
            pbx.Visible = False
        Next
    End Sub

    Private Sub TXT_letra_TextChanged(sender As Object, e As EventArgs) Handles TXT_letra.TextChanged

        Dim letra As Char
        letra = TXT_letra.Text.Trim.ToUpper


        If (letra <> "") Then
            'Verifica se foi digitado uma letra
            If (Char.IsLetter(letra)) Then

                If (TXT_letras_error.Text.Contains(letra) = True And listAcertos.Contains(letra) = True) Then

                    MessageBox.Show("Letra já foi digitada")

                Else

                    If (palavra.Contains(letra)) Then

                        tentativaAcerto(letra)

                    Else

                        tentativaError(letra)

                    End If

                End If
            End If
        End If

        TXT_letra.Clear()
    End Sub

    Private Sub tentativaError(letra As Char)

        tentativas += 1

        Select Case tentativas

            Case 1
                PBX_cabeca.Visible = True

            Case 2
                PBX_tronco.Visible = True

            Case 3
                PBX_braco_dir.Visible = True

            Case 4
                PBX_braco_esq.Visible = True

            Case 5
                PBX_perna_dir.Visible = True

            Case 6
                PBX_perna_dir.Visible = True
                Dim perdeu = MsgBox("Você Perdeu" & Chr(13) & Chr(13) & "Quer iniciar um novo jogo?", vbCritical + vbYesNo, "PERDEU")
                If (perdeu = vbYes) Then
                    NovoJogo()
                Else
                    Close()
                End If

        End Select

        TXT_letras_error.Text += letra

    End Sub

    Private Sub tentativaAcerto(letra As Char)
        listAcertos += letra
        TXT_acertos.Clear()

        For l = 0 To palavra.Length - 1
            If (palavra.Chars(l) = letra Or listAcertos.Contains(palavra.Chars(l))) Then
                TXT_acertos.Text += " " + palavra.Chars(l) + " "

            Else

                TXT_acertos.Text += " _ "

            End If
        Next

        If (palavra.Length = TXT_acertos.Text.Replace(" ", "").Replace("_", "").Length) Then
            Dim ganhou = MsgBox("Você Ganhou" & Chr(13) & Chr(13) & "Quer iniciar um novo jogo?", vbCritical + vbYesNo, "Ganhou")
            If (ganhou = vbYes) Then
                NovoJogo()
            Else
                Close()
            End If

        End If

    End Sub

    Private Sub NovoJogo()
        tentativas = 0
        listAcertos = ""
        TXT_acertos.Text = ""
        TXT_letra.Text = ""
        VisibilidadePbx()

        palavra = InputBox("Digitie uma palavra para iniciara o jogo", "Jogo da Forca").ToUpper
        Dim count As Integer
        count = palavra.Length

        For l = 0 To count - 1
            TXT_acertos.Text += " _ "
        Next

    End Sub
End Class

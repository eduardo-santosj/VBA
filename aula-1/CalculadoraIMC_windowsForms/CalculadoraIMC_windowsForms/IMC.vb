Public Class IMC


    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click


        'Declaração das variáveis
        'Dim para falar que é uma variável
        'As String = é um texto
        'As Decimal = é um valor Real
        Dim nome, classificacao As String
        Dim peso, altura, imc As Decimal

        nome = TxtNome.Text
        altura = TxtAltura.Text
        peso = TxtPeso.Text

        imc = peso / altura ^ 2

        If (imc < 18.5) Then
            classificacao = "Abaixo do peso"

        ElseIf (imc < 24.9) Then
            classificacao = "Peso normal"

        ElseIf (imc < 29.9) Then
            classificacao = "Sobrepeso"

        ElseIf (imc < 34.9) Then
            classificacao = "Obesidade grau 1"

        ElseIf (imc < 39.9) Then
            classificacao = "Obesidade grau 2"

        Else
            classificacao = "Obesidade grau 3"

        End If

        LblImc.Text = "IMC: " & imc
        LblResultado.Text = "Resultado: " & classificacao


    End Sub

End Class

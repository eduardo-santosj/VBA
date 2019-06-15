Module moduloIMC

    Sub Main()

        'Declaração das variáveis
        'Dim para falar que é uma variável
        'As String = é um texto
        'As Decimal = é um valor Real
        Dim nome, classificacao As String
        Dim peso, altura, imc As Decimal

        Console.WriteLine("Escreva seu Nome:")
        nome = Console.ReadLine()

        Console.WriteLine("Escreva sua Altura:")
        altura = Console.ReadLine()

        Console.WriteLine("Escreva seu Peso:")
        peso = Console.ReadLine()

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

        Console.WriteLine("Nome: " & nome)
        Console.WriteLine("Peso: " & peso)
        Console.WriteLine("Altura: " & altura)
        Console.WriteLine("IMC: " & imc)
        Console.WriteLine("Resultado: " & classificacao)
        Console.ReadLine()
    End Sub

End Module

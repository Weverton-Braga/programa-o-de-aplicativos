using System;

class Exercicio10
{
    static void Main()
    {
        Console.Write("Digite um número inteiro: ");
        int numero = int.Parse(Console.ReadLine());

        int resto = numero % 2;

        Console.WriteLine("O resto da divisão por 2 é: " + resto);
        Console.ReadLine();
    }
}

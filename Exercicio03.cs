using System;
using System.Globalization;

class Exercicio03
{
    static void Main()
    {
        Console.Write("Digite um número de ponto flutuante: ");
        float numero = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("O número digitado foi: " + numero);
    }
}

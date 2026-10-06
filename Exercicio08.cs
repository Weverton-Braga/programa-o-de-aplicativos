using System;
using System.Globalization;

class Exercicio08
{
    static void Main()
    {
        Console.Write("Digite o preço do produto: ");
        double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("Digite o desconto (em %): ");
        double desconto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double precoFinal = preco - (preco * desconto / 100);

        Console.WriteLine("O preço final com desconto é: " + precoFinal);
    }
}

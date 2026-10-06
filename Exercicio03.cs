using System;
using System.Globalization;

class Exercicio03
{
    static void Main()
    {
        Console.Write("Digite um número: ");
        double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double metade = numero / 2;

        Console.WriteLine("A metade é: " + metade);
        Console.ReadLine();
    }
}

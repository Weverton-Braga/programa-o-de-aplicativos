using System;
using System.Globalization;

class Exercicio04
{
    static void Main()
    {
        Console.Write("Digite um número: ");
        double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double quadrado = numero * numero;

        Console.WriteLine("O quadrado é: " + quadrado);
        Console.ReadLine();
    }
}

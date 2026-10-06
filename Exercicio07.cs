using System;
using System.Globalization;

class Exercicio07
{
    static void Main()
    {
        Console.Write("Digite o primeiro número: ");
        double num1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("Digite o segundo número: ");
        double num2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double subtracao = num2 - num1;

        Console.WriteLine("O resultado da subtração do segundo pelo primeiro é: " + subtracao);
        Console.ReadLine();
    }
}

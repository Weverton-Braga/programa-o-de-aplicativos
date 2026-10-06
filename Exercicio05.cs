using System;
using System.Globalization;

class Exercicio05
{
    static void Main()
    {
        Console.Write("Digite o primeiro número: ");
        double num1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("Digite o segundo número: ");
        double num2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double divisao = num1 / num2;

        Console.WriteLine("O resultado da divisão é: " + divisao);
        Console.ReadLine();
    }
}

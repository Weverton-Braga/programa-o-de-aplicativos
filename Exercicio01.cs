using System;
using System.Globalization;

class Exercicio01
{
    static void Main()
    {
        Console.Write("Digite o primeiro número: ");
        double num1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("Digite o segundo número: ");
        double num2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double soma = num1 + num2;

        Console.WriteLine("A soma é: " + soma);
        Console.ReadLine();
    }
}

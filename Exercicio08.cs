using System;
using System.Globalization;

class Exercicio08
{
    static void Main()
    {
        Console.Write("Digite um número: ");
        double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double valorAbsoluto = Math.Abs(numero);

        Console.WriteLine("O valor absoluto é: " + valorAbsoluto);
        Console.ReadLine();
    }
}

using System;
using System.Globalization;

class Exercicio02
{
    static void Main()
    {
        Console.Write("Digite um número real: ");
        double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("O número digitado foi: " + numero);
    }
}

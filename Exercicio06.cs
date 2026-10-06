using System;
using System.Globalization;

class Exercicio06
{
    static void Main()
    {
        Console.Write("Digite um número decimal: ");
        decimal numero = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("O número digitado foi: " + numero);
    }
}

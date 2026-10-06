using System;
using System.Globalization;

class Exercicio02
{
    static void Main()
    {
        Console.Write("Digite um número: ");
        double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double dobro = numero * 2;

        Console.WriteLine("O dobro é: " + dobro);
        Console.ReadLine();
    }
}

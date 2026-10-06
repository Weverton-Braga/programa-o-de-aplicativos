using System;
using System.Globalization;

class Exercicio06
{
    static void Main()
    {
        Console.Write("Digite um número: ");
        double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double raiz = Math.Sqrt(numero);

        Console.WriteLine("A raiz quadrada é: " + raiz);
        Console.ReadLine();
    }
}

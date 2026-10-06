using System;

class Exercicio04
{
    static void Main()
    {
        Console.Write("Digite \"sim\" ou \"não\": ");
        string resposta = Console.ReadLine();

        bool valor = resposta.Trim().ToLower() == "sim";

        Console.WriteLine("O valor armazenado foi: " + valor);
    }
}

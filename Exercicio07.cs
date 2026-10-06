using System;

class Exercicio07
{
    static void Main()
    {
        Console.Write("Digite o seu nome: ");
        string nome = Console.ReadLine();

        Console.Write("Digite a sua idade: ");
        int idade = int.Parse(Console.ReadLine());

        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Idade: " + idade);
    }
}

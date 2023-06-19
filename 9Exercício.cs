using System;

class Program
{
    static void Main(string[] args)
    {
        //Exercício 09
        Console.WriteLine("Digite a sua idade em anos:");
        int idadeAnos = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite os meses:");
        int idadeMeses = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite os dias:");
        int idadeDias = int.Parse(Console.ReadLine());

        int idade = (idadeAnos * 365) + (idadeMeses * 30) + idadeDias;

        Console.WriteLine("A idade da pessoa em dias: " + idade);
    }
}


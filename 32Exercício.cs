using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite uma sequência de números positivos (insira um número negativo para encerrar):");

        int numero;
        int menor = int.MaxValue, maior = int.MinValue;

        while ((numero = int.Parse(Console.ReadLine())) >= 0)
        {
            menor = Math.Min(menor, numero);
            maior = Math.Max(maior, numero);
        }

        if (menor == int.MaxValue || maior == int.MinValue)
        {
            Console.WriteLine("Nenhum número positivo foi inserido.");
        }
        else
        {
            Console.WriteLine("O menor número é: " + menor);
            Console.WriteLine("O maior número é: " + maior);
        }
    }
}

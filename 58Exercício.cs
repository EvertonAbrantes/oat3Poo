using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Quantidade de números a serem lidos:");
        int quantidade = Convert.ToInt32(Console.ReadLine());

        int[] numeros = new int[quantidade];

        
        for (int i = 0; i < quantidade; i++)
        {
            Console.WriteLine("Digite o número " + (i + 1) + ":");
            numeros[i] = Convert.ToInt32(Console.ReadLine());
        }

        int maior = numeros[0];
        int soma = numeros[0];

        
        for (int i = 1; i < quantidade; i++)
        {
            if (numeros[i] > maior)
            {
                maior = numeros[i];
            }
            soma += numeros[i];
        }

        double media = (double)soma / quantidade;

        Console.WriteLine("Média: " + media);
        Console.WriteLine("Maior número: " + maior);
    }
}
using System;

class Program
{
    static void Main()
    {
        int[] vetor = new int[10]; 

        
        Console.WriteLine("Digite os 10 números inteiros positivos maiores que zero:");
        for (int i = 0; i < 10; i++)
        {
            vetor[i] = Convert.ToInt32(Console.ReadLine());
        }

        
        Console.WriteLine("Digite um número inteiro positivo maior que zero:");
        int x = Convert.ToInt32(Console.ReadLine());

       
        int maiores = Array.FindAll(vetor, n => n > x).Length;
        int menores = Array.FindAll(vetor, n => n < x).Length;
        int iguais = Array.FindAll(vetor, n => n == x).Length;

       
        Console.WriteLine("Quantidade de números maiores que X: " + maiores);
        Console.WriteLine("Quantidade de números menores que X: " + menores);
        Console.WriteLine("Quantidade de números iguais a X: " + iguais);
    }
}
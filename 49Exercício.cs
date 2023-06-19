using System;

class Program
{
    static void Main()
    {
        int[] V1 = new int[50]; 
        int[] V2 = new int[50]; 
        int N; 

        
        Console.WriteLine("Digite o número de componentes dos vetores (N):");
        N = Convert.ToInt32(Console.ReadLine());

        
        Console.WriteLine("Digite os elementos do vetor V1:");
        for (int i = 0; i < N; i++)
        {
            V1[i] = Convert.ToInt32(Console.ReadLine());
        }

       
        Console.WriteLine("Digite os elementos do vetor V2:");
        for (int i = 0; i < N; i++)
        {
            V2[i] = Convert.ToInt32(Console.ReadLine());
        }

       
        int contador = 0;
        for (int i = 0; i < N; i++)
        {
            if (V1[i] == V2[i])
            {
                contador++;
            }
        }

        
        Console.WriteLine("Quantidade de valores idênticos nas mesmas posições: " + contador);
    }
}
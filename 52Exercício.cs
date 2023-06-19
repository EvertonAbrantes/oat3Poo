using System;

class Program
{
    static void Main()
    {
        int[] vetor = new int[100]; 
        int tamanho = 0; 

        
        Console.WriteLine("Digite os números inteiros positivos (-1 para sair):");

        while (true)
        {
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero == -1)
                break;

            vetor[tamanho] = numero;
            tamanho++;
        }

        
        int contador1 = 0, contador3 = 0, contador4 = 0;

        for (int i = 0; i < tamanho; i++)
        {
            if (vetor[i] == 1)
                contador1++;
            else if (vetor[i] == 3)
                contador3++;
            else if (vetor[i] == 4)
                contador4++;
        }

        
        Console.WriteLine("Quantidade de vezes que aparece o número 1: " + contador1);
        Console.WriteLine("Quantidade de vezes que aparece o número 3: " + contador3);
        Console.WriteLine("Quantidade de vezes que aparece o número 4: " + contador4);
    }
}
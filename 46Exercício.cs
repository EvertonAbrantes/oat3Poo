using System;

class Program
{
    static void Main()
    {
        int[] vetorX = { 1, 2, 3 }; 
        int[] vetorY = { 4, 5, 6 }; 

        int produtoEscalar = 0;

        for (int i = 0; i < vetorX.Length; i++)
        {
            produtoEscalar += vetorX[i] * vetorY[i];
        }

        Console.WriteLine("O produto escalar é: " + produtoEscalar);
    }
}
using System;

class Program
{
    static void Main()
    {
        int[] numeros = { 1, 2, 3, 4, 5 }; 

        Array.Reverse(numeros);

        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }
    }
}
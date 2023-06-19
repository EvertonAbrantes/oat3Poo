using System;

class Program
{
    static void Main()
    {
        int[] A = { 1, 2, 3, 4, 5 }; 
        int[] B = { 4, 5, 6, 7, 8, 9, 10, 11 }; 

        Console.WriteLine("Elementos comuns aos dois vetores:");

        foreach (int elementoA in A)
        {
            foreach (int elementoB in B)
            {
                if (elementoA == elementoB)
                {
                    Console.WriteLine(elementoA);
                    break;
                }
            }
        }
    }
}
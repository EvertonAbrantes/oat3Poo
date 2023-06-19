using System;

class Program
{
    static void Main()
    {
        string[] nomes = new string[20]; 
        int[] idades = new int[20]; 

        
        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine("Digite o nome da candidata:");
            nomes[i] = Console.ReadLine();

            Console.WriteLine("Digite a idade da candidata:");
            idades[i] = Convert.ToInt32(Console.ReadLine());
        }

        
        Console.WriteLine("Candidatas aptas a concorrer à vaga na campanha milionária:");

        for (int i = 0; i < 20; i++)
        {
            if (idades[i] >= 18 && idades[i] <= 20)
            {
                Console.WriteLine(nomes[i]);
            }
        }
    }
}
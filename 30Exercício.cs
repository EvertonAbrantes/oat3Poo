using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número para obter a tabuada: ");
        int numero = int.Parse(Console.ReadLine());

        Console.WriteLine("Tabuada do {numero}:");

        int i = 1;
        while (i <= 10)
        {
            int resultado = numero * i;
            Console.WriteLine("{numero} x {i} = {resultado}");
        }

        Console.ReadLine();
    }
}

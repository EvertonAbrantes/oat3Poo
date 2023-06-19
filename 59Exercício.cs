using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite dois caracteres de A a Z em ordem alfabética:");
        char char1 = Console.ReadKey().KeyChar;
        char char2 = Console.ReadKey().KeyChar;

        if (char1 > char2)
        {
            Console.WriteLine("\nErro: Os caracteres não estão em ordem alfabética.");
        }
        else
        {
            int numCaracteres = char2 - char1 - 1;
            Console.WriteLine("\nO número de caracteres entre eles é: " + numCaracteres);
        }
    }
}
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite uma frase:");
        string frase = Console.ReadLine(); // Leitura da frase

        string vogais = ""; // Variável para armazenar as vogais encontradas

        foreach (char c in frase)
        {
            if (IsVowel(c))
            {
                vogais += c;
            }
        }

        Console.WriteLine("Vogais encontradas: " + vogais);
    }

    static bool IsVowel(char c)
    {
        // Verifica se o caractere é uma vogal (maiúscula ou minúscula)
        return "AEIOU".Contains(c);
    }
}
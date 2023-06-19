using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite uma frase (até 50 caracteres):");
        string frase = Console.ReadLine(); 

        frase = frase.Replace(" ", ""); 
        int quantidadeEspacos = frase.Length - frase.Replace(" ", "").Length; 

        Console.WriteLine("Frase sem espaços em branco: " + frase);
        Console.WriteLine("Quantidade de espaços em branco: " + quantidadeEspacos);
    }
}
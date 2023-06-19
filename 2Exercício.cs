// See https://aka.ms/new-console-template for more information

using System;

class Program
{
    static void Main()
    {
        //Exercício 02
        Console.WriteLine("Digite a cotação atual do dólar:");
        double cotacao = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor em dólares:");
        double valorDolar = double.Parse(Console.ReadLine());

        double valorReal = valorDolar * cotacao;

        Console.WriteLine("O valor em reais é: " + valorReal);
    }
}


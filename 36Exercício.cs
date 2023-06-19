using System;

class Program
{
    static void Main(string[] args)
    {
        const int qntValores = 10;

        int maiorValor  
        int menorValor 
        int somaValores = 0;

        Console.WriteLine("Escreva 10 valores inteiros e positivos:");

        for (int i = 1; i <= qntValores; i++)
        {
            Console.Write($"Valor {i}: ");
            int valor = int.Parse(Console.ReadLine());

            if (valor > maiorValor)
                maiorValor = valor;

            if (valor < menorValor)
                menorValor = valor;

            somaValores += valor;
        }

        double mediaValores = (double)somaValores / quantidadeValores;

        Console.WriteLine("Maior valor: {maiorValor}");
        Console.WriteLine("Menor valor: {menorValor}");
        Console.WriteLine("Média dos valores: {mediaValores}");
    }
}

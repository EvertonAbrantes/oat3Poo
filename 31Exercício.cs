using System;

class Program
{
    static void Main()
    {
        int numero;
        int somaPares = 0;
        int somaImpares = 0;

        Console.WriteLine("Digite os números positivos (digite um número negativo para encerrar):");

        while ((numero = Convert.ToInt32(Console.ReadLine())) >= 0)
        {
            if (numero % 2 == 0)
                somaPares += numero;
            else
                somaImpares += numero;

            Console.WriteLine(numero % 2 == 0 ? "Par" : "Ímpar");
        }

        Console.WriteLine("Soma dos números pares: " + somaPares);
        Console.WriteLine("Soma dos números ímpares: " + somaImpares);
    }
}

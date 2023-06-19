using System;

class Program
{
    static void Main()
    {
        Decimal totalGraos = (Decimal)Math.Pow(2, 64) - 1;
        Console.WriteLine("O monge esperava receber um total de {0} grãos.", totalGraos);
    }
}
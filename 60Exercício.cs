using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o valor de x:");
        int x = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor de y:");
        int y = int.Parse(Console.ReadLine());

        int numeroQuadrante = (x > 0 && y > 0) ? 1 : (x < 0 && y > 0) ? 2 : (x < 0 && y < 0) ? 3 : (x > 0 && y < 0) ? 4 : 0;

        Console.WriteLine("O número do quadrante é: " + numeroQuadrante);
    }
}
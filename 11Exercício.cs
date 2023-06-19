class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o valor de A");
        int valorA = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor de B");
        int valorB = int.Parse(Console.ReadLine());

        Console.WriteLine("XXXXXXXXXXXXXXXXXXXX");

        int ResultadoA = (valorA + valorB) - valorA;
        Console.WriteLine("O resultado de A e:" + ResultadoA);

        int ResultadoB = (valorA + valorB) - valorB;
        Console.WriteLine("O resultado de B e:" + ResultadoB);

        Console.WriteLine("XXXXXXXXXXXXXXXXXXXX");

    }
}


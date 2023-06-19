
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite os valores dos lados do triângulo:");

        Console.Write("Lado A: ");
        int LadoA = int.Parse(Console.ReadLine());

        Console.Write("Lado B: ");
        int LadoB = int.Parse(Console.ReadLine());

        Console.Write("Lado C: ");
        int LadoC = int.Parse(Console.ReadLine());

        if ((LadoA + LadoB > LadoC) && (LadoA + LadoC > LadoB) && (LadoB + LadoC > LadoA))
        {
            if (LadoA == LadoB && LadoB == LadoC)
            {
                Console.WriteLine("O triângulo é equilátero.");
            }
            else if (LadoA == LadoB || LadoA == LadoC || LadoB == LadoC)
            {
                Console.WriteLine("O triângulo é isósceles.");
            }
            else
            {
                Console.WriteLine("O triângulo é escaleno.");
            }
        }
        else
        {
            Console.WriteLine("Os valores não podem formam um triângulo.");
        }
    }
}



class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o primeiro numero");
        int numero1 = int.Parse("Console.ReadLine()");

        Console.WriteLine("Digite o segundo numero");
        int numero2 = int.Parse("Console.ReadLine()");

        if (numero1 == numero2)
        {
            Console.WriteLine("Igual");
        }
        else
        {
            Console.WriteLine("Não igual");
            if (numero1 > numero2)
            {
                Console.WriteLine("Maior");
                Console.WriteLine("Maior ou igual");
            }
            else
            {
                Console.WriteLine("Menor");
                Console.WriteLine("Menor ou igual");
            }
        }

        Console.ReadLine();

    } 
}
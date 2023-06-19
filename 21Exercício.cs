class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um valor:");
        int valor = int.Parse(Console.ReadLine());

        if(valor >= 0)
        {
            Console.WriteLine("Esse número é positivo");
        }
        else
        {
            Console.WriteLine("Esse número é negativo");
        }
    }
}


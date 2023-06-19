
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());

        switch (numero)
        {
            case 1:
                Console.WriteLine("Um");
                break;
            case 2:
                Console.WriteLine("Dois");
                break;
            case 3:
                Console.WriteLine("Três");
                break;
            default:
                Console.WriteLine("Código inválido");
                break;
        }
    }
}



class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());

        int a, b;

        if (numero >= 0)
        {
            a = numero;
            Console.WriteLine($"O número {numero} foi armazenado em A.");
        }
        else
        {
            b = numero;
            Console.WriteLine($"O número {numero} foi armazenado em B.");
        }
    }
}

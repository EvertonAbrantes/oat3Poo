
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um número inteiro:");
        int numero = int.Parse(Console.ReadLine());

        int valorX;

        if (numero >= 0)
        {
            valorX = numero;
        }
        else
        {
            valorX = numero * -1;
        }

        Console.WriteLine("O valor do número é: " + valorX);
    }
}

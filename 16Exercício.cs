class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o primeiro valor:");
        int valorUM = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo valor:");
        int valorDois = int.Parse(Console.ReadLine());

        int maior, menor;

        switch (valorUM.CompareTo(valorDois))
        {
            case 1:
                maior = valorUM;
                menor = valorDois;
                break;
            case -1:
                maior = valorDois;
                menor = valorUM;
                break;
            default:
                Console.WriteLine("Os dois números são iguais: " + valorUM);
                return;
        }

        Console.WriteLine("O maior número é: " + maior);
        Console.WriteLine("O menor número é: " + menor);
    }
}
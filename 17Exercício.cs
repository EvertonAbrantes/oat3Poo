
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um valor inteiro");
        int valor = int.Parse(Console.ReadLine());

        if(valor >= 0 && valor <= 9)
        {
            Console.WriteLine("Valor Válido");
        }
        else
        {
            Console.WriteLine("Valor Inválido");
        }
        Console.WriteLine("O seu valor é "  + valor); 
    }
}



class Program
{
    static void Main(string[] args)
    {
        //Exercício 08

        Console.WriteLine("Digite o raio da lata de óleo:");
        double raio = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a altura da lata de óleo:");
        double altura = double.Parse(Console.ReadLine());

        double volume = (3.14159 * raio * raio * altura);

        Console.WriteLine("O Volume da lata de óleo é: " + volume);
    }
}

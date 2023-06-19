// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(string[] args)
    {
        // Exercício 01
        int quantidadeMinima, quantidadeMaxima;
        double estoqueMedio;

        Console.WriteLine("Informe a quantidade mínima:");
        quantidadeMinima = int.Parse(Console.ReadLine());

        Console.WriteLine("Informe a quantidade máxima:");
        quantidadeMaxima = int.Parse(Console.ReadLine());

        estoqueMedio = (quantidadeMinima + quantidadeMaxima) / 2.0;

        Console.WriteLine("O estoque médio é: " + estoqueMedio);

        Console.ReadLine();
    }
}

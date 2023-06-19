

using System;

class Program
{
    static void Main(string[] args)
    {
        //Exercício 03
        Console.WriteLine("---------- Comissão de Vendedores----------");

        Console.WriteLine("Digite o ID do vendedor: ");
        string ID = Console.ReadLine();

        Console.WriteLine("Digite o código da peça: ");
        string codigoPeca = Console.ReadLine();

        Console.WriteLine("Digite o preço da peça: ");
        double preco = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a quantidade vendida: ");
        int quantidadeVendida = int.Parse(Console.ReadLine());

        double totalVenda = preco * quantidadeVendida;
        double comissao = totalVenda /100 * 5;

        
        Console.WriteLine("Comissão: R$" + comissao);
        Console.WriteLine("---------------------------------------------------------");

        Console.ReadKey();
    }
}

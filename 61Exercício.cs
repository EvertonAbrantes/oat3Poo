using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o valor do salário:");
        double salario = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o índice de reajuste:");
        double indiceReajuste = Convert.ToDouble(Console.ReadLine());

        double salarioAtualizado = Reajuste(salario, indiceReajuste);

        Console.WriteLine("Salário atualizado: " + salarioAtualizado);
    }

    static double Reajuste(double salario, double indiceReajuste)
    {
        return salario * (1 + indiceReajuste);
    }
}
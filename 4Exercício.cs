// See
using System;

class Program
{
    static void Main(string[] args)
    {
        //Exercício 04
        Console.WriteLine("Digite o valor1:");
        int valor1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor2:");
        int valor2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor3:");
        int valor3 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor4:");
        int valor4 = int.Parse(Console.ReadLine());

        int resultado;

        
        Console.WriteLine("--------Soma--------------");
        resultado = valor1 + valor2;
        Console.WriteLine("valor1 + valor2 = " + resultado);
        resultado = valor1 + valor3;
        Console.WriteLine("valor1 + valor3 = " + resultado);
        resultado = valor1 + valor4;
        Console.WriteLine("valor1 + valor4 = " + resultado);
        resultado = valor2 + valor3;
        Console.WriteLine("valor2 + valor3 = " + resultado);
        resultado = valor2 + valor4;
        Console.WriteLine("valor2 + valor4 = " + resultado);
        resultado = valor3 + valor4;
        Console.WriteLine("valor3 + valor4 = " + resultado);
        Console.WriteLine("--------------------------");


        Console.WriteLine("--------MUtiplicação-----------");
        resultado = valor1 * valor2;
        Console.WriteLine("valor1 * valor2 = " + resultado);
        resultado = valor1 * valor3;
        Console.WriteLine("valor1 * valor3 = " + resultado);
        resultado = valor1 * valor4;
        Console.WriteLine("valor1 * valor4 = " + resultado);
        resultado = valor2 * valor3;
        Console.WriteLine("valor2 * valor3 = " + resultado);
        resultado = valor2 * valor4;
        Console.WriteLine("valor2 * valor4 = " + resultado);
        resultado = valor3 * valor4;
        Console.WriteLine("valor3 * valor4 = " + resultado);
        Console.WriteLine("-------------------------------");
    }
}


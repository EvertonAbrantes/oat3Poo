using System;

class Program
{
    static void Main(string[] args)
    {
        //Exercício 05
        Console.WriteLine("Digite o tempo gasto na viagem (em horas):");
        double tempo = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a velocidade média (em km/h):");
        double velocidadeMedia = double.Parse(Console.ReadLine());

        // Distância percorrida
        double distancia = tempo * velocidadeMedia;

        // Litros usados
        double litrosUsados = distancia / 12;

        Console.WriteLine("-----------------------------------------------");

        Console.WriteLine("Velocidade média: " + velocidadeMedia + " km/h");
        Console.WriteLine("Tempo gasto: " + tempo + " horas");
        Console.WriteLine("Distância percorrida: " + distancia + " km");
        Console.WriteLine("Quantidade de litros utilizada: " + litrosUsados + " litros");

        Console.WriteLine("-----------------------------------------------");
    }
}


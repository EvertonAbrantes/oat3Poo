using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite a quantidade de voltas:");
        int N = Convert.ToInt32(Console.ReadLine()); 

        double[] tempos = new double[N]; 

        
        Console.WriteLine("Digite os tempos das voltas:");

        for (int i = 0; i < N; i++)
        {
            tempos[i] = Convert.ToDouble(Console.ReadLine());
        }

        
        double melhorTempo = tempos[0];
        int voltaMelhorTempo = 1;

        for (int i = 1; i < N; i++)
        {
            if (tempos[i] < melhorTempo)
            {
                melhorTempo = tempos[i];
                voltaMelhorTempo = i + 1;
            }
        }

        
        double somaTempos = 0;

        for (int i = 0; i < N; i++)
        {
            somaTempos += tempos[i];
        }

        double tempoMedio = somaTempos / N;

        
        Console.WriteLine("Melhor tempo: " + melhorTempo);
        Console.WriteLine("Volta em que o melhor tempo ocorreu: " + voltaMelhorTempo);
        Console.WriteLine("Tempo médio das voltas: " + tempoMedio);
    }
}
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite a quantidade de alunos:");
        int N = Convert.ToInt32(Console.ReadLine()); 

        double somaNotas = 0;
        int contadorAlunosAcima7 = 0;

        for (int i = 1; i <= N; i++)
        {
            Console.WriteLine("Digite a nota do aluno " + i + ":");
            double nota = Convert.ToDouble(Console.ReadLine()); 

            somaNotas += nota;

            if (nota > 7.0)
            {
                contadorAlunosAcima7++;
            }
        }

        double media = somaNotas / N;

        Console.WriteLine("Média aritmética das notas: " + media);

        if (contadorAlunosAcima7 > 0)
        {
            Console.WriteLine("Quantidade de alunos com nota acima de 7.0: " + contadorAlunosAcima7);
        }
        else
        {
            Console.WriteLine("Não há nenhum aluno com nota acima de 7.0");
        }
    }
}
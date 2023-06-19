

class Program
{
    static void Main(string[] args)
    {
        double[] nota = new double[4];

        for (int i = 0; i < 4; i++)
        {
            Console.Write("Digite a {0}ª nota do aluno: ", i + 1);
            nota[i] = double.Parse(Console.ReadLine());
        }

        double soma = 0;
        for (int i = 0; i < 4; i++)
        {
            soma += nota[i];
        }

        double média = soma / 4;

        if (média >= 7)
        {
            Console.WriteLine("Aluno Aprovado");
        }
        else
        {
            Console.WriteLine("Insira a nota da recuperação:");
            double notaRecuperação = double.Parse(Console.ReadLine());

            if (notaRecuperação > 0 && (média + notaRecuperação) / 2 >= 7)
            {
                Console.WriteLine("Aluno Aprovado na recuperação");
            }
            else
            {
                Console.WriteLine("Aluno Reprovado");
            }
        }

        Console.WriteLine("A média do aluno é: " + média);
    }
}


using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int numeroSorteado = random.Next(101);
        int tentativas = 0;

        Console.WriteLine("Tente adivinhar o número sorteado (0 a 100):");

        while (true)
        {
            int tentativa = Convert.ToInt32(Console.ReadLine());
            tentativas++;

            if (tentativa == numeroSorteado)
            {
                Console.WriteLine("Parabéns! Você acertou o número sorteado em " + tentativas + " tentativas.");
                break;
            }
            else if (tentativa < numeroSorteado)
            {
                Console.WriteLine("O número sorteado é maior que " + tentativa + ".");
            }
            else
            {
                Console.WriteLine("O número sorteado é menor que " + tentativa + ".");
            }
        }
    }
}
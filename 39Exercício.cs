class Program
{
    static void Main(string[] args)
    {
        bool fechar = false;

        while (!fechar)
        {
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("O número é par.");
            }
            else
            {
                Console.WriteLine("O número é ímpar.");
            }
            if (numero > 0)
            {
                Console.WriteLine("O número é positivo.");
            }
            else if (numero < 0)
            {
                Console.WriteLine("O número é negativo.");
            }
            else
            {
                Console.WriteLine("O número é zero.");
            }

            Console.Write("Deseja encerrar o programa? (S/N): ");
            string resposta = Console.ReadLine();

            if (resposta == "S")
            {
                fechar = true;
            }

            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        string resposta;

        do
        {
            Console.WriteLine("Digite o código do funcionário: ");
            int codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número de horas trabalhadas:");
            int horas = int.Parse(Console.ReadLine());

            if (horas <= 50)
            {
                Console.WriteLine("O trabalhador irá receber: " + horas * 10);
            }
            else
            {
                Console.WriteLine("O trabalhador irá receber: " + (horas * 20 - 500));
            }

            Console.WriteLine("Deseja encerrar o programa? (S/N)");
            resposta = Console.ReadLine();
        } while (resposta.ToUpper() != "S");
    }
}


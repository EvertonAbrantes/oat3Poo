class Program
{
    static void Main(string[] args)
    {
        string resposta;

        do
        {
            Console.WriteLine("Digite o grupo da indústria: (1|2|3)");
            int grupo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o índice de poluição:");
            double poluicao = double.Parse(Console.ReadLine());

            if (poluicao <= 0.25)
            {
                Console.WriteLine("Poluição está aceitável");
            }
            else if (poluicao <= 0.3)
            {
                if (grupo == 1)
                {
                    Console.WriteLine("O grupo 1 deve suspender sua atividade");
                }
                else
                {
                    Console.WriteLine("Poluição está aceitável");
                }
            }
            else if (poluicao <= 0.4)
            {
                if (grupo == 1 || grupo == 2)
                {
                    Console.WriteLine("Os grupos 1 e 2 devem suspender sua atividade");
                }
                else
                {
                    Console.WriteLine("Poluição está aceitável");
                }
            }
            else if (poluicao <= 0.5)
            {
                Console.WriteLine("Todos os grupos devem suspender sua atividade");
            }
            else
            {
                Console.WriteLine("Poluição está acima dos níveis permitidos");
            }

            Console.WriteLine("Deseja encerrar o programa? (S/N)");
            resposta = Console.ReadLine().ToLower();
        } while (resposta != "s");
    }
}
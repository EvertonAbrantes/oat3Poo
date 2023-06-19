class Program
{
    static void Main()
    {
        int opção = 0;
        while (opção < 5)
        
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("0 - Sair");

            int opcao;
            bool opcaoValida = int.TryParse(Console.ReadLine(), out opcao);

            if (!opcaoValida)
            {
                Console.WriteLine("Opção inválida. Digite um número válido.");
                continue;
            }

            if (opcao == 0)
            {
                Console.WriteLine("Saindo do programa...");
                break;
            }

            double numero1, numero2, resultado;
            Console.WriteLine("Digite o primeiro número:");
            bool numero1Valido = double.TryParse(Console.ReadLine(), out numero1);

            Console.WriteLine("Digite o segundo número:");
            bool numero2Valido = double.TryParse(Console.ReadLine(), out numero2);

            if (!numero1Valido || !numero2Valido)
            {
                Console.WriteLine("Números inválidos. Digite números válidos.");
                continue;
            }

            switch (opcao)
            {
                case 1:
                    resultado = numero1 + numero2;
                    Console.WriteLine("Resultado: {resultado}");
                    break;
                case 2:
                    resultado = numero1 - numero2;
                    Console.WriteLine("Resultado: {resultado}");
                    break;
                case 3:
                    resultado = numero1 * numero2;
                    Console.WriteLine("Resultado: {resultado}");
                    break;
                case 4:
                    if (numero2 == 0)
                    {
                        Console.WriteLine("ERRO.");
                        continue;
                    }

                    resultado = numero1 / numero2;
                    Console.WriteLine("Resultado: {resultado}");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Selecione uma opção válida.");
                    break;
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        bool sair = false;

        do
        {
            Console.WriteLine("Menu de opções:");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");

            Console.Write("Informe a opção: ");
            int opcao = int.Parse(Console.ReadLine());


            {
                Console.Write("Digite o primeiro número: ");
                double num1 = double.Parse(Console.ReadLine());

                Console.Write("Digite o segundo número: ");
                double num2 = double.Parse(Console.ReadLine());

                double resultado = 0;

                switch (opcao)
                {
                    case 1:
                        resultado = num1 + num2;
                        Console.WriteLine($"Resultado da adição: {resultado}");
                        break;
                    case 2:
                        resultado = num1 - num2;
                        Console.WriteLine($"Resultado da subtração: {resultado}");
                        break;
                    case 3:
                        resultado = num1 * num2;
                        Console.WriteLine($"Resultado da multiplicação: {resultado}");
                        break;
                    case 4:
                        if (num2 != 0)
                        {
                            resultado = num1 / num2;
                            Console.WriteLine($"Resultado da divisão: {resultado}");
                        }
                        else
                        {
                            Console.WriteLine("Não é possível dividir por zero!");
                        }
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

                Console.Write("Deseja voltar ao menu principal? (S/N): ");
                string resposta = Console.ReadLine();

                if (resposta != "S")
                {
                    sair = true;
                }

                Console.WriteLine();
            }
        } while (!sair);
    }
}

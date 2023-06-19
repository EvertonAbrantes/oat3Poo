class Program
{
    static void Main(string[] args)
    {
        string resposta;

        do
        {
            Console.WriteLine("Menu de opções");
            Console.WriteLine("1-- Conversão de Graus Celsius em Graus Fahrenheit");
            Console.WriteLine("2-- Conversão de Graus Fahrenheit em Graus Celsius");
            Console.WriteLine("3-- Peso ideal do homem");
            Console.WriteLine("4-- Peso ideal da mulher");

            Console.WriteLine("Escolha uma das opções acima");
            int opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                Console.WriteLine("Digite os Graus celsius");
                int celsius = int.Parse(Console.ReadLine());
                Console.WriteLine("Os graus Fahrenheit é: " + (9 * celsius + 160) / 5);
            }
            else if (opcao == 2)
            {
                Console.WriteLine("Digite os graus Fahrenheit");
                int fahrenheit = int.Parse(Console.ReadLine());
                Console.WriteLine("Os graus Celsius é: " + (fahrenheit - 32) * 5 / 9);
            }
            else if (opcao == 3)
            {
                Console.WriteLine("Digite a sua altura");
                double altura = double.Parse(Console.ReadLine());
                Console.WriteLine("O seu peso ideal é: " + ((72.7 * altura) - 58));
            }
            else if (opcao == 4)
            {
                Console.WriteLine("Digite a sua altura");
                double alturafeminina = double.Parse(Console.ReadLine());
                Console.WriteLine("O seu peso ideal é: " +((62.1 * alturafeminina) - 44.7));
            }
            else
            {
                Console.WriteLine("Opçao invalida");
            }

            Console.WriteLine("Deseja encerrar o pragrama? (S/N)");
            resposta = Console.ReadLine();

        }while(resposta != "s");
    }
}
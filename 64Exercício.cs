using System;

class Program
{
    static int[] vetor;
    static int tamanho;

    static void Main()
    {
        bool sair = false;

        while (!sair)
        {
            Console.WriteLine("Opções:");
            Console.WriteLine("1 - Carregar Vetor");
            Console.WriteLine("2 - Listar Vetor");
            Console.WriteLine("3 - Exibir apenas os números pares do vetor");
            Console.WriteLine("4 - Exibir apenas os números ímpares do vetor");
            Console.WriteLine("5 - Exibir a quantidade de números pares nas posições ímpares do vetor");
            Console.WriteLine("6 - Exibir a quantidade de números ímpares nas posições pares do vetor");
            Console.WriteLine("7 - Sair");
            Console.WriteLine("Digite a opção desejada:");

            int opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    CarregarVetor();
                    break;
                case 2:
                    ListarVetor();
                    break;
                case 3:
                    ExibirPares();
                    break;
                case 4:
                    ExibirImpares();
                    break;
                case 5:
                    QuantidadeParesPosicoesImpares();
                    break;
                case 6:
                    QuantidadeImparesPosicoesPares();
                    break;
                case 7:
                    sair = true;
                    break;
                default:
                    Console.WriteLine("Opção inválida. Digite novamente.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void CarregarVetor()
    {
        Console.WriteLine("Digite o tamanho do vetor:");
        tamanho = Convert.ToInt32(Console.ReadLine());

        vetor = new int[tamanho];

        for (int i = 0; i < tamanho; i++)
        {
            Console.WriteLine("Digite o valor para a posição " + i + ":");
            vetor[i] = Convert.ToInt32(Console.ReadLine());
        }
    }

    static void ListarVetor()
    {
        Console.WriteLine("Vetor:");

        for (int i = 0; i < tamanho; i++)
        {
            Console.Write(vetor[i] + " ");
        }

        Console.WriteLine();
    }

    static void ExibirPares()
    {
        Console.WriteLine("Números pares:");

        for (int i = 0; i < tamanho; i++)
        {
            if (vetor[i] % 2 == 0)
            {
                Console.Write(vetor[i] + " ");
            }
        }

        Console.WriteLine();
    }

    static void ExibirImpares()
    {
        Console.WriteLine("Números ímpares:");

        for (int i = 0; i < tamanho; i++)
        {
            if (vetor[i] % 2 != 0)
            {
                Console.Write(vetor[i] + " ");
            }
        }

        Console.WriteLine();
    }

    static void QuantidadeParesPosicoesImpares()
    {
        int count = 0;

        for (int i = 1; i < tamanho; i += 2)
        {
            if (vetor[i] % 2 == 0)
            {
                count++;
            }
        }

        Console.WriteLine("Quantidade de números pares nas posições ímpares: " + count);
    }

    static void Quantidade
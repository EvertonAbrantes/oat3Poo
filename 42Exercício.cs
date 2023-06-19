class Program
{
    static void Main(String[] args)
    {
        int numero;
        int maior = int.MinValue;
        int menor = int.MaxValue;

        do
        {
            Console.Write("Digite um número (0 para sair): ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero != 0)
            {
                if (numero > maior)
                    maior = numero;

                if (numero < menor)
                    menor = numero;
            }
        } while (numero != 0);

        Console.WriteLine("O maior número digitado foi: " + maior);
        Console.WriteLine("O menor número digitado foi: " + menor);
    }
}
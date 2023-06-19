class Program
{
    static void Main(string[] args)
    {
        int numero, fatorial, cont;
        numero = 0;
        fatorial = 1;

        Console.WriteLine("Digite o número para o cálculo fatorial");
        numero = int.Parse(Console.ReadLine());

        if(numero < 0)
        {
            Console.WriteLine("Erro, número invaladido. Apenas números >= 0");
        }
        else if((numero == 0 ) || (numero == 1))
        {
            Console.WriteLine("O fatorial de {0} é 1.",numero);
        }
        else
        {
            for(cont = numero; cont >= 1; cont--)
            {
                fatorial *= cont;
            }
            Console.WriteLine("O fatorial de {0} é {1}", numero,fatorial);
        }
        Console.ReadLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a idade do nadador");
        int idade = int.Parse(int.Parse());
        
        if (idade < 0)
        {
            Console.WriteLine("Erro, idade não pode ser < 0");
        }
        else if(idade <= 7)
        {
            Console.WriteLine("Infatil A");
        }
        else if (idade > 7 || idade <=11 )
        {
            Console.WriteLine("Infantil B");
        }
        else if (idade > 11 || idade <= 13)
        {
            Console.WriteLine("Juvenil A");
        }
        else if ( idade > 13|| idade <= 17)
        {
            Console.WriteLine("Juvenil B");
        }
        else
        {
            Console.WriteLine("Adultos Maiores de 18");
        }
    }
}
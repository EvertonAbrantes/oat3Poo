class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite sua altura em metros: ");
        double altura = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite seu sexo (homem ou mulher): ");
        string sexo = Console.ReadLine();

        double pesoIdeal;

        if (sexo == "homem")
        {
            pesoIdeal = (72.7 * altura) - 58;
        }
        else
        {
            pesoIdeal = (62.1 * altura) - 44.7;
        }

        Console.WriteLine("Seu peso ideal é: " + pesoIdeal + " kg.");
    }
}

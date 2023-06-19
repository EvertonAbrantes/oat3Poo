class Program
{
    static void Main(string[] args)
    {
        //Exercício 07
        Console.WriteLine("Digite a temperatura em graus fahrenheint");
        int temperaturaFahrenheint = int.Parse(Console.ReadLine());

        int temperaturaCelsius = (temperaturaFahrenheint - 32) * 5 / 9;

        Console.WriteLine("A temperatura e celsius:" + temperaturaFahrenheint );
    }
}

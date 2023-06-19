class Program
{
    static void Main(string[] args)
    {
    
        Console.WriteLine("Digite a temperatura em graus Fahrenheit");
        int fahrenheit = int.Parse(Console.ReadLine());

        int Celsius = (fahrenheit -32)* 5 /9;

        Console.WriteLine("A temperatura fahrenheint e:" +Celsius );
    }
}
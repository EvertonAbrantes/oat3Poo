class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a altura do triângulo");
        double altura = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a base do triângulo");
        double base1 = double.Parse(Console.ReadLine());

        double hipotenusa = (base1 + altura);

        Console.WriteLine("O valor da hipotenusa do triângulo é:" +  hipotenusa);
    }
}

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Digite o número de matrícula do aluno: ");
        int matricula = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a sua nota: ");
        int nota = int.Parse(Console.ReadLine());

        Console.WriteLine($"Número da matricula é :"  +matricula);
        Console.WriteLine("a nota do aluno é :"  +nota);


    }
}

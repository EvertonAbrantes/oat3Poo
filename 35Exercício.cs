using System;

class Program
{
    static void Main(string[] args)
    {
        for (int número = 1; número <= 100; número++)
        {
            Console.WriteLine(número);

            if (número % 10 == 0)
            {
                Console.WriteLine("Múltiplo de 10");
            }
        }

        Console.ReadLine();
    }
}

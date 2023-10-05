using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um numero: ");
        double n = Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite outro numero: ");
        double n2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Soma é igual a:  {n + n2} ");

        Console.ReadKey();
    }
}
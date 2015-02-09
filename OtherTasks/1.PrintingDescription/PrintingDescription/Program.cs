using System;

class Program
{
    static void Main()
    {
        long N = long.Parse(Console.ReadLine());
        long S = long.Parse(Console.ReadLine());
        decimal P = Decimal.Parse(Console.ReadLine());


        decimal price = N * S;
        decimal result = price / 500;
        decimal resultOne = result * P;

        Console.WriteLine("{0:F2}", resultOne);

    }
}
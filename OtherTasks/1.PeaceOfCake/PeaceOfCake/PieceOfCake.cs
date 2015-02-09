using System;
class PieceOfCake
{
    static void Main(string[] args)
    {
        long a = long.Parse(Console.ReadLine());
        long b = long.Parse(Console.ReadLine());
        long c = long.Parse(Console.ReadLine());
        long d = long.Parse(Console.ReadLine());

        long resultNominator = a * d + b * c;
        long resultDenominator = b * d;

        decimal decimalResult = ((decimal)resultNominator / resultDenominator);

        if (decimalResult>=1)
        {
            Console.WriteLine((long)decimalResult);
        }
        else
        {
            Console.WriteLine("{0:F22}",decimalResult);
        }
        Console.WriteLine(resultNominator + "/" + resultDenominator);
    }
}


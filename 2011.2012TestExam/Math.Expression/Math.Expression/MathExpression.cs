using System;
using System.Threading;
using System.Globalization;
class MathExpression
{
    static void Main(string[] args)
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        decimal n = decimal.Parse(Console.ReadLine());
        decimal m = decimal.Parse(Console.ReadLine());
        decimal p = decimal.Parse(Console.ReadLine());

        decimal nominator = n * n + (1 / (m * p)) + 1337;
        decimal deNominator = n - (128.523123123m * p);
        int sinValue = (int)m % 180;
        decimal sin = (decimal)Math.Sin(sinValue);

        decimal result = nominator / deNominator + sin;
        Console.WriteLine("{0:F6}",result);
    }
}


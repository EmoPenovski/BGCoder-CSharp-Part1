using System;

class Program
{
    static void Main()
    {
        int n = Int32.Parse(Console.ReadLine());

        Console.Write(new string(' ', (2 * n - 1) - n));
        Console.WriteLine(new string(':', (2 * n - 1) - n + 1));

        Console.Write(new string(' ', (2 * n - 1) - n - 1));
        Console.Write(':');
        Console.Write(new string('/', n - 2));
        Console.WriteLine(new string(':', 2));

        for (int i = 2, m = n - 1; i < n - 1; i++, m--)
        {
            Console.Write(new string(' ', (2 * n - 1) - n - i));
            Console.Write(':');
            Console.Write(new string('/', n - 2));
            Console.Write(':');
            Console.Write(new string('X', n - m));
            Console.Write(':');
            Console.WriteLine();
        }

        Console.Write(new string(':', n));
        Console.Write(new string('X', n - 2));
        Console.WriteLine(new string(':', 1));

        for (int i = n - 1, j = 3; j < n; i--, j++)
        {
            Console.Write(':');
            Console.Write(new string(' ', n - 2));
            Console.Write(':');
            Console.Write(new string('X', n - j));
            Console.Write(':');
            Console.WriteLine();
        }

        Console.Write(':');
        Console.Write(new string(' ', n - 2));
        Console.WriteLine(":" + ":");
        Console.WriteLine(new string(':', n));

    }
}
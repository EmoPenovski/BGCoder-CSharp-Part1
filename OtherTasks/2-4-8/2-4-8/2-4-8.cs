﻿using System;
class Program
{
    static void Main(string[] args)
    {
        long a = long.Parse(Console.ReadLine());
        long b = long.Parse(Console.ReadLine());
        long c = long.Parse(Console.ReadLine());
        long r = 0;
        if (b==2)
        {
            r = a % c;
        }
        else if (b==4)
        {
            r = a + c;
        }
        else if (b==8)
        {
            r = a * c;
        }
        if (r%4==0)
        {
            Console.WriteLine(r/4);
        }
        else
        {
            Console.WriteLine(r%4);
        }
        Console.WriteLine(r);
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandGlass
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int dots = 0;
            int stars = 0;
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(new string('.', i));
                Console.Write(new string('*', n - 2 * i));
                Console.WriteLine(new string('.',i));
            }
            Console.Write(new string('.', n / 2));
            Console.Write('*');
            Console.WriteLine(new string('.', n / 2));
            for (int i = n/2 - 1; i >= 0; i--)
            {
                Console.Write(new string('.', i));
                Console.Write(new string('*', n - 2 * i));
                Console.WriteLine(new string('.',i));
            }


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carpets
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = n;
            int height = n;
            int rowDots = 0;
            Console.Write(new string('.',n/2-1));
            Console.Write('/');
            Console.Write('\\');
            Console.WriteLine(new string('.', n / 2 - 1));

            for (int row = 2; row <= n/2; row++)
            {
                rowDots--;
                Console.Write(new string('.', n / 2 + rowDots-1));
                Console.Write(new string('/', 2 * row / 4));
                Console.WriteLine();
                //Console.Write('\\');
                //Console.WriteLine(new string('.', n/2 - row));



            }



        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Tribonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger n1 = int.Parse(Console.ReadLine());
            BigInteger n2 = int.Parse(Console.ReadLine());
            BigInteger n3 = int.Parse(Console.ReadLine());
            BigInteger N = int.Parse(Console.ReadLine());
            BigInteger sum = 0;
            for (int i = 4; i <= N; i++)
            {
                sum = n1 + n2 + n3;
                n1 = n2;
                n2 = n3;
                n3 = sum;
            }

            Console.WriteLine(n3);

        }
    }
}

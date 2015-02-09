using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Secrets
{
    class Program
    {
        static void Main()
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            int specialSum = 0;
            BigInteger number = n;
            if (number<0)
            {
                number *= -1;
            }
            int position = 1;
            while (number>0)
            {
                int digit = (int)(number % 10);
                number /= 10;
                if (position%2==0)
                {
                    specialSum += digit * digit * position;
                }
                else
                {
                    specialSum += digit * position * position;
                }
                ++position;
            }
            Console.WriteLine(specialSum);
            int sequenceLength = specialSum % 10;
            if (sequenceLength ==0)
            {
                Console.WriteLine("{0} has no secret alpha-sequence",n);
            }
            else
            {
                int start = specialSum % 26;
                for (int i = 0; i < sequenceLength; i++)
                {
                    Console.Write((char)('A' +(start+i) %26) ); // (char)('Z'-'A')
                }
                Console.WriteLine();

            }
        }
    }
}

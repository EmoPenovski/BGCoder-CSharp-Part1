using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngryFemalGPS
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            int summOdd = 0;
            int summEven = 0;

            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] == '-')
                {
                    continue;
                }
                int digit = number[i] - '0';
                if (digit%2==0)
                {
                    summEven += digit;
                }
                else
                {
                    summOdd += digit;
                }
            }
            if (summEven>summOdd)
            {
                Console.WriteLine("right {0}",summEven);
            }
            else if (summEven<summOdd)
            {
                Console.WriteLine("left {0}",summOdd);
            }
            else
            {
                Console.WriteLine("straight {0}",summOdd);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrunkenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long m = 0;
            long v = 0;
            for (int i = 0; i < n; i++)
            {
                long roundInfo = long.Parse(Console.ReadLine());
                if (roundInfo < 0)
                {
                    roundInfo = -roundInfo;
                }
                //1234567
                // long roundInfo = long.Parse(Console.ReadLine());
                // int digits = roundInfo.Length;
                int digits = 0;
                long tempRoundInfo = roundInfo;
                while (tempRoundInfo>0)
                { 
                    tempRoundInfo /=10;
                    digits++;
                }
                if (digits % 2 == 0)
                {
                    //m -> first half
                    for (int j = 0; j < digits/2; j++)
                    {
                        v += (roundInfo % 10);
                        roundInfo /= 10;
                    }
                    //v -> first half
                    for (int j = 0; j < digits / 2; j++)
                    {
                        m += (roundInfo % 10);
                        roundInfo /= 10;
                    }
                    //v -> first half
                }
                else
                {
                    for (int j = 0; j < digits / 2; j++)
                    {
                        v += (roundInfo % 10);
                        roundInfo /= 10;
                    }
                    long middleNumber = roundInfo % 10;
                    v += middleNumber;
                    m += middleNumber;
                    roundInfo /= 10;
                    for (int j = 0; j < digits / 2; j++)
                    {
                        m += (roundInfo % 10);
                        roundInfo /= 10;
                    }
                    // 5-> 3,3
                    //m -> first half number+middle number
                    //v -> second half number + middle number
                }
            }
            if (m>v)
            {
                Console.WriteLine("M {0}", m-v);
            }
            else if (v>m)
            {
                Console.WriteLine("V {0}", v-m);
            }
            else //m==v
            {
                Console.WriteLine("No {0}", m+v);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffieMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int N1 = int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());
            int N3 = int.Parse(Console.ReadLine());
            int N4 = int.Parse(Console.ReadLine());
            int N5 = int.Parse(Console.ReadLine());

            double A = double.Parse(Console.ReadLine());
            double P = double.Parse(Console.ReadLine());

            double inMachine = (N1 * 0.05 + N2 * 0.10 + N3 * 0.20 + N4 * 0.50 + N5 * 1.00);
            //logic
            if (A >= P)
            {
                double change = A - P;
                if (change<=inMachine)
                {
                    Console.WriteLine("Yes {0:F2}", inMachine-change);
                }
                else
                {
                    Console.WriteLine("No {0:F2}",change-inMachine);
                }
            }
            else
            {
                Console.WriteLine("More {0:F2}", P-A);
            }


            //output
        }
    }
}

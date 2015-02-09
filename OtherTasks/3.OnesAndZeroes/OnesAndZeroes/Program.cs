using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnesAndZeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            //// read input
            //int number = int.Parse(Console.ReadLine());
            //string bin = Convert.ToString(number, 2).PadLeft(32, '0');
            
            ////logic
            //string oneRow0 = ".#.";
            //string oneRow1 = "##.";
            //string oneRow2 = ".#.";
            //string oneRow3 = ".#.";
            //string oneRow4 = "###";
            
            //string zeroRow0 = "###";
            //string zeroRow1 = "#.#";
            //string zeroRow2 = "#.#";
            //string zeroRow3 = "#.#";
            //string zeroRow4 = "###";
            ////row 0
            //for (int i = 16; i < bin.Length; i++)
            //{
            //    if (bin[i]=='1')
            //    {
            //        Console.Write(oneRow0);
            //    }
            //    else
            //    {
            //        Console.Write(zeroRow0);
            //    }
            //    if (i!= bin.Length-1)
            //    {
            //    Console.Write('.');
            //    }
            //}
            //Console.WriteLine();
            ////row1
            //for (int i = 16; i < bin.Length; i++)
            //{
            //    if (bin[i] == '1')
            //    {
            //        Console.Write(oneRow1);
            //    }
            //    else
            //    {
            //        Console.Write(zeroRow1);
            //    }
            //    if (i != bin.Length - 1)
            //    {
            //        Console.Write('.');
            //    }
            //}
            //Console.WriteLine(); 
            ////row2
            //for (int i = 16; i < bin.Length; i++)
            //{
            //    if (bin[i] == '1')
            //    {
            //        Console.Write(oneRow2);
            //    }
            //    else
            //    {
            //        Console.Write(zeroRow2);
            //    }
            //    if (i != bin.Length - 1)
            //    {
            //        Console.Write('.');
            //    }
            //}
            //Console.WriteLine();
            ////row3
            //for (int i = 16; i < bin.Length; i++)
            //{
            //    if (bin[i] == '1')
            //    {
            //        Console.Write(oneRow3);
            //    }
            //    else
            //    {
            //        Console.Write(zeroRow3);
            //    }
            //    if (i != bin.Length - 1)
            //    {
            //        Console.Write('.');
            //    }
            //}
            //Console.WriteLine();
            ////row4
            //for (int i = 16; i < bin.Length; i++)
            //{
            //    if (bin[i] == '1')
            //    {
            //        Console.Write(oneRow4);
            //    }
            //    else
            //    {
            //        Console.Write(zeroRow4);
            //    }
            //    if (i != bin.Length - 1)
            //    {
            //        Console.Write('.');
            //    }
            //}
            //Console.WriteLine();

            //With arrays:
            int number = int.Parse(Console.ReadLine());
            string bin = Convert.ToString(number, 2).PadLeft(32, '0');
            string[] one = {".#.",
                             "##.",
                             ".#.",
                             ".#.",
                             "###" };

            string[] zero ={"###",
                            "#.#",
                            "#.#",
                            "#.#",
                            "###" };
            for (int row = 0; row < 5; row++)
            {
                for (int i = 16; i < bin.Length; i++)
                {
                    if (bin[i]=='1')
                    {
                        Console.Write(one[row]);
                    }
                    else
                    {
                        Console.Write(zero[row]);
                    }
                    if (i!=bin.Length-1)
                    {
                        Console.Write('.');
                    }
                }
                Console.WriteLine();
            }


        }
    }
}

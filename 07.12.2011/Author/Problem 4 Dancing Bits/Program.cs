using System;

namespace Problem_4_Dancing_Bits
{
    class Program
    {
        static void Main()
        {
           //int k = int.Parse(Console.ReadLine());
           //int n = int.Parse(Console.ReadLine());
           //int len = 0;
           //int lastBit = -1;
           //int dancingBitsCount = 0;
           //for (int i = 0; i < n; i++)
           //{
           //    int num = int.Parse(Console.ReadLine());
           //
           //    // Skip the leading zeroes in num
           //    int firstNonZeroBit = 0;
           //    for (int bitNum = 31; bitNum >= 0; bitNum--)
           //    {
           //        int currentBit = (num >> bitNum) & 1;
           //        if (currentBit == 1)
           //        {
           //            firstNonZeroBit = bitNum;
           //            break;
           //        }
           //    }
           //
           //    // Process the digits of num (without the leading zeroes)
           //    for (int bitNum = firstNonZeroBit; bitNum >= 0; bitNum--)
           //    {
           //        int currentBit = (num >> bitNum) & 1;
           //        if (currentBit == lastBit)
           //        {
           //            // The current bits continues the last sequence
           //            len++;
           //        }
           //        else
           //        {
           //            // The sequence is changed --> start a new sequence
           //            if (len == k)
           //            {
           //                dancingBitsCount++;
           //            }
           //            len = 1;
           //        }
           //        lastBit = currentBit;
           //    }
           //}
           //
           //// Check the last sequence
           //if (len == k)
           //{
           //    dancingBitsCount++;
           //}
           //
           //Console.WriteLine(dancingBitsCount);
            int k = int.Parse(Console.ReadLine());

            int n = int.Parse(Console.ReadLine());
            string result = "";

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                result += Convert.ToString(number, 2);
            }
            char previousChar = result[0];

            int count = 1;
            int endResult = 0;

            for (int i = 1; i < result.Length; i++)
            {
                if (result[i]==previousChar)
                {
                    count++;
                }
                else
                {
                    if (count == k)
                    {
                        endResult++;
                    }
                    
                    count = 1;
                    previousChar = result[i];
                }
            }
            if (count == k)
            {
                endResult++;
            }
            Console.WriteLine(endResult);
        }
    }
}

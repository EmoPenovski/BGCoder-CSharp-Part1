using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirTree
{
    class Program
    {
        static void Main(string[] args)
        {
            string firtree = @".......*.......  n-2*'.' + '*' + n-2*'.'
                               ......***......  n-3*'.'+ 3*'.' + n-3*'.'
                               .....*****.....
                               ....*******....
                               ...*********...
                               ..***********..
                               .*************.
                               ***************
                               .......*.......
                               ";
            int n = int.Parse(Console.ReadLine());
            int width = 2*n-3;
            int height = n;

            int topDots = n - 2;
            Console.Write(new string('.', topDots));
            Console.Write('*');
            Console.WriteLine(new string('.', topDots));

            int topRows = topDots;
            int stars = 1;
            for (int i = 0; i <= topRows - 1; i++)
            {
                topDots--;
                stars += 2;
                Console.Write(new string('.', topDots));
                Console.Write(new string('*',stars));
                Console.WriteLine(new string('.', topDots));

            }
            topDots = n - 2;

            
            Console.Write(new string('.', topDots));
            Console.Write('*');
            Console.WriteLine(new string('.', topDots));









        }
    }
}

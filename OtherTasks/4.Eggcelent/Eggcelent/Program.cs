using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eggcelent
{
    class Program
    {
        static void Main(string[] args)
        {
            string eggcelent = @"     n=4
                                 .....***.....   width = 3*n-1                     |    (n+1)*'.' + (n-1)*'*'+(n+1)*'.'
                                 ...*.....*...   width area = 3*n+1                |    (n-1)*'.' + '*' + (n+1)*'.' + '*' + (n-1)*'.'
                                 .*.........*.   height = 2*n                      |    (n-3)*'.' + '*' + (n+5)*'.' + '*' + (n-3)*'.'
                                 .*@.@.@.@.@*.   top and bottom = n-1              |    '.' + '*' + '@' + '.' + '@' + '.' + '@' + '.' + '@' + '.' +'@' + '*' + '.'   
                                 .*.@.@.@.@.*.   firstMiddleLine starts with '@'   |    '.' + '*' + '.' + '@' + '.' + '@' + '.' + '@' + '.' + '@' +'.' + '*' + '.'
                                 .*.........*.   secondMiddleLine starts with '.'  |    (n-3)*'.' + '*' + (n+5)*'.' + '*' + (n-3)*'.'
                                 ...*.....*...   shell is '*'                      |    (n-1)*'.' + '*' + (n+1)*'.' + '*' + (n-1)*'.'
                                 .....***.....                                     |    (n+1)*'.' + (n-1)*'*'+(n+1)*'.'
                                 ";
            int n = int.Parse(Console.ReadLine());
            int height = 2 * n;
            int width = 3 * n + 1;
            for (int r = 0; r < height; r++)
            {
                for (int c = 0; c < width; c++)
                {
                    if (c > n && c < 2 * n && (r == 0 || r == height - 1))
                    {
                        Console.Write('*');
                    }
                    else if ((r >= n / 2 && r < 2 * n - n / 2) &&
                            (c == 1 || c == width - 2))
                    {
                        Console.Write('*');
                    }
                    else if (2 * r - c == -(2 * n - 1) || 2 * r - c == 3*n-3)
                    {
                        Console.Write('*');
                    }
                    else if ((2*r+c== n+1) || 2*r+c == 6*n-3)
                    {
                        Console.Write('*');
                    }
                    else if ((r== n-1 || r==n) && (c >1 && c< width-1) && (r+c) %2 ==1)
                    {
                        Console.Write('@');
                    }      
                    else
                    {
                        Console.Write('.');
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

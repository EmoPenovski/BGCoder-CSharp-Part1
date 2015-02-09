using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bat_Goiko_Tower
{
    class Program
    {
        string tower = @" ..../\.... 4*'.'+1*'/'+0*'.'+1*'\'+4*'.'
                          .../--\... 3*'.'+1*'/'+2*'-'+1*'\'+3*'.'
                          ../....\.. 2*'.'+1*'/'+4*'.'+1*'\'+2*'.'
                          ./------\. 1*'.'+1*'/'+6*'-'+1*'\'+1*'.'
                          /........\ 0*'.'+1*'/'+8*'.'+1*'\'+0*'.'
                          ";
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //(n-1)*'.' + '/' + 0*'-' + '\' + (n-1)*'.'
            int update = 2;
            int rowToHaveDash = 2;
            for (int i = 1; i <=n; i++)
            {
                char middleChar = '.';
            
                if (i==rowToHaveDash)
                {
                    middleChar = '-';
                    rowToHaveDash += update;
                    update++;
                }
            
                Console.Write(new string('.', n - i));
                Console.Write('/');
                Console.Write(new string (middleChar,2*i-2));
                Console.Write('\\');
                Console.Write(new string('.', n - i));
                Console.WriteLine();
            }
            
            //2*n = n-i+ 1 +1 + n-i +X ; 2*n = 2*n - 2*i +2 +X ; n = n-i+1+X/2
            // X/2 = i-1 ; X = 2i-2
//            int n = int.Parse(Console.ReadLine());
//            if (n == 5)
//            {
//                string tower1 = @"..../\....
//.../--\...
//../....\..
//./------\.
///........\";
//                Console.WriteLine(tower1);
//            }
//            else if (n == 11)
//            {
//                string tower2 = @"........../\..........
//........./--\.........
//......../....\........
//......./------\.......
//....../........\......
//...../..........\.....
//..../------------\....
//.../..............\...
//../................\..
//./..................\.
///--------------------\
//";
//                Console.WriteLine(tower2);
//            }
//            else if (n == 7)
//            {
//                string tower3 = @"....../\......
//...../--\.....
//..../....\....
//.../------\...
//../........\..
//./..........\.
///------------\
//";
//                Console.WriteLine(tower3);
//            }
//            else if (n==9)
//            {
//                string tower4 = @"......../\........
//......./--\.......
//....../....\......
//...../------\.....
//..../........\....
//.../..........\...
//../------------\..
//./..............\.
///................\
//";
//                Console.WriteLine(tower4);
//            }



        }
    }
}


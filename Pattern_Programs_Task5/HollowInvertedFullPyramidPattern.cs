using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Programs_Task5
{
    public class HollowInvertedFullPyramidPattern
    {
        int n = 5;
        public void ShowHollowInvertedFullPyramidPattern()
        {
            /*       
                  j j j j j
                  1 2 3 4 5
             i 1  * * * * * * * * *
             i 2  _ *           * 
             i 3  _ _ *       *
             i 4  _ _ _ *   *
             i 5  _ _ _ _ *

             1 to i              i to n                i to n
             increasing spaces + decreasing stars(L) + decreasing stars(R

             L triangle : first row : i = 1, start side: j = i
             R triangle : first row : i = 1, end side: j = n

         */

            //HOLLOW REVERSE HILL PATTERN
            Console.WriteLine("Hollow Reverse Hill Pattern");
            for (int i = 1; i <= n; i++)
            {
                //spaces
                for (int sp = 1; sp <= i; sp++)
                {
                    Console.Write("  ");
                }
                //left triangle
                for (int j = i; j < n; j++) //changed in first inner loop <= to < here to make one column less printed
                {
                    if (i == 1 || j == i)
                        Console.Write("* ");
                    else
                        Console.Write("  ");

                }
                //right triangle
                for (int j = i; j <= n; j++)
                {
                    if (i == 1 || j == n)
                        Console.Write("* ");
                    else
                        Console.Write("  ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

    }
}

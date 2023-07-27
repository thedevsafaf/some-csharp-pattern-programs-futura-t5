using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Programs_Task5
{
    public class HollowFullPyramidPattern
    {
        int n = 5;
        public void ShowHollowFullPyramidPattern()
        {
            /*       
                   j j j j j
                   1 2 3 4 5
              i 1  _ _ _ _ *
              i 2  _ _ _ *   *
              i 3  _ _ *       *
              i 4  _ *           *
              i 5  * * * * * * * * *

              i to n              1 to i                1 to i
              decreasing spaces + increasing stars(L) + increasing stars(R)

              for hill pattern, 
              see (L) triangle part, last row : i = n and start side : j = 1
              see (R) triangle part, last row : i = n and end side :   j = i 

          */

            Console.WriteLine("Hollow Hill Pattern");
            DisplayPattern();
        }

        public void DisplayPattern()
        {
            for (int i = 1; i <= n; i++)
            {
                for (int sp = i; sp <= n; sp++)
                {
                    Console.Write("  ");
                }
                for (int j = 1; j < i; j++) //changed in first inner loop <= to < here to make one column less printed
                {
                    if (i == n || j == 1)
                        Console.Write("* ");
                    else
                        Console.Write("  ");
                }
                for (int j = 1; j <= i; j++)
                {
                    if (i == n || j == i)
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

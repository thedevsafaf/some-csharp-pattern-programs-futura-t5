using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Programs_Task5
{
    public class HollowDiamondPattern
    {
        int n = 5;
        public void ShowHollowDiamondPattern()
        {
            //HOLLOW DIAMOND

            /*       
                   j j j j j
                   1 2 3 4 5
              i 1  _ _ _ _ *
              i 2  _ _ _ *   *
              i 3  _ _ *       *
              i 4  _ *           *
              i 5  *               *
                   _ *           * 
                   _ _ *       *
                   _ _ _ *   *
                   _ _ _ _ *  

              i to n              1 to i                1 to i
              decreasing spaces + increasing stars(L) + increasing stars(R)
              1 to i              i to n                i to n
              increasing spaces + decreasing stars(L) + decreasing stars(R)

              consider 4 triangles (upper_left1, lower_left1, upper_right2, lower_right2)
              
              start side : upper_left1 (j = 1), lower_left1 (j = i)
              end side : upper_right2  (j = i), lower_right2 (j = n)

            */


            Console.WriteLine("Hollow Diamond Pattern");

            //hill
            for (int i = 1; i < n; i++) //changed <= to < to make one row less
            {
                for (int sp = i; sp <= n; sp++)
                {
                    Console.Write("  ");
                }
                for (int j = 1; j < i; j++) //changed in first inner loop <= to < here to make one column less printed
                {
                    if (j == 1)
                        Console.Write("* ");
                    else
                        Console.Write("  ");
                }
                for (int j = 1; j <= i; j++)
                {
                    if (j == i)
                        Console.Write("* ");
                    else
                        Console.Write("  ");
                }
                Console.WriteLine();
            }
            //reverse hill
            for (int i = 1; i <= n; i++)
            {
                for (int sp = 1; sp <= i; sp++)
                {
                    Console.Write("  ");
                }
                for (int j = i; j < n; j++) //changed in first inner loop <= to < here to make one column less printed
                {
                    if (j == i)
                        Console.Write("* ");
                    else
                        Console.Write("  ");
                }
                for (int j = i; j <= n; j++)
                {
                    if (j == n)
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Programs_Task5
{
    public class HollowHourGlassPattern
    {
        int n = 5;
        public void ShowHollowGlassPattern()
        {
            //HOLLOW HOURGLASS PATTERN
            /*       

                    j j j j j
                    1 2 3 4 5
                    * * * * * * * * *
              i 1   _ *           * 
              i 2   _ _ *       *
              i 3   _ _ _ *   *
              i 4   _ _ _ _ *  
              i 5   _ _ _ *   *
                    _ _ *       *
                    _ *           *
                    * * * * * * * * *
                    
               for reverse hill pattern,
                    (L) triangle => first row : i = 1, start side: j = i
                    (R) triangle => first row : i = 1, end side: j = n
               for hill pattern, 
                    (L) triangle => last row : i = n and start side : j = 1
                    (R) triangle => last row : i = n and end side :   j = i   

           */

            Console.WriteLine("Hollow Hour Glass Pattern");
            //reverse hill
            for (int i = 1; i < n; i++) //changed <= to < to make one row less
            {
                for (int sp = 1; sp <= i; sp++)
                {
                    Console.Write("  ");
                }
                for (int j = i; j < n; j++) //changed in first inner loop <= to < here to make one column less printed
                {
                    if (i == 1 || j == i)
                        Console.Write("* ");
                    else
                        Console.Write("  ");
                }
                for (int j = i; j <= n; j++)
                {
                    if (i == 1 || j == n)
                        Console.Write("* ");
                    else
                        Console.Write("  ");
                }
                Console.WriteLine();
            }
            //hill
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

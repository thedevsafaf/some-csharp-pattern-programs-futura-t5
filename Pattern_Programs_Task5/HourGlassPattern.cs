using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Programs_Task5
{
 /*

HOUR GLASS PATTERN = inverted full pyramid + full pyramid

* * * * *
 * * * *
  * * *
   * *
    * 
   * *
  * * *
 * * * *  
* * * * *

 */
    public class HourGlassPattern
    {
        int n=5;
        public void ShowHourGlassPattern()
        {
            Console.WriteLine("Hour Glass Pattern");
            Console.WriteLine("=========================");
            Console.WriteLine();

            DisplayPattern();
        }    

        public void DisplayPattern() 
        {
            //top 
            for (int i = 0; i < n; i++) 
            {
                for(int sp = 0; sp < i; sp++)
                {
                    Console.Write(" ");
                }
                for(int j = 0; j < n-i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            //bottom
            for(int i = 1; i < n; i++)
            {
                for(int sp = 0; sp <= n - i - 2; sp++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

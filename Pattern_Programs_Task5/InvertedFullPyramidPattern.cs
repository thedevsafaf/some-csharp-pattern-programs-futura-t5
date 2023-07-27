using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Programs_Task5
{
    /*

     INVERTED FULL PYRAMID PATTERN 

     * * * * * * * *
       * * * * * *
         * * * *
           * *
            *

    spaces = 2 * i
    2 * (n - i) - 1 for 8*, 6*, 4* ...

     */
    public class InvertedFullPyramidPattern
    {
        int n;
        public void ShowInvertedFullPyramidPattern() 
        {
            Console.WriteLine("Full Pyramid Pattern");
            Console.WriteLine("=========================");

            Console.WriteLine("Enter no of rows:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            DisplayPattern();
        }

        public void DisplayPattern()
        {
            //for outer loop to print rows
            for (int i = 0; i < n; i++) 
            {
                //inner loop for space print
                for (int spaces = 0; spaces < 2 * i; spaces++)
                {
                    Console.Write(" ");
                }
                //inner loop for print characters in each row
                for (int j = 0; j < 2 * (n - i) - 1; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

    }
}

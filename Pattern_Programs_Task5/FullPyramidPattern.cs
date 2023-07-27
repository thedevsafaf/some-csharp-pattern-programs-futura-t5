using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Programs_Task5
{
    /*

     FULL PYRAMID PATTERN 

             *
           * * *
         * * * * *
       * * * * * * *
     * * * * * * * * *

    spaces = 2 * (n - i) - 1

    2 * i + 1 = printing characters : 1* , 3*, 5*....

     */
    public class FullPyramidPattern
    {
        int n;
        public void ShowFullPyramidPattern()
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
            //outer loop for printing rows
            for(int i = 0; i < n; i++)
            {
                //inner loop 1 for printing spaces
                for (int spaces = 0; spaces < 2 * (n - i) - 1; spaces++)
                {
                    Console.Write(" ");
                }
                //inner loop 2 for printing characters in each row
                for (int j = 0; j < 2 * i + 1; j++) 
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

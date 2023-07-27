using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Programs_Task5
{
    /*

     LEFT HALF PYRAMID PATTERN 

             *
           * *
         * * *
       * * * *
     * * * * *
     
    spaces = 2 * (n - i) - 1


     */
    public class LeftHalfPyramidPattern
    {
        int n;
        public void ShowLeftHalfPyramidPattern()
        {
            Console.WriteLine("Left Half Pyramid Pattern");
            Console.WriteLine("=========================");

            Console.WriteLine("Enter no of rows:");
            n = Convert.ToInt32(Console.ReadLine());
            

            DisplayPattern();

        }

        public void DisplayPattern() 
        {
            //outer loop for row print
            for (int i = 0; i < n; i++)
            {
                //inner loop 1 for spaces
                for (int spaces = 0; spaces < 2 * (n - i) - 1; spaces++)
                {
                    Console.Write(" ");
                }

                //inner loop 2 for character print in each rows
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("* ");
                }
                //for going to next line after each row
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

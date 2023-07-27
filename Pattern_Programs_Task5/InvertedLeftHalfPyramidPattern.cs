using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Programs_Task5
{
    /*

    INVERTED LEFT HALF PYRAMID PATTERN 

    * * * * *      
      * * * * 
        * * *
          * *
            *

    spaces = 2 * i (0 sp, 2 sp, 4 sp, 6 sp, 8 sp)
    n - i  (0 to n - i)

    */
    public class InvertedLeftHalfPyramidPattern
    {
        int n;
        public void ShowInvertedLeftHalfPyramidPattern() 
        {
            Console.WriteLine("Inverted Left Half Pyramid Pattern");
            Console.WriteLine("=========================");

            Console.WriteLine("Enter no of rows:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            DisplayPattern();
        }

        public void DisplayPattern() 
        {
            //outerloop for row print
            for (int i = 0; i < n; i++) 
            {
                //innerloop 1 for spaces
                for (int spaces = 0; spaces < 2 * i; spaces++)
                {
                    Console.Write(" ");
                }
                //innerloop 2 for characters print in each row
                for (int j = 0; j < n - i; j++) 
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }   
}

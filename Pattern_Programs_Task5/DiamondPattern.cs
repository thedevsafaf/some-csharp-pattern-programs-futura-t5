using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Programs_Task5
{
    /*

 DIAMOND PATTERN = Full Pyramid + Inverted Full Pyramid

         *
       * * *
     * * * * *
   * * * * * * *
 * * * * * * * * *
   * * * * * * *
     * * * * *
       * * * 
         *
         

     */


    public class DiamondPattern
    {
        int n;
        public void ShowDiamondPattern()
        {

            Console.WriteLine("Diamond Pattern 2");
            Console.WriteLine("=========================");

            Console.WriteLine("Enter no of rows:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            DisplayPattern();
        }

        public void DisplayPattern()
        {
            //top
            //outer loop 1 for top half pyramid
            for (int i = 0; i < n; i++)
            {
                //spaces 8,6,4,2,0
                for (int sp = 0; sp < 2 * (n - i) - 2; sp++)
                {
                    Console.Write(" ");
                }
                //characters 1*,3*,5*,7*
                for (int j = 0; j < 2 * i + 1; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            //bottom
            //outer loop 2 for bottom half pyramid
            for (int i = 0; i < n; i++)
            {
                //spaces 2,4,6,8
                for (int sp = 0; sp < 2 * i + 2; sp++)
                {
                    Console.Write(" ");
                }
                //characters 7*,5*,3*,1*
                for (int j = 0; j < 2 * (n - i) - 3; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
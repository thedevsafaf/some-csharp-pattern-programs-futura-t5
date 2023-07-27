using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Programs_Task5
{
    /*
               INVERTED RIGHT HALF PYRAMID PATTERN 

               * * * * *
               * * * *
               * * *
               * * 
               * 
               
               n - i
            

    */
    public class InvertedRightHalfPyramidPattern
    {
        int n;
        public void ShowInvertedRightHalfPyramidPattern()
        {
            Console.WriteLine("Inverted Right Half Pyramid Pattern");
            Console.WriteLine("=========================");

            Console.WriteLine("Enter no of rows:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            DisplayPattern();
        }

        public void DisplayPattern()
        {
            //outerloop for print rows
            for (int i = 0; i < n; i++)
            {
                //inner loop for print characters in each row
                for (int j=0; j < n - i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

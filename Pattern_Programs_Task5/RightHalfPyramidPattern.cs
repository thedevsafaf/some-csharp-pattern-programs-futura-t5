using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Pattern_Programs_Task5
{
    /*
               RIGHT HALF PYRAMID PATTERN 

               *
               * *
               * * *
               * * * *
               * * * * *

    */
    public class RightHalfPyramidPattern
    {
        int n;
        public void ShowRightHalfPyramidPattern()
        {
            Console.WriteLine("Right Half Pyramid Pattern");
            Console.WriteLine("==========================");

            //asking user input for no of rows to print the pattern
            Console.WriteLine("Enter no of rows for pattern print:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            //method to display pattern
            DisplayPattern();
        }

        public void DisplayPattern()
        {
            //outer loop for row printing
            for (int i = 0; i < n; i++)
            {
                //inner loop for pattern in each rows
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("* ");
                    //Console.Write((j+1)+" ");
                    //Console.Write((char)('A'+j)+" ");
                }
                //for going to next line after each row
                Console.WriteLine();
            }
            Console.ReadKey();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Programs_Task5
{
    /*
     
        1
        2  3
        4  5  6
        7  8  9  10
        11 12 13 14 15

    */
    public class FloydsTrianglePattern
    {
        int rows = 4;
        int n = 1;
        public void ShowFloydsTrianglePattern() 
        {
            Console.WriteLine("Floyd's Triangle Pattern");
            Console.WriteLine("=========================");

            Console.WriteLine("Enter no of rows:");
            Console.WriteLine();

            DisplayPattern();
        }

        public void DisplayPattern() 
        {
            //outer loop for rows
            for(int i = 0; i < rows; i++)
            {
                //inner loop for printing num in each row
                for(int j = 0; j <= i; j++)
                {
                    Console.Write((n++) + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

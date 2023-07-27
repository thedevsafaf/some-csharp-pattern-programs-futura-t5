using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Programs_Task5
{
    /*
        
        * * * * *
         * * * * *
          * * * * *
           * * * * *
            * * * * *
    */
     

    public class RhombusPattern
    {
        int n;
        public void ShowRhombusPattern()
        {
            Console.WriteLine("Rhombus Pattern");
            Console.WriteLine("=========================");

            Console.WriteLine("Enter no of rows:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            DisplayPattern();
        }

        public void DisplayPattern()
        {
            //outer loop for rows printing
            for(int i = 0; i < n; i++)
            {
                //inner loop 1 for spaces
                for (int spaces = 0; spaces < i; spaces++)
                {
                    Console.Write(" ");
                }
                //inner loop 2 for *s print in each rows
                for (int j =0; j < n; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

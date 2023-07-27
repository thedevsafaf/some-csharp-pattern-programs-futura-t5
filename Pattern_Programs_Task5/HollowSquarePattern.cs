using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Programs_Task5
{
    public class HollowSquarePattern
    {

        /*  

            j j j j j    
            0 1 2 3 4
        i 0 * * * * *
        i 1 *       *
        i 2 *       *
        i 3 *       *
        i 4 * * * * *

        */
        public void ShowHollowSquarePattern() 
        {

            int n = 5;
            Console.WriteLine("Hollow Sqaure Pattern");

            for(int i = 0; i < n; i++) 
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == 0 || j == 0 || i == n-1 || j == n-1)
                        Console.Write("* ");
                    else
                        Console.Write("  ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }   
}

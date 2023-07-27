using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Programs_Task5
{
    /*

              n = 5

                  j j j j j    
                  0 1 2 3 4
              i 0 * * * * *
              i 1 * * * * *
              i 2 * * * * *
              i 3 * * * * *
              i 4 * * * * *


            first row : i = 0 
            last row  : i = n - 1
            first col : j = 0
            last col  : j = n - 1
            mid row/col : n/2 + 1

            major diagonal : i == j      

           *
            * 
             *
              *
               *                                                                                                                                                                                    


            left/minor diagonal : i + j == n + 1                    

               *
              * 
             *
            *
           * 

    */


    public class SquarePattern
    {
        
        public void ShowSquarePattern() 
        {
            int n = 5;
  
           /* 
            
           i 0 1 2 3 4
             * * * * *
            
           */ 
            Console.WriteLine("Single Row * Pattern");
            for (int i = 0; i < n; i++)
            {
                Console.Write("* ");
            }

            NextLine();


            /*  
             
                j j j j j    
                0 1 2 3 4
            i 0 * * * * *
            i 1 * * * * *
            i 2 * * * * *
            i 3 * * * * *
            i 4 * * * * *
             
            */

            Console.WriteLine("Sqaure Pattern");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++) 
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            NextLine();

            /*  
             
                jjjjj    
                01234
            i 0 *****
            i 1 *****
            i 2 *****
            i 3 *****
            i 4 *****
             
            */

            Console.WriteLine("Rectangle Pattern");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            NextLine();

            /*  

               j j j j j    
               0 1 2 3 4
           i 0 *       *
           i 1 *       *
           i 2 *       *
           i 3 *       *
           i 4 *       *

           */

            Console.WriteLine("Square Parallel Vertical Bar Pattern");
            for ( int i = 0; i < n; i++) 
            {
                for ( int j = 0; j < n; j++)
                {
                    if (j == 0 || j == n - 1)
                        Console.Write("* ");
                    else
                        Console.Write("  ");
                }
                Console.WriteLine();
            }

            NextLine();

            /*  
             
                j j j j j    
                0 1 2 3 4
            i 0 * * * * *
            i 1 
            i 2 
            i 3 
            i 4 * * * * *
             
            */

            Console.WriteLine("Square Parallel Horizontal Bar Pattern");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == 0 || i == n - 1)
                        Console.Write("* ");
                    else
                        Console.Write("  ");
                }
                Console.WriteLine();
            }

            NextLine();


            /*  
             
                j j j j j    
                0 1 2 3 4
            i 0     *
            i 1     *
            i 2 * * * * *
            i 3     *
            i 4     *
             
            */

            Console.WriteLine("Square Plus Pattern");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == (n-1)/2 || j == (n-1)/2)
                        Console.Write("* ");
                    else
                        Console.Write("  ");
                }
                Console.WriteLine();
            }

            NextLine();

            /*  
             
                j j j j j    
                0 1 2 3 4
            i 0 *       *
            i 1   *   *
            i 2     * 
            i 3   *   *
            i 4 *       *
             
            */

            Console.WriteLine("X - Diagonal Pattern");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j || i + j == n - 1)
                        Console.Write("* ");
                    else
                        Console.Write("  ");
                }
                Console.WriteLine();
            }

            NextLine();



















            Console.ReadKey();
        }


        //wrote a method for next line
        public void NextLine()
        {
            Console.WriteLine("\n\n\n");
        }

    }

    

}

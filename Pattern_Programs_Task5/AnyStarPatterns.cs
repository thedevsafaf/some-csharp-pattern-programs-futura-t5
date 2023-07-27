using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Programs_Task5
{
    public class AnyStarPatterns
    {
        int n = 5;
        public void ShowAnyStarPatterns()
        {
            /*        j j j j j
                      1 2 3 4 5
                 i 1  *
                 i 2  * * 
                 i 3  * * *
                 i 4  * * * *
                 i 5  * * * * *
            
                 for increasing triangle, take inner loop j = 1 to i
            */
            
            Console.WriteLine("Increasing Triangle Pattern");
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            NextLine();

            /*       j j j j j
                     1 2 3 4 5   i to n
                i 1  * * * * *   1 to 5 = 1,2,3,4,5
                i 2  * * * *     2 to 5 = 2,3,4,5
                i 3  * * *       3 to 5 = 3,4,5
                i 4  * *         4 to 5 = 4,5
                i 5  * 

               for decreasing triangle, take innerloop from j = i to n
           */


            Console.WriteLine("Decreasing Triangle Pattern");
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <= n; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            NextLine();

            /*       j j j j j
                     1 2 3 4 5
                i 1  _ _ _ _ *
                i 2  _ _ _ * *
                i 3  _ _ * * *
                i 4  _ * * * *
                i 5  * * * * *

                i to n              1 to i
                decreasing spaces + increasing stars

           */


            Console.WriteLine("Right Sided Triangle");
            for(int i = 1; i <= n;i++)
            {
                for (int sp = i; sp <= n; sp++)
                {
                    Console.Write("  ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            NextLine();

            /*       j j j j j
                    1 2 3 4 5
               i 1  * * * * *
               i 2  _ * * * *
               i 3  _ _ * * *
               i 4  _ _ _ * *
               i 5  _ _ _ _ *

               1 to i              i to n
               increasing spaces + decreasing stars

          */


            Console.WriteLine("Right Sided Triangle");
            for (int i = 1; i <= n; i++)
            {
                for (int sp = 1; sp <= i; sp++)
                {
                    Console.Write("  ");
                }
                for (int j = i; j <= n; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            NextLine();


            /*       
                    j j j j j
                    1 2 3 4 5
               i 1  _ _ _ _ *
               i 2  _ _ _ * * *
               i 3  _ _ * * * * *
               i 4  _ * * * * * * *
               i 5  * * * * * * * * *
               
               i to n              1 to i                1 to i
               decreasing spaces + increasing stars(L) + increasing stars(R)

           */

            Console.WriteLine("Hill Pattern");
            for (int i = 1; i <= n; i++)
            {
                for (int sp = i; sp <= n; sp++)
                {
                    Console.Write("  ");
                }
                for (int j = 1; j < i; j++) //changed in first inner loop <= to < here to make one column less printed
                {
                    Console.Write("* ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            NextLine();

            /*       
                    j j j j j
                    1 2 3 4 5
               i 1  * * * * * * * * *
               i 2  _ * * * * * * * 
               i 3  _ _ * * * * *
               i 4  _ _ _ * * *
               i 5  _ _ _ _ *

               1 to i              i to n                i to n
               increasing spaces + decreasing stars(L) + decreasing stars(R)

           */

            Console.WriteLine("Reverse Hill Pattern");
            for (int i = 1; i <= n; i++)
            {
                for (int sp = 1; sp <= i; sp++)
                {
                    Console.Write("  ");
                }
                for (int j = i; j < n; j++) //changed in first inner loop <= to < here to make one column less printed
                {
                    Console.Write("* ");
                }
                for (int j = i; j <= n; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            NextLine();


            /*       
                   j j j j j
                   1 2 3 4 5
              i 1  _ _ _ _ *
              i 2  _ _ _ * * *
              i 3  _ _ * * * * *
              i 4  _ * * * * * * *
              i 5  * * * * * * * * *
                   _ * * * * * * * 
                   _ _ * * * * *
                   _ _ _ * * *
                   _ _ _ _ *  

              i to n              1 to i                1 to i
              decreasing spaces + increasing stars(L) + increasing stars(R)
              1 to i              i to n                i to n
              increasing spaces + decreasing stars(L) + decreasing stars(R)

            */

            Console.WriteLine("Diamond Pattern");
            //hill
            for (int i = 1; i < n; i++) //changed <= to < to make one row less
            {
                for (int sp = i; sp <= n; sp++)
                {
                    Console.Write("  ");
                }
                for (int j = 1; j < i; j++) //changed in first inner loop <= to < here to make one column less printed
                {
                    Console.Write("* ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            //reverse hill
            for (int i = 1; i <= n; i++)
            {
                for (int sp = 1; sp <= i; sp++)
                {
                    Console.Write("  ");
                }
                for (int j = i; j < n; j++) //changed in first inner loop <= to < here to make one column less printed
                {
                    Console.Write("* ");
                }
                for (int j = i; j <= n; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            NextLine();

            /*       
                    
                     j j j j j
                     1 2 3 4 5
                     * * * * * * * * *
               i 1   _ * * * * * * * 
               i 2   _ _ * * * * *
               i 3   _ _ _ * * *
               i 4   _ _ _ _ *  
               i 5   _ _ _ * * *
                     _ _ * * * * *
                     _ * * * * * * *
                     * * * * * * * * *
       

            */

            Console.WriteLine("Hour Glass Pattern");
            //reverse hill
            for (int i = 1; i < n; i++)
            {
                for (int sp = 1; sp <= i; sp++)
                {
                    Console.Write("  ");
                }
                for (int j = i; j < n; j++) //changed in first inner loop <= to < here to make one column less printed
                {
                    Console.Write("* ");
                }
                for (int j = i; j <= n; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            //hill
            for (int i = 1; i <= n; i++) //changed <= to < to make one row less
            {
                for (int sp = i; sp <= n; sp++)
                {
                    Console.Write("  ");
                }
                for (int j = 1; j < i; j++) //changed in first inner loop <= to < here to make one column less printed
                {
                    Console.Write("* ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            NextLine();

            /*        j j j j j
                      1 2 3 4 5
                 i 1  *
                 i 2  * * 
                 i 3  *   *
                 i 4  *     *
                 i 5  * * * * *       

                 last row : i = n
                 start and end * of each row : j = 1 to j = i
            
                 for hollow increasing triangle, take inner loop j = 1 to i
            */

            //HOLLOW INdCREASING TRIANGLE
            Console.WriteLine("Hollow Increasing Triangle Pattern");
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i == n || j == 1 || j == i)
                        Console.Write("* ");
                    else
                        Console.Write("  ");
                }
                Console.WriteLine();
            }
            NextLine();


            /*        j j j j j
                      1 2 3 4 5
                 i 1  * * * * *
                 i 2  *     *
                 i 3  *   *
                 i 4  * *     
                 i 5  *        

                 first row : i = 1
                 start and end * of each row : j = i and j = n
                        
            
                 for hollow decreasing triangle, take inner loop j = i to n
            */

            //HOLLOW DECREASING TRIANGLE
            Console.WriteLine("Hollow Decreasing Triangle Pattern");
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <= n; j++)
                {
                    if (i == 1 || j == i || j == n)
                        Console.Write("* ");
                    else
                        Console.Write("  ");
                }
                Console.WriteLine();
            }
            NextLine();

            /*       
                    j j j j j
                    1 2 3 4 5
               i 1  _ _ _ _ *
               i 2  _ _ _ *   *
               i 3  _ _ *       *
               i 4  _ *           *
               i 5  * * * * * * * * *
               
               i to n              1 to i                1 to i
              decreasing spaces + increasing stars(L) + increasing stars(R)

              for hill pattern, 
              see (L) triangle part, last row : i = n and start side : j = 1
              see (R) triangle part, last row : i = n and end side :   j = i 

           */

            //HOLLOW HILL PATTERN
            Console.WriteLine("Hollow Hill Pattern");
            for (int i = 1; i <= n; i++)
            {
                for (int sp = i; sp <= n; sp++)
                {
                    Console.Write("  ");
                }
                for (int j = 1; j < i; j++) //changed in first inner loop <= to < here to make one column less printed
                {
                    if (i == n || j == 1)
                        Console.Write("* ");
                    else
                        Console.Write("  ");
                }
                for (int j = 1; j <= i; j++)
                {
                    if (i == n || j == i)
                        Console.Write("* ");
                    else
                        Console.Write("  ");
                }
                Console.WriteLine();
            }

            NextLine();

            /*       
                   j j j j j
                   1 2 3 4 5
              i 1  * * * * * * * * *
              i 2  _ *           * 
              i 3  _ _ *       *
              i 4  _ _ _ *   *
              i 5  _ _ _ _ *

              1 to i              i to n                i to n
              increasing spaces + decreasing stars(L) + decreasing stars(R

              L triangle : first row : i = 1, start side: j = i
              R triangle : first row : i = 1, end side: j = n

          */

            //HOLLOW REVERSE HILL PATTERN
            Console.WriteLine("Hollow Reverse Hill Pattern");
            for (int i = 1; i <= n; i++)
            {
                //spaces
                for (int sp = 1; sp <= i; sp++)
                {
                    Console.Write("  ");
                }
                //left triangle
                for (int j = i; j < n; j++) //changed in first inner loop <= to < here to make one column less printed
                {
                    if (i == 1 || j == i)
                        Console.Write("* ");
                    else
                        Console.Write("  ");
                    
                }
                //right triangle
                for (int j = i; j <= n; j++)
                {
                    if (i == 1 || j == n)
                        Console.Write("* ");
                    else
                        Console.Write("  ");
                }
                Console.WriteLine();
            }

            NextLine();


            //HOLLOW DIAMOND

            /*       
                   j j j j j
                   1 2 3 4 5
              i 1  _ _ _ _ *
              i 2  _ _ _ *   *
              i 3  _ _ *       *
              i 4  _ *           *
              i 5  *               *
                   _ *           * 
                   _ _ *       *
                   _ _ _ *   *
                   _ _ _ _ *  

              i to n              1 to i                1 to i
              decreasing spaces + increasing stars(L) + increasing stars(R)
              1 to i              i to n                i to n
              increasing spaces + decreasing stars(L) + decreasing stars(R)

              consider 4 triangles (upper_left1, lower_left1, upper_right2, lower_right2)
              
              start side : upper_left1 (j = 1), lower_left1 (j = i)
              end side : upper_right2  (j = i), lower_right2 (j = n)

            */


            Console.WriteLine("Hollow Diamond Pattern");
            //hill
            for (int i = 1; i < n; i++) //changed <= to < to make one row less
            {
                for (int sp = i; sp <= n; sp++)
                {
                    Console.Write("  ");
                }
                for (int j = 1; j < i; j++) //changed in first inner loop <= to < here to make one column less printed
                {   
                    if ( j == 1 ) 
                        Console.Write("* ");
                    else
                        Console.Write("  ");
                }
                for (int j = 1; j <= i; j++)
                {
                    if (j == i)
                        Console.Write("* ");
                    else
                        Console.Write("  ");
                }
                Console.WriteLine();
            }
            //reverse hill
            for (int i = 1; i <= n; i++)
            {
                for (int sp = 1; sp <= i; sp++)
                {
                    Console.Write("  ");
                }
                for (int j = i; j < n; j++) //changed in first inner loop <= to < here to make one column less printed
                {
                    if (j == i)
                        Console.Write("* ");
                    else
                        Console.Write("  ");
                }
                for (int j = i; j <= n; j++)
                {
                    if (j == n)
                        Console.Write("* ");
                    else
                        Console.Write("  ");
                }
                Console.WriteLine();
            }

            NextLine();


            //HOLLOW HOURGLASS PATTERN
            /*       

                    j j j j j
                    1 2 3 4 5
                    * * * * * * * * *
              i 1   _ *           * 
              i 2   _ _ *       *
              i 3   _ _ _ *   *
              i 4   _ _ _ _ *  
              i 5   _ _ _ *   *
                    _ _ *       *
                    _ *           *
                    * * * * * * * * *
                    
               for reverse hill pattern,
                    (L) triangle => first row : i = 1, start side: j = i
                    (R) triangle => first row : i = 1, end side: j = n
               for hill pattern, 
                    (L) triangle => last row : i = n and start side : j = 1
                    (R) triangle => last row : i = n and end side :   j = i   

           */

            Console.WriteLine("Hollow Hour Glass Pattern");
            //reverse hill
            for (int i = 1; i < n; i++)
            {
                for (int sp = 1; sp <= i; sp++)
                {
                    Console.Write("  ");
                }
                for (int j = i; j < n; j++) //changed in first inner loop <= to < here to make one column less printed
                {
                    if (i == 1 || j == i)
                        Console.Write("* ");
                    else
                        Console.Write("  ");
                }
                for (int j = i; j <= n; j++)
                {
                    if (i == 1 || j == n)
                        Console.Write("* ");
                    else
                        Console.Write("  ");
                }
                Console.WriteLine();
            }
            //hill
            for (int i = 1; i <= n; i++) //changed <= to < to make one row less
            {
                for (int sp = i; sp <= n; sp++)
                {
                    Console.Write("  ");
                }
                for (int j = 1; j < i; j++) //changed in first inner loop <= to < here to make one column less printed
                {
                    if (i == n || j == 1)
                        Console.Write("* ");
                    else
                        Console.Write("  ");
                }
                for (int j = 1; j <= i; j++)
                {
                    if (i == n || j == i)
                        Console.Write("* ");
                    else
                        Console.Write("  ");
                }
                Console.WriteLine();
            }
            NextLine();


            Console.ReadKey();
        }

        public void NextLine()
        {
            Console.WriteLine("\n\n\n");
        }


    }
}

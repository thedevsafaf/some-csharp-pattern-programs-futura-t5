using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Programs_Task5
{
    public class PascalsTriangle
    {
        public int rows = 5;
        public int n;

        public void ShowPascalsTriangle()
        {
            Console.WriteLine("Pascal's Triangle");
            Console.WriteLine("=================\n\n");
            
            for(int i = 0; i < rows; i++) 
            {
                for (int sp = i; sp < rows-1; sp++)
                {
                    Console.Write(" ");
                }
                n = 1;
                for (int j =0; j <= i; j++)
                {
                    Console.Write(n+" ");
                    n = n * (i - j) / (j + 1);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

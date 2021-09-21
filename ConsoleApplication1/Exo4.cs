using System;

namespace ConsoleApplication1
{
    public class Exo4
    {
        public void square(int n, int m)
        {
            for (int i = 0; i < n; i++) {
                if(i == 0 || i == n-1) 
                    Console.Write(0);
                else
                {
                    Console.Write("_");
                }
             }
            Console.WriteLine("");
            for (int j = 0; j < m-2; j++) {
                Console.Write("|");
                for (int k = 0; k < n-2; k++) {
                    Console.Write(" ");
                }
                Console.WriteLine("|");
            }
            for (int i = 0; i < n; i++) {
                if(i == 0 || i == n-1) 
                    Console.Write(0);
                else
                {
                    Console.Write("_");
                }
                
            }
            }
    }
}
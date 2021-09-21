using System;

namespace ConsoleApplication1
{
    public class Exo1
    {
        public void multiplicationImpair(int nmbr)
        {
            int n = 5;
            Console.WriteLine("Table of : " + nmbr);
            for (int i = 1; i <= 10; i++)
                if ((nmbr * i) % 2 == 0)
                    Console.WriteLine(nmbr + " * " + i + " = " + nmbr * i);

        }
    }
}
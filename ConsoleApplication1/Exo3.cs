using System;

namespace ConsoleApplication1
{
    public class Exo3
    {
        public void Power()
        {
            for (int i = -3; i <= 3; i++)
            {
                try
                {
                    Console.WriteLine(10 / PowerFunction(i));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }

        public  int PowerFunction(int x)
        {
           return (int) (Math.Pow(x, 2) - 4);
        }


    }
}
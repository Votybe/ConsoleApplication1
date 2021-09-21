using System;

namespace ConsoleApplication1
{
    public class Exo2
    {
        public   void estPremier()
        {
            Boolean verifPremier = true;
            for (int i = 1; i <= 1000; i++)
            {
                verifPremier = true;
                for (int j = 2; j < i; j++)
                    if (i % j == 0) verifPremier = false;
                if (verifPremier)  
                    Console.WriteLine(i);
            }
        }
        
        public   void Fibonnaci(int n)
        {
            int a = 0,  b = 1, resultFinal = 0;
            Console.WriteLine(a + " " + b);

            for (int i = 1; i <= 100; i++)
            {
                int result = a + b;
                resultFinal = result;
                a = b;
                b = result;
                Console.WriteLine(resultFinal);
                if (resultFinal >= n) 
                    break;
            }
        }

        public   void factorielle(int nbr)
        {
            int result = 1;
            for (int i = 1; i <= nbr; i++)
                result = i * result;
            Console.WriteLine(result);
        }

  
    }
}
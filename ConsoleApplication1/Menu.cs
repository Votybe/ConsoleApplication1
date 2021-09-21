using System;

namespace ConsoleApplication1
{
    public class Menu
    {
        public void menuPrincipal()
        {
                        int n = 0, m = 0, x;
            do
            {
                Console.Write("Choississez votre exo  :");
                 x = AskUserForParameter();

                switch (x)
                {
                    case 1:
                        Console.Write("Enter n :");
                        n = AskUserForParameter();
                        Exo1 exoUn = new Exo1();
                        exoUn.multiplicationImpair(n);
                        break;
                    case 2:
                        Console.Write("Exo 2 (1 : premier) | (2: fibonnaci) | (3: factorielle) :");
                        int y = AskUserForParameter();
                        Exo2 exoDeux = new Exo2();
                        switch (y)
                        {
                            case 1:
                                exoDeux.estPremier();
                                break;
                            case 2:
                                Console.Write("Enter n :");
                                n = AskUserForParameter();
                                exoDeux.Fibonnaci(n);
                                break;
                            case 3:
                                Console.Write("Enter n :");
                                n = AskUserForParameter();
                                exoDeux.factorielle(n);
                                break;
                            default:
                                Console.WriteLine("Choissisez un exercice entre 1 et 3 !");
                                break;
                        }

                        break;
                    case 3:
                        Exo3 exoTrois = new Exo3();
                        exoTrois.Power();
                        break;
                    case 4:
                        Console.Write("Enter n :");
                        m = AskUserForParameter();
                        Console.Write("Enter n :");
                        n = AskUserForParameter();
                        Exo4 exoQuatre = new Exo4();
                        exoQuatre.square(n, m);
                        break;
                    case 5:
                        Exo5 expCinq = new Exo5();
                        expCinq.AllDataPoints();
                        break;
                    default:
                        Console.WriteLine("Choissisez un exercice entre 1 et 5 !");
                        break;
                }
            } while (x != 0);

        }
        
        private static int AskUserForParameter()
        {
            int.TryParse(Console.ReadLine(), out var result);
            return result;
        }
    }
}
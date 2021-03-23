using System;

namespace BA.Demo.PlusOuMoins
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.initialisé et déclarer les valeurs minimal et maximal attendu (entier) (1-100)
            //2.déclarer et affecter une valeur random dans une variable valeurATrouver (entier)
            //3.déclarer la var de proposition (entier)(proposition du joueur)
            //4.récuperer valeur proposition du joueur
            //5.proposition != random
            //5. loop => verifier si proposition > random
            //5. loop : True => dire "C'est moins"
            //5. loop : False => dire "C'est plus"
            //5. loop => récupérer nouvelle proposition
            //6.dire "trouvé"

            const int MIN = 1;
            const int MAX = 100;
            Random RNG = new Random();
            int valeurATrouver = RNG.Next(MIN, MAX);
            int proposition;
            #region While...
            Console.WriteLine($"Veuillez introduire un nombre compris entre {MIN} et {MAX}:");
            proposition = int.Parse(Console.ReadLine());
            while(proposition != valeurATrouver)
            {
                Console.Write("Dommage, ");
                if(proposition < valeurATrouver)
                {
                    Console.WriteLine("c'est plus!");
                }
                else
                {
                    Console.WriteLine("c'est moins!");
                }
                Console.WriteLine("Veuillez réessayer :");
                proposition = int.Parse(Console.ReadLine());
            }
            #endregion
            #region Do...While...
            //do
            //{
            //    Console.WriteLine($"Veuillez introduire un nombre compris entre {MIN} et {MAX}:");
            //    proposition = int.Parse(Console.ReadLine());
            //    if (proposition < valeurATrouver)
            //    {
            //        Console.Write("Dommage, ");
            //        Console.WriteLine("c'est plus!");
            //    }
            //    else if (proposition > valeurATrouver)
            //    {
            //        Console.Write("Dommage, ");
            //        Console.WriteLine("c'est moins!");
            //    }
            //} while (proposition != valeurATrouver);
            #endregion
            Console.WriteLine($"Félicitation le nombre à trouver était de {valeurATrouver}!");
        }
    }
}

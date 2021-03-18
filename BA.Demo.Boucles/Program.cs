using System;

namespace BA.Demo.Boucles
{
    class Program
    {
        static void Main(string[] args)
        {
            #region while(...){...}
            //Console.WriteLine("Veuillez entrer une valeur numérique :");
            //string userInput = Console.ReadLine();
            //while (!int.TryParse(userInput, out _))
            //{
            //    Console.WriteLine("Mauvaise entrée...");
            //    Console.WriteLine("Veuillez entrer une valeur numérique :");
            //    userInput = Console.ReadLine();
            //}
            //Console.WriteLine("Ceci est bien une valeur numérique.");
            #endregion

            #region while(...){...} (optimisé)
            //Console.WriteLine("Veuillez entrer une valeur numérique :");
            //while (!int.TryParse(Console.ReadLine(), out _))
            //{
            //    Console.WriteLine("Mauvaise entrée...");
            //    Console.WriteLine("Veuillez entrer une valeur numérique :");
            //}
            //Console.WriteLine("Ceci est bien une valeur numérique.");
            #endregion

            #region do {...} while(...);
            do
            {
                Console.WriteLine("Veuillez entrer une valeur numérique :");
            } while (!int.TryParse(Console.ReadLine(), out _));
            Console.WriteLine("Ceci est bien une valeur numérique.");
            #endregion

            #region Utilisation d'un for pour une répétition non-contrôlée (a éviter)
            ////A éviter de reproduire, ici nous l'avons mis en place pour prover qu'en C# beaucoup de chose sont permis.

            /*Console.WriteLine("Veuillez entrer une valeur numérique :");
            for(string userInput = Console.ReadLine();!int.TryParse(userInput, out _);userInput = Console.ReadLine())
            {
                Console.WriteLine("Mauvaise entrée...");
                Console.WriteLine("Veuillez entrer une valeur numérique :");

            }
            Console.WriteLine("Ceci est bien une valeur numérique.");*/
            #endregion
        }
    }
}

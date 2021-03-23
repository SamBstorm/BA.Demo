using System;

namespace BA.Demo.TableauDeSix
{
    class Program
    {
        static void Main(string[] args)
        {
            const int TAILLE = 6;
            int[] tableau = new int[TAILLE]; //[0,0,0,0,0,0]
            int nbElem = 0;
            int index = 0;
            while (nbElem < TAILLE)
            {
                Console.WriteLine("Veuillez introduire un nombre :");
                tableau[nbElem] = int.Parse(Console.ReadLine());
                nbElem += 1; //nbElem++; //nbElem = nbElem + 1;
            }
            while (index < nbElem)
            {
                Console.WriteLine(tableau[index]);
                index++;
            }
        }
    }
}

using System;

namespace BA.Demo.TableauExposantDeux
{
    class Program
    {
        static void Main(string[] args)
        {
            const int TAILLE = 10;
            int[] tableau = new int[TAILLE];    //[0,0,0,0,0,0,0,0,0,0]
            tableau[0] = 2;                     //[2,0,0,0,0,0,0,0,0,0]
            int nbElem;
            for (nbElem = 1; nbElem < TAILLE; nbElem++)
            {
                tableau[nbElem] = tableau[nbElem - 1] * 2;
            }
            foreach (int cellule in tableau)
            {
                Console.WriteLine(cellule);
            }
        }
    }
}

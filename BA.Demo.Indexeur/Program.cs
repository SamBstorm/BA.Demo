using System;

namespace BA.Demo.Indexeur
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();

            deck.InitDeck();

            Carte[] main = new Carte[7];

            for (int i = 0; i < 7; i++)
            {
                main[i] = deck[0];
            }

            foreach (Carte carte in main)
            {
                Console.WriteLine($"Le {carte.Valeur} de {carte.Couleur}.");
            }

            deck[-1] = main[3];

            main[3] = deck[Couleurs.Trefle, Valeurs.As];

            deck[Couleurs.Trefle, Valeurs.As] = null;
        }
    }
}

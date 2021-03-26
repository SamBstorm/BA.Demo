using System;

namespace BA.Demo.Heritage
{
    class Program
    {
        static void Main(string[] args)
        {
            Transport t = new Transport();
            t.NbPassager = 2;

            Voiture v = new Voiture();
            v.NbPassager = 4;
            v.NbRoues = 4;
            v.Couleur = "Rouge";

            Roadster r = new Roadster();
            r.NbPassager = 2;
            r.NbRoues = 4;
            r.Couleur = "Jaune";
            r.OuvrirToit();

            Bateau b = new Bateau();
            b.NbPassager = 24;
            b.SeDeplacer();

            r.SeDeplacer();
        }
    }
}

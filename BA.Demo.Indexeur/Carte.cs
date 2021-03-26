using System;
using System.Collections.Generic;
using System.Text;

namespace BA.Demo.Indexeur
{
    public enum Couleurs { Coeur, Pique, Trefle, Carreau}
    public enum Valeurs { Deux = 2, Trois, Quatre, Cinq, Six, Sept, Huit, Neuf, Dix, Valet, Reine, Roi, As}
    public class Carte
    {
        public Couleurs Couleur;
        public Valeurs Valeur;
    }
}

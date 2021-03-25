using System;

namespace BA.Demo.NomVariableMotReserve
{
    public enum Valeurs { @as = 14 }

    class Program
    {
        static void Main(string[] args)
        {
            // impossible de faire  : int as = 24; car le nom donné à la variable est un mot dit réservé.
            // 2 solutions :
            // Bonne pratique : changer le nom ou du moins sa case.
            int As = 24;
            // Mauvaise pratique : conserver le nom, mais retiré la protection des mots réservé avec un @
            int @as = 24;

            // Il en va de même pour les enums
            Valeurs test = Valeurs.@as;
        }
    }
}

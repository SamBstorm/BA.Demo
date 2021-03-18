using System;

namespace BA.Demo.Tableau
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = { "riri", "fifi", "loulou", "zaza", "picsou", "flagada" };
            //Index   =>            0        1        2        3       4          5
            Console.WriteLine(strings[4]);
            strings[4] = "Donald";
            Console.WriteLine(strings[4]);
            //Console.WriteLine(strings[6]); //Erreur IndexOutOfRangeException... dépassement de l'index...

        }
    }
}

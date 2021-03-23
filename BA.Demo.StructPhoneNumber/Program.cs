using System;

namespace BA.Demo.StructPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            PhoneNumber pn = new PhoneNumber();
            pn.nationalNumber = "+32";
            pn.indicatif = 0800;
            pn.numero = 33800;
            Console.WriteLine($"{pn.nationalNumber}(0){pn.indicatif}/{pn.numero}");

            Console.WriteLine("Coucou"); // C'est une procédure, le type retour est void
            string resultat = Console.ReadLine(); // C'est une méthode/fonction, un résultat est attendu, le type de retour ici est string
        }
    }

    public struct PhoneNumber
    {
        public string nationalNumber;
        public int indicatif;
        public int numero;
    }
}

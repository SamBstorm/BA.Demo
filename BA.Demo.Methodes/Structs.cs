using System;
using System.Collections.Generic;
using System.Text;

namespace BA.Demo.Methodes
{
    public struct MesMethodes
    {
        public bool IsFirstTime;
        public string Nom;

        public void Salutation()
        {
            if (Nom is null) Console.WriteLine("Bonjour à tous");
            else Console.WriteLine($"Bonjour {Nom}");
            if (!IsFirstTime)
            {
                return;
            }
            IsFirstTime = false;
            Console.WriteLine($"Nous sommes le {DateTime.Now}");
        }

        public void Salutationv2()
        {
            Console.WriteLine("Bonjour à tous");
            if (IsFirstTime)
            {
                IsFirstTime = false;
                Console.WriteLine($"Nous sommes le {DateTime.Now}");
            }
        }

        public string RecupererNom()
        {
            if (Nom is null)
            {
                Console.WriteLine("Veuillez indiquer votre nom :");
                string nom = Console.ReadLine();
                return nom;
            }
            return Nom;
        }

        public string RecupererNomV2()
        {
            string nom = Nom;
            if (Nom is null)
            {
                Console.WriteLine("Veuillez indiquer votre nom :");
                nom = Console.ReadLine();
            }
            return nom;
        }
    }
}

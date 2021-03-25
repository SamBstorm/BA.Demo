using System;
using System.Collections.Generic;
using BA.Demo.Structs.Messaging;

namespace BA.Demo.Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Contact> maListeDeContacts = new Dictionary<string, Contact>();

            Contact c1;
            c1.Surnom = "Maman";
            c1.Nom = "Dupont";
            c1.Prenom = "Hortence";
            c1.AdresseMail = "maman@samuel.be";

            Contact c2;
            c2.Surnom = "Papa";
            c2.Nom = "Albert";
            c2.Prenom = "Charles";
            c2.AdresseMail = "papa@samuel.be";

            Contact c3;
            c3.Surnom = "Moi";
            c3.Nom = "Albert";
            c3.Prenom = "Henry";
            c3.AdresseMail = "moi@samuel.be";

            maListeDeContacts.Add(c1.AdresseMail,c1);
            maListeDeContacts.Add(c2.AdresseMail,c2);
            maListeDeContacts.Add(c3.AdresseMail,c3);

            Message msg1;
            msg1.Objet = "Coucou maman";
            msg1.Destinataire = maListeDeContacts[c1.AdresseMail];
            msg1.Expediteur = maListeDeContacts["moi@samuel.be"];
            msg1.Contenu = "";
            msg1.HeureEnvois = DateTime.Now;
            msg1.Receptionne = false;

            Message msg2 = msg1;
            msg2.Objet = "Coucou papa";
            msg2.Destinataire = maListeDeContacts["papa@samuel.be"];

            Console.WriteLine($"{msg1.Objet} {msg1.Destinataire.Surnom} {msg1.HeureEnvois}");
            Console.WriteLine($"{msg2.Objet} {msg2.Destinataire.Surnom} {msg2.HeureEnvois}");
        }
    }
}

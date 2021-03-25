using System;
using System.Collections.Generic;
using System.Text;

namespace BA.Demo.Structs.Messaging
{
    public struct Message
    {
        public string Objet, Contenu;
        public Contact Destinataire, Expediteur;
        public DateTime HeureEnvois;
        public bool Receptionne;
    }
    public struct MessageVideo
    {
        public string Objet, Contenu, Destinataire, Expediteur;
        public DateTime HeureEnvois;
        public bool Receptionne;
        public int DureeMilliSec;
    }

    public struct Contact
    {
        public string Nom, Prenom, Surnom, AdresseMail;
    }
}
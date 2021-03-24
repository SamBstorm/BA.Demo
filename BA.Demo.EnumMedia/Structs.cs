using System;
using System.Collections.Generic;
using System.Text;

namespace BA.Demo.EnumMedia
{
    public struct Media
    {
        public string Titre, SousTitre, Synopsis;
        public SupportMedia Support;
        public uint Duree;
        public Auteur Auteur;
    }

    public struct Auteur
    {
        public string Nom, Prenom, LieuDeNaissance;
        public DateTime DateDeNaissance;
    }
}

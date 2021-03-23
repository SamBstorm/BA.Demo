using System;
using System.Collections.Generic;
using System.Text;

namespace BA.Demo.MediaStruct
{
    public struct Media
    {
        public string Titre, SousTitre, Synopsis;
        public bool SupportHaveImage;
        public uint Duree;
        public Auteur Auteur;
    }

    public struct Auteur
    {
        public string Nom, Prenom, LieuDeNaissance;
        public DateTime DateDeNaissance;
    }
}

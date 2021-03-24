using System;
using System.Collections.Generic;

namespace BA.Demo.EnumMedia
{
    public enum enum1 { toto, titi, tutu}
    class Program
    {
        public enum enum2 { riri, fifi, Loulou }
        static void Main(string[] args)
        {
            Auteur monAuteur;
            monAuteur.Nom = "Hugo";
            monAuteur.Prenom = "Victor";
            monAuteur.LieuDeNaissance = "Paris";
            monAuteur.DateDeNaissance = new DateTime(1865, 8, 14);

            Media livreAudio;
            livreAudio.Titre = "Le bossu de Notre-Dame";
            livreAudio.SousTitre = "Version Audiophone";
            livreAudio.Support = SupportMedia.SceneDeTheatre;
            livreAudio.Synopsis = "Revivez les incroyables aventures de Kasimodo";
            livreAudio.Duree = 3600;
            livreAudio.Auteur = monAuteur;

            Console.WriteLine($"{livreAudio.Titre} - {livreAudio.SousTitre} - Ecrit par : {livreAudio.Auteur.Prenom} {livreAudio.Auteur.Nom}");
            switch (livreAudio.Support)
            {
                case SupportMedia.Audio:
                case SupportMedia.Video:
                    Console.WriteLine($"Ce média est un {(int)livreAudio.Support}-{livreAudio.Support}.");
                    break;
                case SupportMedia.SceneDeTheatre:
                    Console.WriteLine($"Ce média est un {(int)livreAudio.Support}-Scène de théâtre.");
                    break;
            }

            Dictionary<SupportMedia, string> SupportMediaNames = new Dictionary<SupportMedia, string>()
            {
                { SupportMedia.SceneDeTheatre , "Scène de théâtre" },
                { SupportMedia.Audio , "Audio" },
                { SupportMedia.Video , "Vidéo" },
            };

            List<string> SupportMediaNamesOnly = new List<string>() { "Audio", "Vidéo", "Scène de théâtre" };

            SupportMedia sm = (SupportMedia)Enum.Parse(typeof(SupportMedia), "Vidéo");
            sm = Enum.Parse<SupportMedia>("Video");
        }
    }
}

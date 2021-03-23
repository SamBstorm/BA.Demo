using System;

namespace BA.Demo.MediaStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            Auteur monAuteur;
            monAuteur.Nom = "Hugo";
            monAuteur.Prenom = "Victor";
            monAuteur.LieuDeNaissance = "Paris";
            monAuteur.DateDeNaissance = new DateTime(1865,8,14);

            Media livreAudio;
            livreAudio.Titre = "Le bossu de Notre-Dame";
            livreAudio.SousTitre = "Version Audiophone";
            livreAudio.SupportHaveImage = false;
            livreAudio.Synopsis = "Revivez les incroyables aventures de Kasimodo";
            livreAudio.Duree = 3600;
            livreAudio.Auteur = monAuteur;

            Console.WriteLine($"{livreAudio.Titre} - {livreAudio.SousTitre} - Ecrit par : {livreAudio.Auteur.Prenom} {livreAudio.Auteur.Nom}");
            monAuteur.DateDeNaissance = new DateTime(1864, 7, 2);
            Console.WriteLine($"Né le {livreAudio.Auteur.DateDeNaissance}");
            Console.WriteLine($"Né le {monAuteur.DateDeNaissance}");
        }
    }
}

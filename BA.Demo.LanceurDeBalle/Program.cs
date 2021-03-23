using System;

namespace BA.Demo.LanceurDeBalle
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Demander au lanceur de vérifier le stock
            //1:false => Demander de recharger le lanceur
            //1:true => Demander joueur si prêt
            //          2:true => lance la balle et diminuer stock
            //          2:false => Dire au joueur que l'on attend

            //stock de balle => Entier (int)
            //prêt joueur => Booléen (bool)

            int stockBalles = 1;
            string reponseJoueur;
            bool joueurPret, continuer = true;
            while (continuer)
            {
                while (stockBalles > 0)
                {
                    Console.WriteLine("Êtes-vous prêt?");
                    reponseJoueur = Console.ReadLine();
                    joueurPret = reponseJoueur == "pret" || reponseJoueur == "oui";
                    if (joueurPret)
                    {
                        Console.WriteLine("Attention, en voici une rapide!");
                        stockBalles = stockBalles - 1;
                    }
                    else
                    {
                        Console.WriteLine("Dépèche, d'autres attendent...");
                    }
                }
                Console.WriteLine("Plus de balles, veuillez recharger...");
                stockBalles = int.Parse(Console.ReadLine());
                continuer=!(stockBalles <= 0);
            }
        }
    }
}

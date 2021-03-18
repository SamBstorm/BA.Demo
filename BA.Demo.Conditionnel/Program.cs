using System;

namespace BA.Demo.Conditionnel
{
    class Program
    {
        static void Main(string[] args)
        {
            int nb1, nb2;
            string operateur;
            bool nb1IsOk, nb2IsOk;
            double result;
            Console.WriteLine("Veuillez introduire un nombre :");
            nb1IsOk = int.TryParse(Console.ReadLine(), out nb1);
            if (nb1IsOk)
            {
                Console.WriteLine("Veuillez choisir un opérateur : (+ - * /)");
                operateur = Console.ReadLine();
                if (operateur == "+" || operateur == "-" || operateur == "*" || operateur == "/")
                {
                    Console.WriteLine("Veuillez introduire un nombre :");
                    nb2IsOk = int.TryParse(Console.ReadLine(), out nb2);
                    if (nb2IsOk)
                    {
                        if(nb2 == 0 && operateur == "/")
                        {
                            Console.WriteLine("Le résultat tend vers l'infini et au delà!");
                        }
                        else
                        {
                            //Utilisation du else if
                            //if (operateur == "+")
                            //{
                            //    result = nb1 + nb2;
                            //}
                            //else if (operateur == "-")
                            //{
                            //    result = nb1 - nb2;
                            //}
                            //else if (operateur == "*")
                            //{
                            //    result = nb1 * nb2;
                            //}
                            //else
                            //{
                            //    result = (double)nb1 / nb2;
                            //}

                            //utilisation du Switch Case
                            switch (operateur)
                            {
                                case "+":
                                    result = nb1 + nb2;
                                    break;
                                case "-":
                                    result = nb1 - nb2;
                                    break;
                                case "*":
                                    result = nb1 * nb2;
                                    break;
                                default:
                                    result = (double)nb1 / nb2;
                                    break;
                            }

                            Console.WriteLine("Résultat = " + result);
                        }
                        
                    }
                    else
                    {
                        Console.WriteLine("Le second nombre est de type incorrect.");
                    }
                }
                else
                {
                    Console.WriteLine("Opérateur inconnu");
                }
            }
            else
            {
                Console.WriteLine("Le premier nombre est de type incorrect.");
            }
        }
    }
}

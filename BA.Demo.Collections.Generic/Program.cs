using System;
using System.Collections.Generic;

namespace BA.Demo.Collections.Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();  // La version générique de l'ArrayList => taille variable mais fortement typé 

            //list.Add(new object());
            list.Add(32);
            //list.Add("string");
            list.Add('\t');
            //list.Add(3.14);

            Console.WriteLine(list[0]);// ??? quel est le type de notre object? : Si List<int> alors toujours INT

            foreach (int value in list)
            {
                Console.WriteLine(value);
            }

            Dictionary<int, string> dico = new Dictionary<int, string>();  // La version générique du HashTable => taille variable mais fortement typé 
            dico.Add(42, "Valeur universelle");
            dico.Add(666, "Nombre du diable");
            //dico.Add("Salut", "Les amis");
            //dico.Add(3.14, 3);

            foreach (KeyValuePair<int, string> kvp in dico)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value}");
            }

            Queue<string> fileDattente = new Queue<string>();
            fileDattente.Enqueue("Sophie");
            fileDattente.Enqueue("Farid");
            fileDattente.Enqueue("Mago");
            fileDattente.Enqueue("James");
            fileDattente.Enqueue("Mohammed");

            Stack<string> pileDossier = new Stack<string>();

            int length = fileDattente.Count;

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"Cela va être au tour de {fileDattente.Peek()} de déposer son dossier");
                pileDossier.Push(fileDattente.Dequeue());
            }
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"Traitement du dossier de {pileDossier.Pop()}.");
            }
        }
    }
}

using System;
using System.Collections;

namespace BA.Demo.Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            Console.WriteLine("Combien de valeurs voulez-vous enregistrer?");
            int nbValeurs = int.Parse(Console.ReadLine());
            for (int i = 0; i < nbValeurs; i++)
            {
                Console.WriteLine($"Veuillez encoder la valeur de la case {i + 1}:");
                Console.WriteLine("Quel type de valeur encoder? string or int");
                bool isString = Console.ReadLine() == "string";
                if (isString)
                {
                    list.Add(Console.ReadLine());
                }
                else
                {
                    list.Add(int.Parse(Console.ReadLine()));
                }
            }
            foreach (object valeur in list)
            {
                Console.WriteLine((int)valeur * 2);
            }

            Hashtable dico = new Hashtable();
            dico.Add(3, "Riri");
            dico.Add("Riri", 6);
            dico.Add("Fifi", "Riri");
            Console.WriteLine(dico["Riri"]);
            Console.WriteLine(dico["Fifi"]);
            Console.WriteLine(dico[0]);
            dico.Remove("Riri");
            dico.Add("key", null);
            dico["key"] = "clé";

            foreach (DictionaryEntry de in dico)
            {
                Console.WriteLine($"{de.Key} {de.Value}");
            }

            Queue q = new Queue();  // Queue de file d'attente => le premier qui rentre dans la file, est le premier qui sort
            Stack s = new Stack();  // Stack pile d'assiette => le premier qui rentre dans la pile, est le dernier qui sort

            q.Enqueue("Première valeur");
            q.Enqueue("Seconde valeur");
            q.Enqueue("Dernière valeur");

            s.Push("Première valeur");
            s.Push("Seconde valeur");
            s.Push("Dernière valeur");

            Console.WriteLine(q.Dequeue());
            Console.WriteLine($"Nombre d'élément dans la Queue : {q.Count}");

            Console.WriteLine(s.Pop());
            Console.WriteLine($"Nombre d'élément dans le Stack : {s.Count}");

            Console.WriteLine(q.Peek());
            Console.WriteLine($"Nombre d'élément dans la Queue : {q.Count}");

            Console.WriteLine(s.Peek());
            Console.WriteLine($"Nombre d'élément dans le Stack : {s.Count}");

            q.Enqueue(q.Dequeue());
        }
    }
}

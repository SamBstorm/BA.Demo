using System;

namespace BA.Demo.Array
{
    class Program
    {
        static void Main(string[] args)
        {
            const int TAILLE = 60;
            int[] ints = new int[TAILLE];
            int nbElems = 0;
            bool newRecord = true;
            while (nbElems < TAILLE && newRecord)
            {
                ints[nbElems] = int.Parse(Console.ReadLine());
                nbElems++;
                Console.WriteLine("Voulez-vous encoder une nouvelle valeur ?");
                newRecord = Console.ReadLine() == "oui";

            }
            int index = 0;
            while (index < nbElems)
            {
                Console.Write($"{ints[index]} - ");
                index = index + 1; //index++;
            }
            Console.WriteLine($"{ints[0]}|{ints[1]}|{ints[2]}|{ints[3]}|{ints[4]}|{ints[5]}|{ints[6]}");
        }
    }
}

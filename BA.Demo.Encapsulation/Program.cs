using System;

namespace BA.Demo.Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Identification id = new Identification();
            id.Email = "sam@fait.rire";
            id.MotDePasse = "Test1234=";
            //Console.WriteLine(id.MotDePasse); // ecriture seule grace au private get ou bien au manque get
            Identification id2 = id;
            id2.MotDePasse = "1234";
            Console.WriteLine(id.IsOk());
            Console.WriteLine(id2.IsOk());
        }
    }
}

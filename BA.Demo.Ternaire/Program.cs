using System;

namespace BA.Demo.Ternaire
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("012345678910".Substring(10));
            int i = 5;
            string result = (i > 5) ? "Plus grand" : ((i < 5) ? "Plus petit" : "i est égal à 5");
            Console.WriteLine(result);
        }
    }
}

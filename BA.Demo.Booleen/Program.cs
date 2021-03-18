using System;

namespace BA.Demo.Booleen
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool maValeur1 = true;
            //bool maValeur2 = true;

            //Console.WriteLine("And - &&");
            //Console.WriteLine($"V1 :\t {maValeur1} \tV2 :\t {maValeur2}\tResult :\t{maValeur1 && maValeur2}");
            //Console.WriteLine($"V1 :\t {!maValeur1} \tV2 :\t {maValeur2}\tResult :\t{!maValeur1 && maValeur2}");
            //Console.WriteLine($"V1 :\t {maValeur1} \tV2 :\t {!maValeur2}\tResult :\t{maValeur1 && !maValeur2}");
            //Console.WriteLine($"V1 :\t {!maValeur1} \tV2 :\t {!maValeur2}\tResult :\t{!maValeur1 && !maValeur2}");
            //Console.WriteLine("Or - ||");
            //Console.WriteLine($"V1 :\t {maValeur1} \tV2 :\t {maValeur2}\tResult :\t{maValeur1 || maValeur2}");
            //Console.WriteLine($"V1 :\t {!maValeur1} \tV2 :\t {maValeur2}\tResult :\t{!maValeur1 || maValeur2}");
            //Console.WriteLine($"V1 :\t {maValeur1} \tV2 :\t {!maValeur2}\tResult :\t{maValeur1 || !maValeur2}");
            //Console.WriteLine($"V1 :\t {!maValeur1} \tV2 :\t {!maValeur2}\tResult :\t{!maValeur1 || !maValeur2}");
            //Console.WriteLine("XOr - ^");
            //Console.WriteLine($"V1 :\t {maValeur1} \tV2 :\t {maValeur2}\tResult :\t{maValeur1 ^ maValeur2}");
            //Console.WriteLine($"V1 :\t {!maValeur1} \tV2 :\t {maValeur2}\tResult :\t{!maValeur1 ^ maValeur2}");
            //Console.WriteLine($"V1 :\t {maValeur1} \tV2 :\t {!maValeur2}\tResult :\t{maValeur1 ^ !maValeur2}");
            //Console.WriteLine($"V1 :\t {!maValeur1} \tV2 :\t {!maValeur2}\tResult :\t{!maValeur1 ^ !maValeur2}");

            Console.WriteLine("Différence entre && et &");
            Console.WriteLine(returnFalse() && returnTrue());
            Console.WriteLine("----------------------");
            Console.WriteLine(returnFalse() & returnTrue());

            Console.WriteLine("Différence entre || et |");
            Console.WriteLine(returnTrue() || returnTrue());
            Console.WriteLine("----------------------");
            Console.WriteLine(returnTrue() | returnTrue());
        }

        static bool returnTrue()
        {
            Console.WriteLine("Je dois retourner un 'True'.");
            return true;
        }

        static bool returnFalse()
        {
            Console.WriteLine("Je dois retourner un 'False'.");
            return false;
        }
    }
}

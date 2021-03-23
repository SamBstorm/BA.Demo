using System;

namespace BA.Demo.ConversionEtSuffixes
{
    class Program
    {
        static void Main(string[] args)
        {
            double d = 5;
            int diviseur = 2;
            var result = (decimal)(d / diviseur);
            var result2 = 5F / 2;

            //decimal != float/double
            //valeur d'approximation 
            float f = 4.123F;
            double dou = 4.123;
            Console.WriteLine(f + 0.1F + 0.1F + 0.1F + 0.1F);
            Console.WriteLine(dou + 0.1 + 0.1 + 0.1 + 0.1);

            //valeur décimal
            decimal m = 4.123M; //La virgule est 3 chiffres derrières
            Console.WriteLine(m + 0.1M + 0.1M + 0.1M + 0.1M);
            int i = 4123;   //Faire une /1000 pour obtenir la même valeur
            Console.WriteLine(((i + 100 + 100 + 100 + 100) / 1000M));
        }
    }
}

using System;

namespace BA.Demo.Coalesce
{
    class Program
    {
        static void Main(string[] args)
        {
            string result;
            string s = null, t = null, u = null;
            //result = s ?? t ?? u ?? "Valeur non null";

            if (s != null) result = s;
            else if (t != null) result = t;
            else if (u != null) result = u;
            else result = "Valeur non null";
            Console.WriteLine(result);

            //result = s ?? t ?? u ; //Le coalesce, si aucune correspondance, retourne toujours la dernière valeur, même si elle-même est null.
        }
    }
}

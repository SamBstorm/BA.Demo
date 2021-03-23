using System;

namespace BA.Demo.Methodes
{
    class Program
    {
        static void Main(string[] args)
        {
            MesMethodes m;
            m.IsFirstTime = true;
            m.Nom = null;
            m.Salutation();
            m.Nom = m.RecupererNom();
            m.Salutation();
        }
    }
}

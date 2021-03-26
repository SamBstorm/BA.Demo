using System;
using System.Collections.Generic;
using System.Text;

namespace BA.Demo.Heritage
{
    public class Bateau: Transport
    {
        public new void SeDeplacer()
        {
            base.SeDeplacer();
            Console.WriteLine("Je vogue sur l'eau.");
        }
    }
}

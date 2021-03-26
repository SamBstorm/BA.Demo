using System;
using System.Collections.Generic;
using System.Text;

namespace BA.Demo.Heritage
{
    public sealed class Roadster : Voiture
    {
        public bool ToitOuvert { get; set; }

        public void OuvrirToit()
        {
            if (ToitOuvert) return;
            Console.WriteLine("J'ouvre le toit");
            ToitOuvert = true;
        }
        public void FermerToit()
        {
            if (!ToitOuvert) return;
            Console.WriteLine("Je ferme le toit");
            ToitOuvert = false;
        }

        public new void SeDeplacer()
        {
            base.SeDeplacer();
            if (ToitOuvert) Console.WriteLine("Les cheveux au vent!");
            else Console.WriteLine("Sans craindre la pluie.");
        }
    }
}

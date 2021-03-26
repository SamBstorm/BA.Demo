using System;
using System.Collections.Generic;
using System.Text;

namespace BA.Demo.Heritage
{
    public class Transport
    {
        public int NbPassager { get; set; }
        public void SeDeplacer()
        {
            Console.WriteLine("Je me déplace.");
        }
    }
}

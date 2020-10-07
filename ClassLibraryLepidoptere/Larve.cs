using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibraryLepidoptere
{
    public class Larve : StadeDEvolution
    {
        public override StadeDEvolution DonneTonProchainEtat()
        {
            return new Chenille();
        }

        public override bool SeDeplacer()
        {
            Console.WriteLine("elle bouge");
            return false;
        }
    }
}
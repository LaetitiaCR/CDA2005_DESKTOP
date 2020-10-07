using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibraryLepidoptere
{
    public class Chenille : StadeDEvolution
    {
        public override StadeDEvolution DonneTonProchainEtat()
        {
            return new Chrysalide();
        }

        public override bool SeDeplacer()
        {
            Console.WriteLine("Je rampe");
            return true;
        }
    }
}
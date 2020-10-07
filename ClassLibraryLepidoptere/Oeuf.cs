using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibraryLepidoptere
{
    public class Oeuf : StadeDEvolution
    {
        public override StadeDEvolution DonneTonProchainEtat()
        {
            return new Larve();
        }

        public override bool SeDeplacer()
        {
            Console.WriteLine("Je bouge pas");
            return false;
        }
    }
}
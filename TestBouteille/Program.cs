using ClassLibraryBouteille;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBouteille
{
    class Program
    {
        static void Main(string[] args)
        {
            Bouteille b = new Bouteille(false, 100, 100);
            Bouteille bCopier = new Bouteille(b);
            bool elleEstOuvert = bCopier.Ouvert;
            bCopier.Ouvert = false;
        }
    }
}

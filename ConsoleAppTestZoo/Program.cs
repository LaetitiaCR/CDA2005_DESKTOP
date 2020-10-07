using ClassLibraryZoo.Animaux;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTestZoo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<AnimalDuZoo> mesAnimauxDuZoo = new List<AnimalDuZoo>();
            mesAnimauxDuZoo.Add(new Lapin());
            mesAnimauxDuZoo.Add(new Lapin());
            mesAnimauxDuZoo.Add(new Lion());
            mesAnimauxDuZoo.Add(new Perroquet());

            foreach(AnimalDuZoo a in mesAnimauxDuZoo)
            {
                a.SeDeplacer();
            }

            //mais que fait le gardien?
        }
    }
}

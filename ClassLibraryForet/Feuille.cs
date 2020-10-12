using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForet
{
    public class Feuille
    {
        int nbNervures;

        public Feuille(int nbNervures)
        {
            this.nbNervures = nbNervures;
        }

        public int NbNervures { get => nbNervures; 
            //set => nbNervures = value; 
        }

        public void Tomber()
        {
            Console.WriteLine("Je tombe");
        }
    }
}

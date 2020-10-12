using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForet
{
    public class Arbre
    {
        int hauteur;
        private List<Feuille> feuilles;

        public Arbre(int hauteur)
        {
            this.hauteur = hauteur;
            // a finir
        }

        public Arbre(int hauteur, List<Feuille> feuilles) //ouvre porte aggregation
        {
            //a faire
        }

         public void AddFeuille(Feuille f)
        {
            //a faire
        }

        public int Hauteur { get => hauteur; 
            //set => hauteur = value; 
        }
    }
}

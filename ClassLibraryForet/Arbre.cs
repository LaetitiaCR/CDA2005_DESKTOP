using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForet
{

    public class Arbre: List<Feuille>
    {
        int hauteur;

        public Arbre(int hauteur)
        {
            this.hauteur = hauteur;
            feuilles = new List<Feuille>();

        }

        //public Arbre(int hauteur, List<Feuille> _feuilles) //ouvre porte aggregation
        //{
        //    this.hauteur = hauteur;
        //    feuilles = _feuilles;
        //}

        private void AddFeuille(Feuille f)
        {
            this.Feuilles.Add(f);
        }

        public void AddFeuille(int _nbNervures, EnumCouleur _couleurFeuille, EnumFormeFeuille _formeFeuille)
        {
            this.AddFeuille(new Feuille(_nbNervures, _couleurFeuille, _formeFeuille));
        }

        public int Hauteur
        {
            get => hauteur;
            //set => hauteur = value; 
        }

       
        public override string ToString()
        {
            String resu = base.ToString() + " hauteur=" + hauteur;
            foreach (Feuille f in Feuilles)
            {
                resu = resu + "\n" + f.ToString();
            }
            return resu;
        }

        public void PasserEnAutomne()
        {
            foreach (Feuille f in feuilles)
            {
                f.PrendsTesCouleursDAutomne();
            }
        }
    }
}

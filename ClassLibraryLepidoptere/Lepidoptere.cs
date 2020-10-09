using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLepidoptere
{
    public class Lepidoptere
    {
        private StadeDEvolution monStadeCourant;
        private DateTime dateDeNaissance;

        public Lepidoptere()
        {
            monStadeCourant = new Oeuf();
            DateDeNaissance = DateTime.Now;

        }

        public DateTime DateDeNaissance 
        { 
            get => dateDeNaissance;
            private set
            {
                if (value <= DateTime.Now) //regle metier
                {
                    dateDeNaissance = value;
                }
                else
                {
                    throw new FormatException("on est ds le future");
                }
            }
        }

        public bool SeDeplacer()
        {
            return monStadeCourant.SeDeplacer();
        }

        public void SeMetamorphoser()
        {
            monStadeCourant=monStadeCourant.DonneTonProchainEtat();
        }
    }
}

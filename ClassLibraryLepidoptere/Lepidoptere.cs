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
            dateDeNaissance = DateTime.Now;

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

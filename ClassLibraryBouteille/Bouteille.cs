using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBouteille
{
    public class Bouteille:Object
    {
        private bool ouvert;
        private float volumeActuelEnCL;
        private float volumeMaximumEnCL;

        //public bool Ouvert
        //{
        //    get => ouvert;
        //    //set => ouvert = value; 
        //}

        public bool Ouvert
        {
            get
            {
                return ouvert;
            }
            //set 
            //{
            //    ouvert = value;
            //}
        }


        //constructeur par defaut
        //public Bouteille()
        //{
        //    ouvert = false;
        //    volumeActuelEnCL = 10;
        //    volumeMaximumEnCL = 10;
        //}

        public Bouteille():this(false,10,10)
        {
        }

        //constructeur classique
        public Bouteille(bool _ouvert,float _volumeActuelEnCL,float _volumeMaximumEnCL)
        {
            ouvert = _ouvert;
            volumeActuelEnCL = _volumeActuelEnCL;
            volumeMaximumEnCL = _volumeMaximumEnCL;
        }

        //constructeur par recopie
        //public Bouteille(Bouteille _bouteilleARecopier)
        //{
        //    ouvert = _bouteilleARecopier.ouvert;
        //    volumeActuelEnCL = _bouteilleARecopier.volumeActuelEnCL;
        //    volumeMaximumEnCL = _bouteilleARecopier.volumeMaximumEnCL;
        //}

        public Bouteille(Bouteille _bouteilleARecopier)
            :this(_bouteilleARecopier.ouvert,_bouteilleARecopier.volumeActuelEnCL,_bouteilleARecopier.volumeMaximumEnCL)
        {
        }

        public void Ouvrir()
        {
            throw new System.NotImplementedException();
        }

        public void Fermer()
        {
            throw new System.NotImplementedException();
        }

        public void Remplir(bool quantite)
        {
            throw new System.NotImplementedException();
        }

        public void Vider(bool quantite)
        {
            throw new System.NotImplementedException();
        }
    }
}

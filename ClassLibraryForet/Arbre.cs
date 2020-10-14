using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForet
{

    public class Arbre: IList<Feuille>
    {
        int hauteur;
        private List<Feuille> feuilles;

        public List<Feuille> Feuilles {
            get => feuilles; 
            //set => feuilles = value; 
        }

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
            this.AddFeuille(new Feuille( _nbNervures,  _couleurFeuille,  _formeFeuille));
        }

        public int Hauteur { get => hauteur; 
            //set => hauteur = value; 
        }

        public int Count { get => feuilles.Count;}

        public bool IsReadOnly => throw new NotImplementedException();

        Feuille IList<Feuille>.this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        //redefinir l'operateur [] sur la classe Arbre
        public Feuille this[int index]
        {
            get { return feuilles[index]; }
            // set { feuilles[index] = value; }
        }

        



        public override string ToString()
        {
            String resu = base.ToString() + " hauteur=" + hauteur ;
            foreach (Feuille f in Feuilles)
            {
                resu = resu + "\n"+ f.ToString();
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

        public int IndexOf(Feuille item)
        {
            return feuilles.IndexOf(item);
        }

        public void Insert(int index, Feuille item)
        {
            feuilles.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        public void Add(Feuille item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(Feuille item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(Feuille[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(Feuille item)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<Feuille> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}

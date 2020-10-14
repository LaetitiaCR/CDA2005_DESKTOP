using ClassLibraryForet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTestArbreDansForet
{
    class Program
    {
        static void Main(string[] args)
        {
            Feuille f = new Feuille(6, EnumCouleur.Orange, EnumFormeFeuille.crénelé);


            //creation d'un arbre
            Arbre chene1 = new Arbre(10);
            chene1.AddFeuille(6,EnumCouleur.Vert, EnumFormeFeuille.crénelé);
            chene1.AddFeuille(6, EnumCouleur.Vert, EnumFormeFeuille.crénelé);
            //affichage d'un arbre
            Console.WriteLine(chene1.ToString());

            //faire passer l'arbre en automne
            chene1.PasserEnAutomne();
            //affichage un arbre
            Console.WriteLine(chene1.ToString());


            //-------------------------- Cerise sur le gateau --------------------------

            //tomber les feuilles de l'arbre //appeler chaque methode Tomber de l'arbre

            foreach (Feuille ff in chene1) 
            {
            }

            for (int i = 0; i < chene1.Count; i++) 
            {
                Feuille f2 = chene1[i]; 


            }

            //chene1[0] = new Feuille(6, EnumCouleur.Vert, EnumFormeFeuille.triangulaire);// pas possible car readonly

            //respecte le contrat IList.. qui n'assure d etre une liste du Framemwork
        }
    }
}

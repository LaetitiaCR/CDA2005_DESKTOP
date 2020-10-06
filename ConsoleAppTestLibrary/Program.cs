using ClassLibrary3;
using ClassLibrary3.Temps;
using System;

namespace ConsoleAppTestLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Pluie p;

            //methode d'instance
            // Console c = new Console();
            // c.WriteLine("tutu");

            //methode de classes (classe Console)
            // Console.WriteLine("tutu");

            string s;
            String s2;

            FilleDeObject f = new FilleDeObject();
            string s= f.ToString();

        }
    }
}

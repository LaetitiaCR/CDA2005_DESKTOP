using ClassLibraryRealisationImpliciteExplicite;
using System;

namespace ConsoleAppTestImpliciteExplicite
{
    class Program
    {
        static void Main(string[] args)
        {
            Personne p = new Personne(5);
            ((ClassLibraryRealisationImpliciteExplicite.Interface1)p).Method();
            ((ClassLibraryRealisationImpliciteExplicite.Contrats.Interface1)p).Method();
            ((ICloneable)p).Clone();
        }
    }
}

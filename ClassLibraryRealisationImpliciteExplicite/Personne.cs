using System;

namespace ClassLibraryRealisationImpliciteExplicite
{
    public class Personne: ICloneable, Interface1, ClassLibraryRealisationImpliciteExplicite.Contrats.Interface1
    {
        int age;

        public Personne(int age)
        {
            this.age = age;
        }

        public Personne(Personne personneARecopier)
        {
            this.age = personneARecopier.age;
        }

        object Interface1.Clone()
        {
            throw new NotImplementedException();
        }

        object ICloneable.Clone()
        {
            throw new NotImplementedException();
        }

        void Interface1.Method()
        {
            Console.WriteLine("le premier");
        }

        void Contrats.Interface1.Method()
        {
            Console.WriteLine("le deuxieme");
        }
    }
}

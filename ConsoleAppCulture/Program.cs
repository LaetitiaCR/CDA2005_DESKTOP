using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCulture
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo cultureLocal = CultureInfo.CurrentCulture;
            //Imposer une autre culture
            //CultureInfo.CurrentCulture = new CultureInfo("en-EN");
            
            //-------------------parsage d'un double--------------------------
            try
            {
                Double ledouble = Double.Parse("12.5");
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            double d2=12;
            bool ok = Double.TryParse("12,5",out d2);


            //-------------------parsage d'un datetime--------------------------
            DateTime dateARecupere;

            try
            {
                //parse date sur ma culture de l'exe
                dateARecupere = DateTime.Parse("19/10/2020");
                //parse date pour une autre culture
                dateARecupere = DateTime.Parse("19/10/2020", new CultureInfo("en-EN"));
                //parse date pour
                dateARecupere = DateTime.Parse("19 /10/ 2020 12:12:00", new CultureInfo("en-EN"),DateTimeStyles.AllowInnerWhite);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            //Comme avant pour Parse avec catch gere et 2 sortis (parse reussi et date parse)
            //bool successful = DateTime.TryParse(...);

           

            //Comme avant pour TryParse, avec un des formats imposes
            //null pour culture signale que l' on prend pas en compte la culture
            bool successful = DateTime.TryParseExact("20201205", "yyyyMMdd HH:mm", null,System.Globalization.DateTimeStyles.AllowLeadingWhite,out dateARecupere);
            
        }


    }
}

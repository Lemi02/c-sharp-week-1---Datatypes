using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Er is geen verschil tussen String en string
            String EersteString = "Eerste";
            string TweedeString = "Tweede";
            var DerdeString = "derde";

            char EersteChar = 'A';
            var TweedeChar = 'B';

            int EersteInt = 5;
            var TweedeInt = 6;

            //maximale waarde van de int, int is zowel positief als negatief(signed)
            int GroteInt = int.MaxValue;
            Console.WriteLine(GroteInt.ToString());
            //maximale waarde van de unsigned int.
            uint GrotePositieveInt = uint.MaxValue;
            Console.WriteLine(GrotePositieveInt.ToString());

            short KleinerGetal = short.MaxValue;
            Console.WriteLine(KleinerGetal.ToString());

            //voor echt grote getallen kan je ook nog de ulong gebruiken(unsigned)
            long GroterGetal = long.MaxValue;
            Console.WriteLine(GroterGetal.ToString());

            //een kommagetal wil C# automatisch in een double plaatsen. Je kan een float forceren door een f achter de kommawaarde te zetten
            float KommaGetal = 3.14f;
            var KommaGetal2 = 3.14f;

            //in principe wordt bij de var van een kommagetal automatisch een double gemaakt voor 100% zekerheid plaats je een d erachter
            double KommaGetal3 = 3.14;
            var KommaGetal4 = 3.14d;

            // een aantal manieren om een boolean te definieren
            bool WaarOfNietWaar = true;
            var NietWaarOfWaar = false;
            Boolean WaarOfNiet = true;









            




            Console.ReadLine();
        }
    }
}

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
            String eersteString = "Eerste";
            string tweedeString = "Tweede";
            var derdeString = "derde";

            char eersteChar = 'A';
            var tweedeChar = 'B';

            int eersteInt = 5;
            var tweedeInt = 6;

            //maximale waarde van de int, int is zowel positief als negatief(signed)
            int groteInt = int.MaxValue;
            Console.WriteLine(groteInt.ToString());
            //maximale waarde van de unsigned int.
            uint grotePositieveInt = uint.MaxValue;
            Console.WriteLine(grotePositieveInt.ToString());

            short kleinerGetal = short.MaxValue;
            Console.WriteLine(kleinerGetal.ToString());

            //voor echt grote getallen kan je ook nog de ulong gebruiken(unsigned)
            long groterGetal = long.MaxValue;
            Console.WriteLine(groterGetal.ToString());

            //een kommagetal wil C# automatisch in een double plaatsen. Je kan een float forceren door een f achter de kommawaarde te zetten
            float kommaGetal = 3.14f;
            var kommaGetal2 = 3.14f;

            //in principe wordt bij de var van een kommagetal automatisch een double gemaakt voor 100% zekerheid plaats je een d erachter
            double kommaGetal3 = 3.14;
            var kommaGetal4 = 3.14d;

            // een aantal manieren om een boolean te definieren
            bool waarOfNietWaar = true;
            var nietWaarOfWaar = false;
            Boolean waarOfNiet = true;









            




            Console.ReadLine();
        }
    }
}

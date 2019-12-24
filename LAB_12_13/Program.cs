using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_12_13
{
    class Program
    {
        static void Main(string[] args)
        {
            /*FlstCollection flats = new FlstCollection();
            flats.Add(new Flat("la", 12.5, 3));
            flats.Add(new Flat("la2", 15, 4));
            flats.Add(new Flat("la3", 10, 2));

            var gg = from flt in flats orderby flt.Square orderby flt.RoomsCount select flt;

            foreach (Flat item in gg)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            var sortFlats = flats.OrderBy((f) => f.Square);
            foreach(Flat item in sortFlats)
            {
                Console.WriteLine(item);
            }*/

            //CardDeck cardDeck = new CardDeck();
            //Console.ReadLine();
            //cardDeck.MixCards();

            for(int i = 0; i != 100; ++i)
            {
                Console.WriteLine(Environment.TickCount);

            }


            Console.ReadKey();
        }
    }
}

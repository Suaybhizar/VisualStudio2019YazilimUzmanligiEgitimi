using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmlakciLib;

namespace EmlakciApp
{
    class Program
    {
        static void Main(string[] args)
        {

            IEv[] evler =
            {
                new KiralikEv(3, 4, "Yenimahalle", 100, 1500,1500),
                new SatilikEv(4,2,"etlik",90,3000000)
            };

            foreach (var ev in evler)
            {

                //if (ev is KiralikEv)
                //    Console.WriteLine("Kiralık Ev");
                //else
                //    Console.WriteLine("Satılık Ev");

                Console.WriteLine("--------------{0}-------------", ev.EvTipi);

                Console.WriteLine(ev.EvBilgileriniGetir());
            }





            Console.ReadKey();
        }
    }
}

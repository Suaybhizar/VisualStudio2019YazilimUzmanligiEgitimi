using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern;
using static FactoryPattern.RaporFabrika;

namespace FactoryPatternTTest
{
    class Program
    {
        static void Main(string[] args)
        {
            IRapor rapor = RaporFabrika.RaporUret<XmlRapor>();
            rapor.Yazdir();

            Console.ReadKey();
        }
    }
}

using FactoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternTTest
{
    public class XmlRapor : IRapor
    {
        public void Yazdir()
        {
            Console.WriteLine("Xml rapor yazdırıldı. ");
        }
    }
}

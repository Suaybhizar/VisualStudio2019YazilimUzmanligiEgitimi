using FactoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternTTest
{
    class ExcelRapor : IRapor
    {
        public void Yazdir()
        {
            Console.WriteLine("Excel rapor yazdırıldı. ");
        }
    }
}



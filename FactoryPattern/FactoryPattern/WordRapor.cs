using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class WordRapor : IRapor
    {
        public void Yazdir()
        {
            Console.WriteLine("Word rapor yaxdırıldı. ");
        }
    }

}

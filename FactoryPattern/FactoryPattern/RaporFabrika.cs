using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public static class RaporFabrika
    {
        //open closed prensibi
        //bir sınıf değişikliği kapalı,geliştirmeye açık olacak


        public static IRapor RaporUret<T>()
            where T:IRapor,new()
        {
            IRapor rapor = null;
            rapor = new T();
            return rapor;
        }
    }
}

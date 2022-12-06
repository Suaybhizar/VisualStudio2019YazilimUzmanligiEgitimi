using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErisimBelirleyicileri
{
    class Program
    {
        static void Main(string[] args)
        {
            Kisi kisi = new Kisi();
            
        }
    }

    public abstract class Kisi
    {
       

        protected internal int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
    }

    public class Ogrenci : Kisi
    {
       
       
        public string Sinif { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UzaktanEgitim.CustomControls
{
    [AttributeUsage(AttributeTargets.Property)] //attributeler bu kod ile sadece property ler üzerinde çalışmasını sağlayacak
    public class KolonAttribute : Attribute
    {
        public bool Gorunur { get; set; } = true;
        public string Baslik { get; set; }
    }
}

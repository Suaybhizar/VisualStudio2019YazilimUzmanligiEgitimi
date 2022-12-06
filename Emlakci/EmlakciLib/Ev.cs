using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakciLib
{
    public interface IEv
    {
        int Odasayisi { get; set; }
        int Katno { get; set; }
        string Semt { get; set; }
        double Alan { get; set; }
        string EvTipi { get; }

        string EvBilgileriniGetir();
    }
}

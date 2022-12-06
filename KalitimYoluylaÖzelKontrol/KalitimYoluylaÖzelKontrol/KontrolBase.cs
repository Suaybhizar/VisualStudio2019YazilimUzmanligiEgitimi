using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalitimYoluylaÖzelKontrol
{
    public abstract class KontrolBase:Button
    {
        public KontrolBase()
        {
            this.Font = new Font("Verdana", 10F);
            this.Height = 35;
        }
    }
}

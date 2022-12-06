using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalitimYoluylaÖzelKontrol
{
    public class SilButon : KontrolBase
    {
        public SilButon()
        {
            //DRY Dont Repeat Yourself
            this.Width = 130;
            // this.Height = 35;
            this.BackColor = Color.Maroon;
            this.ForeColor = Color.White;
            //this.Font = new Font("Verdana", 10F);
            this.Text = "Sil";
        }
    }
}

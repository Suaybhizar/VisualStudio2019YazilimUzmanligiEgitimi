using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KodTarafındaKontroller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            //DRY Dont Repeat Your Self
            string seciliEleman = cmbKontrolTuru.SelectedItem.ToString();

            Control ctl = null;

            if (seciliEleman == "Button")

                ctl = new Button();


            else if (seciliEleman == "CheckBox")

                ctl = new CheckBox();


            else if (seciliEleman == "RadioButton")

                ctl = new RadioButton();


            else

                ctl = new TextBox();

            int x = new Random().Next(0, this.Width/2);
            int y = new Random().Next(0, this.Height/2);
            ctl.Location = new Point(x,y);

            this.Controls.Add(ctl);

        }
    }
}

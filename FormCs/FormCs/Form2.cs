using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormCs
{
    public partial class Form2 : Form
    {
        public Form2(string mesaj)
        {
            InitializeComponent();
            textBox1.Text = mesaj;
        }
        public Form2(int genislik)
        {
            InitializeComponent();
            this.Width = genislik;
        }
        public Form2()
        {
            InitializeComponent();

        }
    }
}

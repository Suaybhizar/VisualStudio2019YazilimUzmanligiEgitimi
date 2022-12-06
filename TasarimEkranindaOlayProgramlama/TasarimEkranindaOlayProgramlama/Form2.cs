using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TasarimEkranindaOlayProgramlama
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void ButtonTiklandi(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            MessageBox.Show(btn.Text + " tıklandı");
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TextBox veya Button tıklandı");
        }
    }
}

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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnButonKaldir_Click(object sender, EventArgs e)
        {
            for (int i=this.Controls.Count-1;i>=0;i-- )
            {
                if (this.Controls[i] is Button&&this.Controls[i].Tag==null)
                    this.Controls.Remove(this.Controls[i]);

            }
        }

        private void btnCheckBoxKaldir_Click(object sender, EventArgs e)
        {
            for (int i = this.Controls.Count - 1; i >= 0; i--)
            {
                if (this.Controls[i] is CheckBox)
                    this.Controls.Remove(this.Controls[i]);

            }
        }

        private void btnRadioBoxKaldir_Click(object sender, EventArgs e)
        {
            for (int i = this.Controls.Count - 1; i >= 0; i--)
            {
                if (this.Controls[i] is RadioButton)
                    this.Controls.Remove(this.Controls[i]);

            }
        }

        private void btnComboBoxKaldir_Click(object sender, EventArgs e)
        {
            for (int i = this.Controls.Count - 1; i >= 0; i--)
            {
                if (this.Controls[i] is ComboBox)
                    this.Controls.Remove(this.Controls[i]);

            }
        }
    }
}

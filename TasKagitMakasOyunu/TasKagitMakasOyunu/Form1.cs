using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TasKagitMakasOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //dry dont repeat yourself

        void BilgisayarSkorArtir()
        {
            int skor = Convert.ToInt32(lblBilgisayarSkor.Text);
            lblBilgisayarSkor.Text = (++skor).ToString();
        }
        void OyuncuSkorArtir()
        {
            int skor = Convert.ToInt32(lblOyuncuSkor.Text);
            lblOyuncuSkor.Text = (++skor).ToString();
        }


        private void resimTas_Click(object sender, EventArgs e)
        {
            Resim tiklananResim = sender as Resim;
            int rasgeleSecim = new Random().Next(DateTime.Now.Millisecond,1000)%3;
            resimBigisayarınSecimi.ResimTuru = (ResimTuru)rasgeleSecim;
            resimOyuncuSecimi.ResimTuru = tiklananResim.ResimTuru;

            //Karşılaştırmaları yapalım

            if (tiklananResim.ResimTuru == ResimTuru.Kagit)//ben kağıt seçtim
            {
                if (resimBigisayarınSecimi.ResimTuru == ResimTuru.Makas)//bilgisayar makas
                {
                    BilgisayarSkorArtir();
                }
                else if(resimBigisayarınSecimi.ResimTuru==ResimTuru.Tas)//Bilgisayar taş seçti
                {
                    OyuncuSkorArtir();
                }
            }
            else if(tiklananResim.ResimTuru==ResimTuru.Makas)//ben makası seçti
            {
                if (resimBigisayarınSecimi.ResimTuru == ResimTuru.Kagit)//bilgisayar kagit seçti
                {
                    OyuncuSkorArtir();
                }
                else if (resimBigisayarınSecimi.ResimTuru == ResimTuru.Tas)
                {
                    BilgisayarSkorArtir();
                }
            }
            else//ben Taşı seçtim
            {
                if (resimBigisayarınSecimi.ResimTuru == ResimTuru.Kagit)//bilgisayar kagit seçti
                {
                    BilgisayarSkorArtir();
                }
                else if (resimBigisayarınSecimi.ResimTuru == ResimTuru.Makas)
                {
                    OyuncuSkorArtir();
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TasKagitMakasOyunu.Properties;

namespace TasKagitMakasOyunu
{
    public enum ResimTuru
    {
        Tas,
        Kagit,
        Makas,
        Bos
    }
    public class Resim : PictureBox
    {
        ResimTuru resimTuru;

        public Resim()
        {
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            ResimTuru = ResimTuru.Bos;
            this.Width = 110;
            this.Height = 105;
            this.BorderStyle = BorderStyle.FixedSingle;
        }

        public ResimTuru ResimTuru
        {
            get
            {
                return resimTuru;
            }

            set
            {
                resimTuru = value;
                //Kutuda yer alan resim türüne ait resmi yükledik.
                switch (value)
                {
                    case ResimTuru.Tas:
                        this.Image = Resources.tas;
                        break;
                    case ResimTuru.Kagit:
                        this.Image = Resources.kagit;
                        break;
                    case ResimTuru.Makas:
                        this.Image = Resources.makas;
                        break;
                    case ResimTuru.Bos:
                        this.Image = null;
                        break;
                    default:
                        break;
                }

            }
        }
    }
}

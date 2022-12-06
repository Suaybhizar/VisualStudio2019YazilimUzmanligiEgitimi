
namespace WinFormUserControlPratic_2
{
    partial class ucKisi
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBaslik = new System.Windows.Forms.Label();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.lblOgrenimDuzeyi = new System.Windows.Forms.Label();
            this.pbResim = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.ForeColor = System.Drawing.Color.White;
            this.lblBaslik.Location = new System.Drawing.Point(180, 15);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(500, 45);
            this.lblBaslik.TabIndex = 1;
            this.lblBaslik.Text = "Başlık";
            // 
            // lblAciklama
            // 
            this.lblAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAciklama.ForeColor = System.Drawing.Color.White;
            this.lblAciklama.Location = new System.Drawing.Point(180, 60);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(500, 62);
            this.lblAciklama.TabIndex = 2;
            this.lblAciklama.Text = "Açıklama";
            // 
            // lblOgrenimDuzeyi
            // 
            this.lblOgrenimDuzeyi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgrenimDuzeyi.ForeColor = System.Drawing.Color.White;
            this.lblOgrenimDuzeyi.Location = new System.Drawing.Point(180, 122);
            this.lblOgrenimDuzeyi.Name = "lblOgrenimDuzeyi";
            this.lblOgrenimDuzeyi.Size = new System.Drawing.Size(500, 61);
            this.lblOgrenimDuzeyi.TabIndex = 3;
            this.lblOgrenimDuzeyi.Text = "Mezun Bilgisi";
            // 
            // pbResim
            // 
            this.pbResim.BackColor = System.Drawing.Color.White;
            this.pbResim.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbResim.Image = global::WinFormUserControlPratic_2.Properties.Resources.bos;
            this.pbResim.Location = new System.Drawing.Point(0, 0);
            this.pbResim.Name = "pbResim";
            this.pbResim.Size = new System.Drawing.Size(163, 213);
            this.pbResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbResim.TabIndex = 0;
            this.pbResim.TabStop = false;
            // 
            // ucKisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.lblOgrenimDuzeyi);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.pbResim);
            this.Name = "ucKisi";
            this.Size = new System.Drawing.Size(937, 213);
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbResim;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.Label lblOgrenimDuzeyi;
    }
}

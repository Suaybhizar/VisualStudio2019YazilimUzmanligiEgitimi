
namespace TasKagitMakasOyunu
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBilgisayarSkor = new System.Windows.Forms.Label();
            this.lblOyuncuSkor = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.resimBigisayarınSecimi = new TasKagitMakasOyunu.Resim();
            this.resimOyuncuSecimi = new TasKagitMakasOyunu.Resim();
            this.resimMakas = new TasKagitMakasOyunu.Resim();
            this.resimKagit = new TasKagitMakasOyunu.Resim();
            this.resimTas = new TasKagitMakasOyunu.Resim();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resimBigisayarınSecimi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resimOyuncuSecimi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resimMakas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resimKagit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resimTas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bilgisayar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(385, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Oyuncu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Skor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(395, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Skor";
            // 
            // lblBilgisayarSkor
            // 
            this.lblBilgisayarSkor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBilgisayarSkor.Location = new System.Drawing.Point(77, 336);
            this.lblBilgisayarSkor.Name = "lblBilgisayarSkor";
            this.lblBilgisayarSkor.Size = new System.Drawing.Size(35, 21);
            this.lblBilgisayarSkor.TabIndex = 4;
            this.lblBilgisayarSkor.Text = "0";
            this.lblBilgisayarSkor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOyuncuSkor
            // 
            this.lblOyuncuSkor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOyuncuSkor.Location = new System.Drawing.Point(396, 336);
            this.lblOyuncuSkor.Name = "lblOyuncuSkor";
            this.lblOyuncuSkor.Size = new System.Drawing.Size(35, 21);
            this.lblOyuncuSkor.TabIndex = 5;
            this.lblOyuncuSkor.Text = "0";
            this.lblOyuncuSkor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.resimMakas);
            this.groupBox1.Controls.Add(this.resimKagit);
            this.groupBox1.Controls.Add(this.resimTas);
            this.groupBox1.Location = new System.Drawing.Point(39, 382);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 178);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seçiminiz";
            // 
            // resimBigisayarınSecimi
            // 
            this.resimBigisayarınSecimi.Location = new System.Drawing.Point(39, 122);
            this.resimBigisayarınSecimi.Name = "resimBigisayarınSecimi";
            this.resimBigisayarınSecimi.ResimTuru = TasKagitMakasOyunu.ResimTuru.Bos;
            this.resimBigisayarınSecimi.Size = new System.Drawing.Size(110, 105);
            this.resimBigisayarınSecimi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.resimBigisayarınSecimi.TabIndex = 9;
            this.resimBigisayarınSecimi.TabStop = false;
            // 
            // resimOyuncuSecimi
            // 
            this.resimOyuncuSecimi.Location = new System.Drawing.Point(358, 122);
            this.resimOyuncuSecimi.Name = "resimOyuncuSecimi";
            this.resimOyuncuSecimi.ResimTuru = TasKagitMakasOyunu.ResimTuru.Bos;
            this.resimOyuncuSecimi.Size = new System.Drawing.Size(110, 105);
            this.resimOyuncuSecimi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.resimOyuncuSecimi.TabIndex = 8;
            this.resimOyuncuSecimi.TabStop = false;
            // 
            // resimMakas
            // 
            this.resimMakas.Image = ((System.Drawing.Image)(resources.GetObject("resimMakas.Image")));
            this.resimMakas.Location = new System.Drawing.Point(300, 41);
            this.resimMakas.Name = "resimMakas";
            this.resimMakas.ResimTuru = TasKagitMakasOyunu.ResimTuru.Makas;
            this.resimMakas.Size = new System.Drawing.Size(110, 105);
            this.resimMakas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.resimMakas.TabIndex = 2;
            this.resimMakas.TabStop = false;
            this.resimMakas.Click += new System.EventHandler(this.resimTas_Click);
            // 
            // resimKagit
            // 
            this.resimKagit.Image = ((System.Drawing.Image)(resources.GetObject("resimKagit.Image")));
            this.resimKagit.Location = new System.Drawing.Point(158, 41);
            this.resimKagit.Name = "resimKagit";
            this.resimKagit.ResimTuru = TasKagitMakasOyunu.ResimTuru.Kagit;
            this.resimKagit.Size = new System.Drawing.Size(110, 105);
            this.resimKagit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.resimKagit.TabIndex = 1;
            this.resimKagit.TabStop = false;
            this.resimKagit.Click += new System.EventHandler(this.resimTas_Click);
            // 
            // resimTas
            // 
            this.resimTas.Image = ((System.Drawing.Image)(resources.GetObject("resimTas.Image")));
            this.resimTas.Location = new System.Drawing.Point(16, 41);
            this.resimTas.Name = "resimTas";
            this.resimTas.ResimTuru = TasKagitMakasOyunu.ResimTuru.Tas;
            this.resimTas.Size = new System.Drawing.Size(110, 105);
            this.resimTas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.resimTas.TabIndex = 0;
            this.resimTas.TabStop = false;
            this.resimTas.Click += new System.EventHandler(this.resimTas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 572);
            this.Controls.Add(this.resimBigisayarınSecimi);
            this.Controls.Add(this.resimOyuncuSecimi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblOyuncuSkor);
            this.Controls.Add(this.lblBilgisayarSkor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resimBigisayarınSecimi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resimOyuncuSecimi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resimMakas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resimKagit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resimTas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBilgisayarSkor;
        private System.Windows.Forms.Label lblOyuncuSkor;
        private System.Windows.Forms.GroupBox groupBox1;
        private Resim resimMakas;
        private Resim resimKagit;
        private Resim resimTas;
        private Resim resimOyuncuSecimi;
        private Resim resimBigisayarınSecimi;
    }
}


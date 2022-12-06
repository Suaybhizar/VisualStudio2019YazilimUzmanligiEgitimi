
namespace WinFormUserControl
{
    partial class UCKisi
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
            this.PbResim = new System.Windows.Forms.PictureBox();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.lblAciklama = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PbResim)).BeginInit();
            this.SuspendLayout();
            // 
            // PbResim
            // 
            this.PbResim.Dock = System.Windows.Forms.DockStyle.Left;
            this.PbResim.Image = global::WinFormUserControl.Properties.Resources.bos;
            this.PbResim.Location = new System.Drawing.Point(0, 0);
            this.PbResim.Name = "PbResim";
            this.PbResim.Size = new System.Drawing.Size(100, 108);
            this.PbResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbResim.TabIndex = 0;
            this.PbResim.TabStop = false;
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Location = new System.Drawing.Point(121, 15);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(51, 17);
            this.lblBaslik.TabIndex = 1;
            this.lblBaslik.Text = "Başlık";
            // 
            // lblAciklama
            // 
            this.lblAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAciklama.Location = new System.Drawing.Point(121, 47);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(236, 53);
            this.lblAciklama.TabIndex = 2;
            this.lblAciklama.Text = "Açıklama bilgisi buraya gelecek";
            // 
            // UCKisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.PbResim);
            this.Name = "UCKisi";
            this.Size = new System.Drawing.Size(404, 108);
            ((System.ComponentModel.ISupportInitialize)(this.PbResim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PbResim;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label lblAciklama;
    }
}

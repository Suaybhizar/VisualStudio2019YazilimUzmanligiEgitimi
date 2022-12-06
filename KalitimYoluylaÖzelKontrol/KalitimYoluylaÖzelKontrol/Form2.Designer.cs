
namespace KalitimYoluylaÖzelKontrol
{
    partial class Form2
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
            this.kaydetButon1 = new KalitimYoluylaÖzelKontrol.KaydetButon();
            this.silButon1 = new KalitimYoluylaÖzelKontrol.SilButon();
            this.SuspendLayout();
            // 
            // kaydetButon1
            // 
            this.kaydetButon1.BackColor = System.Drawing.Color.Lime;
            this.kaydetButon1.Font = new System.Drawing.Font("Verdana", 10F);
            this.kaydetButon1.Location = new System.Drawing.Point(628, 403);
            this.kaydetButon1.Name = "kaydetButon1";
            this.kaydetButon1.Size = new System.Drawing.Size(150, 35);
            this.kaydetButon1.TabIndex = 0;
            this.kaydetButon1.Text = "kaydetButon1";
            this.kaydetButon1.UseVisualStyleBackColor = false;
            // 
            // silButon1
            // 
            this.silButon1.BackColor = System.Drawing.Color.Maroon;
            this.silButon1.Font = new System.Drawing.Font("Verdana", 10F);
            this.silButon1.ForeColor = System.Drawing.Color.White;
            this.silButon1.Location = new System.Drawing.Point(492, 403);
            this.silButon1.Name = "silButon1";
            this.silButon1.Size = new System.Drawing.Size(130, 35);
            this.silButon1.TabIndex = 1;
            this.silButon1.Text = "silButon1";
            this.silButon1.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.silButon1);
            this.Controls.Add(this.kaydetButon1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private KaydetButon kaydetButon1;
        private SilButon silButon1;
    }
}
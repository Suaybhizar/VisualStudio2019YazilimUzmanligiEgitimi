
namespace Ornek_oyun_denemesi
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
            this.btnYukarı = new System.Windows.Forms.Button();
            this.btnSag = new System.Windows.Forms.Button();
            this.btnasagi = new System.Windows.Forms.Button();
            this.btnSol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnYukarı
            // 
            this.btnYukarı.Location = new System.Drawing.Point(197, 89);
            this.btnYukarı.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnYukarı.Name = "btnYukarı";
            this.btnYukarı.Size = new System.Drawing.Size(112, 48);
            this.btnYukarı.TabIndex = 0;
            this.btnYukarı.Text = "Yukarı";
            this.btnYukarı.UseVisualStyleBackColor = true;
            this.btnYukarı.Click += new System.EventHandler(this.btnYukarı_Click);
            // 
            // btnSag
            // 
            this.btnSag.Location = new System.Drawing.Point(299, 132);
            this.btnSag.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSag.Name = "btnSag";
            this.btnSag.Size = new System.Drawing.Size(112, 39);
            this.btnSag.TabIndex = 1;
            this.btnSag.Text = "Sağ";
            this.btnSag.UseVisualStyleBackColor = true;
            this.btnSag.Click += new System.EventHandler(this.btnSag_Click);
            // 
            // btnasagi
            // 
            this.btnasagi.Location = new System.Drawing.Point(197, 166);
            this.btnasagi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnasagi.Name = "btnasagi";
            this.btnasagi.Size = new System.Drawing.Size(112, 42);
            this.btnasagi.TabIndex = 2;
            this.btnasagi.Text = "Aşağı";
            this.btnasagi.UseVisualStyleBackColor = true;
            this.btnasagi.Click += new System.EventHandler(this.btnasagi_Click);
            // 
            // btnSol
            // 
            this.btnSol.Location = new System.Drawing.Point(91, 132);
            this.btnSol.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSol.Name = "btnSol";
            this.btnSol.Size = new System.Drawing.Size(112, 39);
            this.btnSol.TabIndex = 3;
            this.btnSol.Text = "Sol";
            this.btnSol.UseVisualStyleBackColor = true;
            this.btnSol.Click += new System.EventHandler(this.btnSol_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(456, 290);
            this.Controls.Add(this.btnSol);
            this.Controls.Add(this.btnasagi);
            this.Controls.Add(this.btnSag);
            this.Controls.Add(this.btnYukarı);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnYukarı;
        private System.Windows.Forms.Button btnSag;
        private System.Windows.Forms.Button btnasagi;
        private System.Windows.Forms.Button btnSol;
    }
}


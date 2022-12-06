
namespace WinFormUserControlPratic
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
            this.flowKisiler = new System.Windows.Forms.FlowLayoutPanel();
            this.btnKisileriYukle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flowKisiler
            // 
            this.flowKisiler.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowKisiler.Location = new System.Drawing.Point(0, 0);
            this.flowKisiler.Name = "flowKisiler";
            this.flowKisiler.Size = new System.Drawing.Size(1274, 697);
            this.flowKisiler.TabIndex = 0;
            // 
            // btnKisileriYukle
            // 
            this.btnKisileriYukle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnKisileriYukle.Font = new System.Drawing.Font("Verdana", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKisileriYukle.ForeColor = System.Drawing.Color.Red;
            this.btnKisileriYukle.Location = new System.Drawing.Point(448, 703);
            this.btnKisileriYukle.Name = "btnKisileriYukle";
            this.btnKisileriYukle.Size = new System.Drawing.Size(373, 61);
            this.btnKisileriYukle.TabIndex = 1;
            this.btnKisileriYukle.Text = "Kişileri Yükle";
            this.btnKisileriYukle.UseVisualStyleBackColor = false;
            this.btnKisileriYukle.Click += new System.EventHandler(this.btnKisileriYukle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 1061);
            this.Controls.Add(this.btnKisileriYukle);
            this.Controls.Add(this.flowKisiler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowKisiler;
        private System.Windows.Forms.Button btnKisileriYukle;
    }
}


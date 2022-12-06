
namespace WinFormUserControl
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
            this.FlowKisiler = new System.Windows.Forms.FlowLayoutPanel();
            this.btnKisileriYukle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FlowKisiler
            // 
            this.FlowKisiler.Dock = System.Windows.Forms.DockStyle.Top;
            this.FlowKisiler.Location = new System.Drawing.Point(0, 0);
            this.FlowKisiler.Name = "FlowKisiler";
            this.FlowKisiler.Size = new System.Drawing.Size(468, 361);
            this.FlowKisiler.TabIndex = 0;
            // 
            // btnKisileriYukle
            // 
            this.btnKisileriYukle.Location = new System.Drawing.Point(289, 367);
            this.btnKisileriYukle.Name = "btnKisileriYukle";
            this.btnKisileriYukle.Size = new System.Drawing.Size(167, 23);
            this.btnKisileriYukle.TabIndex = 1;
            this.btnKisileriYukle.Text = "Kişileri Yükle";
            this.btnKisileriYukle.UseVisualStyleBackColor = true;
            this.btnKisileriYukle.Click += new System.EventHandler(this.btnKisileriYukle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 407);
            this.Controls.Add(this.btnKisileriYukle);
            this.Controls.Add(this.FlowKisiler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FlowKisiler;
        private System.Windows.Forms.Button btnKisileriYukle;
    }
}


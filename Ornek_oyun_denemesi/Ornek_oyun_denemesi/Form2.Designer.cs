
namespace Ornek_oyun_denemesi
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
            this.btnOyuncu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOyuncu
            // 
            this.btnOyuncu.BackColor = System.Drawing.Color.Red;
            this.btnOyuncu.Location = new System.Drawing.Point(171, 71);
            this.btnOyuncu.Name = "btnOyuncu";
            this.btnOyuncu.Size = new System.Drawing.Size(92, 74);
            this.btnOyuncu.TabIndex = 0;
            this.btnOyuncu.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 293);
            this.Controls.Add(this.btnOyuncu);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOyuncu;
    }
}
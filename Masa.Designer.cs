namespace Restrand
{
    partial class Masa
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
            this.txtSandSayi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lstMasaKonum = new System.Windows.Forms.ListBox();
            this.btnMasaEkle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMasaSayisi = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtSandSayi
            // 
            this.txtSandSayi.Location = new System.Drawing.Point(29, 75);
            this.txtSandSayi.Name = "txtSandSayi";
            this.txtSandSayi.Size = new System.Drawing.Size(169, 20);
            this.txtSandSayi.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Sandelye Sayisı";
            // 
            // lstMasaKonum
            // 
            this.lstMasaKonum.FormattingEnabled = true;
            this.lstMasaKonum.Location = new System.Drawing.Point(29, 154);
            this.lstMasaKonum.Name = "lstMasaKonum";
            this.lstMasaKonum.Size = new System.Drawing.Size(169, 251);
            this.lstMasaKonum.TabIndex = 11;
            // 
            // btnMasaEkle
            // 
            this.btnMasaEkle.Location = new System.Drawing.Point(29, 410);
            this.btnMasaEkle.Name = "btnMasaEkle";
            this.btnMasaEkle.Size = new System.Drawing.Size(169, 28);
            this.btnMasaEkle.TabIndex = 10;
            this.btnMasaEkle.Text = "Ekle";
            this.btnMasaEkle.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Masa Konumu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Masa Sayisı";
            // 
            // txtMasaSayisi
            // 
            this.txtMasaSayisi.Location = new System.Drawing.Point(29, 25);
            this.txtMasaSayisi.Name = "txtMasaSayisi";
            this.txtMasaSayisi.Size = new System.Drawing.Size(169, 20);
            this.txtMasaSayisi.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 128);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 20);
            this.textBox1.TabIndex = 14;
            // 
            // Masa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtSandSayi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstMasaKonum);
            this.Controls.Add(this.btnMasaEkle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMasaSayisi);
            this.Name = "Masa";
            this.Text = "Masa Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSandSayi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstMasaKonum;
        private System.Windows.Forms.Button btnMasaEkle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMasaSayisi;
        private System.Windows.Forms.TextBox textBox1;
    }
}
namespace Restrand
{
    partial class Restrand
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
            this.btnMasaEkle = new System.Windows.Forms.Button();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.btnRandevuBilgi = new System.Windows.Forms.Button();
            this.lstEklenenMasa = new System.Windows.Forms.ListBox();
            this.lstEklenenUrun = new System.Windows.Forms.ListBox();
            this.lstEklenenRandevu = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnMasaEkle
            // 
            this.btnMasaEkle.Location = new System.Drawing.Point(101, 330);
            this.btnMasaEkle.Name = "btnMasaEkle";
            this.btnMasaEkle.Size = new System.Drawing.Size(150, 55);
            this.btnMasaEkle.TabIndex = 0;
            this.btnMasaEkle.Text = "Masa Ekle";
            this.btnMasaEkle.UseVisualStyleBackColor = true;
            this.btnMasaEkle.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Location = new System.Drawing.Point(321, 330);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(150, 55);
            this.btnUrunEkle.TabIndex = 1;
            this.btnUrunEkle.Text = "Ürün Ekle";
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            // 
            // btnRandevuBilgi
            // 
            this.btnRandevuBilgi.Location = new System.Drawing.Point(531, 330);
            this.btnRandevuBilgi.Name = "btnRandevuBilgi";
            this.btnRandevuBilgi.Size = new System.Drawing.Size(150, 55);
            this.btnRandevuBilgi.TabIndex = 2;
            this.btnRandevuBilgi.Text = "Randevu Bilgileri";
            this.btnRandevuBilgi.UseVisualStyleBackColor = true;
            // 
            // lstEklenenMasa
            // 
            this.lstEklenenMasa.FormattingEnabled = true;
            this.lstEklenenMasa.Location = new System.Drawing.Point(101, 34);
            this.lstEklenenMasa.Name = "lstEklenenMasa";
            this.lstEklenenMasa.Size = new System.Drawing.Size(150, 290);
            this.lstEklenenMasa.TabIndex = 3;
            // 
            // lstEklenenUrun
            // 
            this.lstEklenenUrun.FormattingEnabled = true;
            this.lstEklenenUrun.Location = new System.Drawing.Point(321, 34);
            this.lstEklenenUrun.Name = "lstEklenenUrun";
            this.lstEklenenUrun.Size = new System.Drawing.Size(150, 290);
            this.lstEklenenUrun.TabIndex = 4;
            // 
            // lstEklenenRandevu
            // 
            this.lstEklenenRandevu.FormattingEnabled = true;
            this.lstEklenenRandevu.Location = new System.Drawing.Point(531, 34);
            this.lstEklenenRandevu.Name = "lstEklenenRandevu";
            this.lstEklenenRandevu.Size = new System.Drawing.Size(150, 290);
            this.lstEklenenRandevu.TabIndex = 5;
            // 
            // Restrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstEklenenRandevu);
            this.Controls.Add(this.lstEklenenUrun);
            this.Controls.Add(this.lstEklenenMasa);
            this.Controls.Add(this.btnRandevuBilgi);
            this.Controls.Add(this.btnUrunEkle);
            this.Controls.Add(this.btnMasaEkle);
            this.Name = "Restrand";
            this.Text = "Restrand";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMasaEkle;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.Button btnRandevuBilgi;
        private System.Windows.Forms.ListBox lstEklenenMasa;
        private System.Windows.Forms.ListBox lstEklenenUrun;
        private System.Windows.Forms.ListBox lstEklenenRandevu;
    }
}


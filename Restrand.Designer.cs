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
            this.btnMasaEkle.Location = new System.Drawing.Point(202, 635);
            this.btnMasaEkle.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnMasaEkle.Name = "btnMasaEkle";
            this.btnMasaEkle.Size = new System.Drawing.Size(300, 106);
            this.btnMasaEkle.TabIndex = 0;
            this.btnMasaEkle.Text = "Masa Ekle";
            this.btnMasaEkle.UseVisualStyleBackColor = true;
            this.btnMasaEkle.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Location = new System.Drawing.Point(642, 635);
            this.btnUrunEkle.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(300, 106);
            this.btnUrunEkle.TabIndex = 1;
            this.btnUrunEkle.Text = "Ürün Ekle";
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            // 
            // btnRandevuBilgi
            // 
            this.btnRandevuBilgi.Location = new System.Drawing.Point(1062, 635);
            this.btnRandevuBilgi.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnRandevuBilgi.Name = "btnRandevuBilgi";
            this.btnRandevuBilgi.Size = new System.Drawing.Size(300, 106);
            this.btnRandevuBilgi.TabIndex = 2;
            this.btnRandevuBilgi.Text = "Randevu Bilgileri";
            this.btnRandevuBilgi.UseVisualStyleBackColor = true;
            // 
            // lstEklenenMasa
            // 
            this.lstEklenenMasa.FormattingEnabled = true;
            this.lstEklenenMasa.ItemHeight = 25;
            this.lstEklenenMasa.Location = new System.Drawing.Point(202, 65);
            this.lstEklenenMasa.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lstEklenenMasa.Name = "lstEklenenMasa";
            this.lstEklenenMasa.Size = new System.Drawing.Size(296, 554);
            this.lstEklenenMasa.TabIndex = 3;
            // 
            // lstEklenenUrun
            // 
            this.lstEklenenUrun.FormattingEnabled = true;
            this.lstEklenenUrun.ItemHeight = 25;
            this.lstEklenenUrun.Location = new System.Drawing.Point(642, 65);
            this.lstEklenenUrun.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lstEklenenUrun.Name = "lstEklenenUrun";
            this.lstEklenenUrun.Size = new System.Drawing.Size(296, 554);
            this.lstEklenenUrun.TabIndex = 4;
            // 
            // lstEklenenRandevu
            // 
            this.lstEklenenRandevu.FormattingEnabled = true;
            this.lstEklenenRandevu.ItemHeight = 25;
            this.lstEklenenRandevu.Location = new System.Drawing.Point(1062, 65);
            this.lstEklenenRandevu.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lstEklenenRandevu.Name = "lstEklenenRandevu";
            this.lstEklenenRandevu.Size = new System.Drawing.Size(296, 554);
            this.lstEklenenRandevu.TabIndex = 5;
            // 
            // Restrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.lstEklenenRandevu);
            this.Controls.Add(this.lstEklenenUrun);
            this.Controls.Add(this.lstEklenenMasa);
            this.Controls.Add(this.btnRandevuBilgi);
            this.Controls.Add(this.btnUrunEkle);
            this.Controls.Add(this.btnMasaEkle);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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


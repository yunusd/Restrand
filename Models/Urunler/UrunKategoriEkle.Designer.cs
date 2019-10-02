namespace Restrand.Models.Urunler
{
    partial class UrunKategoriEkle
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
            this.txtKategori = new System.Windows.Forms.TextBox();
            this.btnUrunKategoriEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtKategori
            // 
            this.txtKategori.Location = new System.Drawing.Point(126, 126);
            this.txtKategori.Name = "txtKategori";
            this.txtKategori.Size = new System.Drawing.Size(305, 31);
            this.txtKategori.TabIndex = 0;
            // 
            // btnUrunKategoriEkle
            // 
            this.btnUrunKategoriEkle.Location = new System.Drawing.Point(126, 188);
            this.btnUrunKategoriEkle.Name = "btnUrunKategoriEkle";
            this.btnUrunKategoriEkle.Size = new System.Drawing.Size(305, 67);
            this.btnUrunKategoriEkle.TabIndex = 1;
            this.btnUrunKategoriEkle.Text = "Ekle";
            this.btnUrunKategoriEkle.UseVisualStyleBackColor = true;
            this.btnUrunKategoriEkle.Click += new System.EventHandler(this.BtnUrunKategoriEkle_Click);
            // 
            // UrunKategoriEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 317);
            this.Controls.Add(this.btnUrunKategoriEkle);
            this.Controls.Add(this.txtKategori);
            this.Name = "UrunKategoriEkle";
            this.Text = "UrunKategoriEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKategori;
        private System.Windows.Forms.Button btnUrunKategoriEkle;
    }
}
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
            this.lstEklenenMasalar = new System.Windows.Forms.ListBox();
            this.btnMasaEkle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMasaNumarasi = new System.Windows.Forms.TextBox();
            this.cbMasaKonumu = new System.Windows.Forms.ComboBox();
            this.btnMasaKonumuEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSandSayi
            // 
            this.txtSandSayi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSandSayi.Location = new System.Drawing.Point(28, 103);
            this.txtSandSayi.Name = "txtSandSayi";
            this.txtSandSayi.Size = new System.Drawing.Size(173, 20);
            this.txtSandSayi.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Sandelye Sayisı";
            // 
            // lstEklenenMasalar
            // 
            this.lstEklenenMasalar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstEklenenMasalar.FormattingEnabled = true;
            this.lstEklenenMasalar.Location = new System.Drawing.Point(29, 130);
            this.lstEklenenMasalar.Name = "lstEklenenMasalar";
            this.lstEklenenMasalar.Size = new System.Drawing.Size(173, 251);
            this.lstEklenenMasalar.TabIndex = 11;
            // 
            // btnMasaEkle
            // 
            this.btnMasaEkle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMasaEkle.Location = new System.Drawing.Point(29, 398);
            this.btnMasaEkle.Name = "btnMasaEkle";
            this.btnMasaEkle.Size = new System.Drawing.Size(172, 28);
            this.btnMasaEkle.TabIndex = 10;
            this.btnMasaEkle.Text = "Ekle";
            this.btnMasaEkle.UseVisualStyleBackColor = true;
            this.btnMasaEkle.Click += new System.EventHandler(this.BtnMasaEkle_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Masa Konumu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Masa Numarası";
            // 
            // txtMasaNumarasi
            // 
            this.txtMasaNumarasi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMasaNumarasi.Location = new System.Drawing.Point(29, 64);
            this.txtMasaNumarasi.Name = "txtMasaNumarasi";
            this.txtMasaNumarasi.Size = new System.Drawing.Size(173, 20);
            this.txtMasaNumarasi.TabIndex = 16;
            // 
            // cbMasaKonumu
            // 
            this.cbMasaKonumu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMasaKonumu.FormattingEnabled = true;
            this.cbMasaKonumu.Location = new System.Drawing.Point(28, 25);
            this.cbMasaKonumu.Name = "cbMasaKonumu";
            this.cbMasaKonumu.Size = new System.Drawing.Size(145, 21);
            this.cbMasaKonumu.TabIndex = 17;
            this.cbMasaKonumu.SelectedIndexChanged += new System.EventHandler(this.CbMasaKonumu_SelectedIndexChanged);
            // 
            // btnMasaKonumuEkle
            // 
            this.btnMasaKonumuEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMasaKonumuEkle.BackgroundImage = global::Restrand.Properties.Resources.baseline_add_black_18dp;
            this.btnMasaKonumuEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMasaKonumuEkle.FlatAppearance.BorderSize = 0;
            this.btnMasaKonumuEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnMasaKonumuEkle.Location = new System.Drawing.Point(179, 25);
            this.btnMasaKonumuEkle.Name = "btnMasaKonumuEkle";
            this.btnMasaKonumuEkle.Size = new System.Drawing.Size(23, 23);
            this.btnMasaKonumuEkle.TabIndex = 18;
            this.btnMasaKonumuEkle.UseVisualStyleBackColor = true;
            this.btnMasaKonumuEkle.Click += new System.EventHandler(this.BtnMasaKonumuEkle_Click);
            // 
            // Masa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 434);
            this.Controls.Add(this.btnMasaKonumuEkle);
            this.Controls.Add(this.cbMasaKonumu);
            this.Controls.Add(this.txtMasaNumarasi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSandSayi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstEklenenMasalar);
            this.Controls.Add(this.btnMasaEkle);
            this.Controls.Add(this.label2);
            this.Name = "Masa";
            this.Text = "Masa Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSandSayi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstEklenenMasalar;
        private System.Windows.Forms.Button btnMasaEkle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMasaNumarasi;
        private System.Windows.Forms.ComboBox cbMasaKonumu;
        private System.Windows.Forms.Button btnMasaKonumuEkle;
    }
}
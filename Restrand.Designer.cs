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
            this.SuspendLayout();
            // 
            // btnMasaEkle
            // 
            this.btnMasaEkle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMasaEkle.Location = new System.Drawing.Point(83, 112);
            this.btnMasaEkle.Margin = new System.Windows.Forms.Padding(6);
            this.btnMasaEkle.Name = "btnMasaEkle";
            this.btnMasaEkle.Size = new System.Drawing.Size(300, 106);
            this.btnMasaEkle.TabIndex = 0;
            this.btnMasaEkle.Text = "Masalar";
            this.btnMasaEkle.UseVisualStyleBackColor = true;
            this.btnMasaEkle.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUrunEkle.Location = new System.Drawing.Point(83, 289);
            this.btnUrunEkle.Margin = new System.Windows.Forms.Padding(6);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(300, 106);
            this.btnUrunEkle.TabIndex = 1;
            this.btnUrunEkle.Text = "Ürünler";
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            this.btnUrunEkle.Click += new System.EventHandler(this.BtnUrunEkle_Click);
            // 
            // btnRandevuBilgi
            // 
            this.btnRandevuBilgi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRandevuBilgi.Location = new System.Drawing.Point(83, 464);
            this.btnRandevuBilgi.Margin = new System.Windows.Forms.Padding(6);
            this.btnRandevuBilgi.Name = "btnRandevuBilgi";
            this.btnRandevuBilgi.Size = new System.Drawing.Size(300, 106);
            this.btnRandevuBilgi.TabIndex = 2;
            this.btnRandevuBilgi.Text = "Rezervasyonlar";
            this.btnRandevuBilgi.UseVisualStyleBackColor = true;
            this.btnRandevuBilgi.Click += new System.EventHandler(this.BtnRandevuBilgi_Click);
            // 
            // Restrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 662);
            this.Controls.Add(this.btnRandevuBilgi);
            this.Controls.Add(this.btnUrunEkle);
            this.Controls.Add(this.btnMasaEkle);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Restrand";
            this.Text = "Restrand";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMasaEkle;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.Button btnRandevuBilgi;
    }
}


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
            this.txtMasaKonumu = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtSandSayi
            // 
            this.txtSandSayi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSandSayi.Location = new System.Drawing.Point(57, 57);
            this.txtSandSayi.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtSandSayi.Name = "txtSandSayi";
            this.txtSandSayi.Size = new System.Drawing.Size(334, 31);
            this.txtSandSayi.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Sandelye Sayisı";
            // 
            // lstMasaKonum
            // 
            this.lstMasaKonum.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstMasaKonum.FormattingEnabled = true;
            this.lstMasaKonum.ItemHeight = 25;
            this.lstMasaKonum.Location = new System.Drawing.Point(58, 175);
            this.lstMasaKonum.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lstMasaKonum.Name = "lstMasaKonum";
            this.lstMasaKonum.Size = new System.Drawing.Size(334, 504);
            this.lstMasaKonum.TabIndex = 11;
            // 
            // btnMasaEkle
            // 
            this.btnMasaEkle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMasaEkle.Location = new System.Drawing.Point(58, 710);
            this.btnMasaEkle.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnMasaEkle.Name = "btnMasaEkle";
            this.btnMasaEkle.Size = new System.Drawing.Size(335, 54);
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
            this.label2.Location = new System.Drawing.Point(53, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Masa Konumu";
            // 
            // txtMasaKonumu
            // 
            this.txtMasaKonumu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMasaKonumu.Location = new System.Drawing.Point(58, 136);
            this.txtMasaKonumu.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtMasaKonumu.Name = "txtMasaKonumu";
            this.txtMasaKonumu.Size = new System.Drawing.Size(334, 31);
            this.txtMasaKonumu.TabIndex = 14;
            // 
            // Masa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 779);
            this.Controls.Add(this.txtMasaKonumu);
            this.Controls.Add(this.txtSandSayi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstMasaKonum);
            this.Controls.Add(this.btnMasaEkle);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
        private System.Windows.Forms.TextBox txtMasaKonumu;
    }
}
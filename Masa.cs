using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restrand
{
    public partial class Masa : Form
    {
        public Masa()
        {
            InitializeComponent();
        }

        private void BtnMasaEkle_Click(object sender, EventArgs e)
        {
            if (txtSandSayi.Text == "" || txtMasaKonumu.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz");
                return;
            }

            MasaBilgileri masa = new MasaBilgileri()
            {
                masaKonumu = txtMasaKonumu.Text,
                sandalyeSayisi = Convert.ToInt32(txtSandSayi.Text)
            };

            lstMasaKonum.Items.Add(masa);
            txtMasaKonumu.Clear();
            txtSandSayi.Clear();
        }
    }
}

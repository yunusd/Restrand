using Restrand.Models.Masalar;
using Restrand.Models.Rezervasyonlar;
using Restrand.Models.Urunler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restrand
{
    public partial class Restrand : Form
    {
        public Restrand()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            _ = new Masa().ShowDialog();

        }

        private void BtnUrunEkle_Click(object sender, EventArgs e)
        {
            _ = new Urunler().ShowDialog();
        }

        private void BtnRandevuBilgi_Click(object sender, EventArgs e)
        {
            RandevuGoster rg = new RandevuGoster();
            rg.ShowDialog();

        }
    }
}

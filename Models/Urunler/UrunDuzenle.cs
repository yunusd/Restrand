using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restrand.Models.Urunler
{
    public partial class UrunDuzenle : Form
    {
        public UrunDuzenle(int id, decimal fiyat, string urunAdi)
        {
            InitializeComponent();
            txtId.Text = id.ToString();
            txtUrunAdi.Text = urunAdi;
            nudFiyat.Value = fiyat;
        }

        private void BtnIptal_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Utils.ConnectionString()))
                {
                    conn.Open();
                    SqlCommand duzenleUrunler = new SqlCommand(Utils.DuzenleUrunler, conn);
                    duzenleUrunler.Parameters.AddWithValue("productId", txtId.Text);
                    duzenleUrunler.Parameters.AddWithValue("productName", txtUrunAdi.Text);
                    duzenleUrunler.Parameters.AddWithValue("price", nudFiyat.Value);
                    // TO-DO: Kategori değiştirme eklenecek
                    duzenleUrunler.ExecuteNonQuery();
                    conn.Close();
                    Close();
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

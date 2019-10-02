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
    public partial class UrunKategoriEkle : Form
    {
        public UrunKategoriEkle()
        {
            InitializeComponent();
        }

        private void BtnUrunKategoriEkle_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(Utils.ConnectionString()))
            {
                conn.Open();
                SqlCommand insertCommand = new SqlCommand(Utils.InsertKategori, conn);
                insertCommand.Parameters.AddWithValue("@categoryName", txtKategori.Text);
                insertCommand.ExecuteNonQuery();
                conn.Close();
            }
            Close();
        }
    }
}

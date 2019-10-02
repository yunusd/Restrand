using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restrand.Models.Urunler
{
    public partial class Urunler : Form
    {
        public Urunler()
        {
            InitializeComponent();
            KategorileriYukle();
            UrunleriYukle();
        }

        public void KategorileriYukle()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Utils.ConnectionString()))
                {
                    conn.Open();
                    SqlCommand selectKategoriler = new SqlCommand(Utils.SelectKategori, conn);
                    SqlDataReader dr = selectKategoriler.ExecuteReader();
                    while (dr.Read())
                    {
                        cboUrunKategori.Items.Add(dr["CategoryName"]);
                    }
                    dr.Close();
                    conn.Close();
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void UrunleriYukle()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Utils.ConnectionString()))
                {
                    conn.Open();
                    SqlCommand selectUrunler = new SqlCommand(Utils.SelectUrunler, conn);
                    DataTable dtUrunler = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(selectUrunler);
                    da.Fill(dtUrunler);
                    dgvUrunler.DataSource = dtUrunler;
                    conn.Close();
                }

                cboUrunKategori.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            UrunEkle();
        }

        private void UrunEkle()
        {
            if (string.IsNullOrWhiteSpace(txtUrunAdi.Text.Trim()))
            {
                MessageBox.Show("Ürün adı boş bırakılamaz!");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(Utils.ConnectionString()))
                {
                    int categoryIdFromDB = 0;
                    conn.Open();
                    SqlCommand selectKategori = new SqlCommand(Utils.SelectKategoriByName, conn);
                    selectKategori.Parameters.AddWithValue("categoryName", cboUrunKategori.SelectedItem);
                    SqlDataReader dr = selectKategori.ExecuteReader();
                    while (dr.Read())
                    {
                        categoryIdFromDB = (int)dr["CategoryID"];
                    }
                    dr.Close();
                    SqlCommand insertUrunler = new SqlCommand(Utils.InsertUrunler, conn);
                    // TextInfo.ToTitleCase() verilen stringin ilk harfini büyütüp geri döndürür.
                    insertUrunler.Parameters.AddWithValue("productName", Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(txtUrunAdi.Text));
                    insertUrunler.Parameters.AddWithValue("price", nudUrunFiyati.Value);
                    insertUrunler.Parameters.AddWithValue("categoryID", categoryIdFromDB);
                    insertUrunler.ExecuteNonQuery();
                    conn.Close();
                    UrunleriYukle();
                    Temizle();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Temizle()
        {
            txtUrunAdi.Clear();
            nudUrunFiyati.Value = 0;
            cboUrunKategori.SelectedIndex = 0;
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int urunId = Convert.ToInt32(
                dgvUrunler.Rows[dgvUrunler.CurrentCell.RowIndex].Cells[0].Value);
            UrunSil(urunId);
            UrunleriYukle();
        }

        private void UrunSil(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Utils.ConnectionString()))
                {
                    conn.Open();
                    SqlCommand deleteUrunler = new SqlCommand(Utils.DeleteUrunler, conn);
                    deleteUrunler.Parameters.AddWithValue("productID", id);
                    deleteUrunler.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void BtnDuzenle_Click(object sender, EventArgs e)
        {
            int urunId = Convert.ToInt32(
    dgvUrunler.Rows[dgvUrunler.CurrentCell.RowIndex].Cells[0].Value);
            string urunAdi = dgvUrunler.Rows[dgvUrunler.CurrentCell.RowIndex].Cells[2].Value.ToString();
            decimal urunFiyati = Convert.ToDecimal(
dgvUrunler.Rows[dgvUrunler.CurrentCell.RowIndex].Cells[3].Value);
            UrunDuzenle(urunId, urunFiyati, urunAdi);
            UrunleriYukle();
        }

        private void UrunDuzenle(int id, decimal urunFiyati, string urunAdi)
        {
            Form f = new UrunDuzenle(id, urunFiyati, urunAdi);
            f.ShowDialog();
            try
            {
                using (SqlConnection conn = new SqlConnection(Utils.ConnectionString()))
                {
                    conn.Open();
                    SqlCommand duzenleUrunler = new SqlCommand(Utils.DuzenleUrunler, conn);
                    duzenleUrunler.Parameters.AddWithValue("productID", id);
                    duzenleUrunler.Parameters.AddWithValue("productName", id);
                    duzenleUrunler.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void DgvUrunler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // TO-DO: sütun adına tıklayınca çalışmayacak
            int urunId = Convert.ToInt32(
    dgvUrunler.Rows[dgvUrunler.CurrentCell.RowIndex].Cells[0].Value);
            string urunAdi = dgvUrunler.Rows[dgvUrunler.CurrentCell.RowIndex].Cells[2].Value.ToString();
            decimal urunFiyati = Convert.ToDecimal(
dgvUrunler.Rows[dgvUrunler.CurrentCell.RowIndex].Cells[3].Value);
            UrunDuzenle(urunId, urunFiyati, urunAdi);
            UrunleriYukle();
        }

        private void BtnKategoriEkle_Click(object sender, EventArgs e)
        {
            Form f = new UrunKategoriEkle();
            f.ShowDialog();
            // Form kapanırken kategorileri tekrardan yüklemesi gerekir
            // TO-DO Hatayı düzelt
            f.FormClosing += (senders, args) =>
            {
                KategorileriYukle();
            };

        }
    }
}

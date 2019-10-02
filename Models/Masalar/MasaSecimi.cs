using Restrand.Properties;
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

namespace Restrand.Models.Masalar
{
    public partial class MasaSecimi : Form
    {
        public MasaSecimi()
        {
            InitializeComponent();
            MasaKonumuOlustur();
            MasaOlustur(masaKonumuToolStripMenuItem.DropDownItems[0].Text);
        }

        public void MasaOlustur(string masaKonumu)
        {
            #region Masa Resimleri Tanımlama
            ImageList resimListesi = new ImageList();
            resimListesi.Images.Add("bos", Resources.masabos);
            resimListesi.Images.Add("dolu", Resources.masadolu);
            resimListesi.ImageSize = new Size(64, 64);
            lvwMasalar.LargeImageList = resimListesi;

            #endregion
            #region Masaları Olusturma
            ListViewItem lvi;
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = Utils.ConnectionString();
                conn.Open();
                using (SqlCommand selectCommand = new SqlCommand(Utils.SelectWhereMasaBilgileri, conn))
                {
                    selectCommand.Parameters.AddWithValue("masaKonumu", masaKonumu);
                    SqlDataReader dr = selectCommand.ExecuteReader();

                    lvwMasalar.Items.Clear();
                    while (dr.Read())
                    {
                        lvi = new ListViewItem($"{dr["MasaKonumu"]} {dr[1]}");

                        lvwMasalar.Items.Add(lvi);
                        lvi.ImageKey = MasaDoluMu((int)dr[0]) ? "dolu" : "bos";

                        lvi.Tag = dr[0];
                    }
                }
                conn.Close();
            }

            #endregion
        }

        /**
         * Eğer yapılan sorguda RezervasyonDurumu adlı column 1 ise true 0 ise false döndürüyor.
         */
        private bool MasaDoluMu(int masaNo)
        {
            bool isFill = false;
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = Utils.ConnectionString();
                conn.Open();
                using (SqlCommand selectCommand = new SqlCommand(Utils.SelectIfStateTrueRezervasyon(masaNo), conn))
                {
                    SqlDataReader dr = selectCommand.ExecuteReader();

                    while (dr.Read())
                    {
                        isFill = Convert.ToInt32(dr[2]) == 1;
                    }
                }
                conn.Close();
            }

            return isFill;
        }

        private void MasaKonumuOlustur()
        {
            int i = 0;

            using (SqlConnection conn = new SqlConnection(Utils.ConnectionString()))
            {
                conn.Open();

                // Kaç tane masa konumu olduğunu döndüren sql komutu
                SqlCommand selectMasaKonumuSayi = new SqlCommand(Utils.SelectMasaKonumuSayi, conn);

                SqlCommand selectMasaKonumu = new SqlCommand(Utils.SelectMasaKonumu, conn);

                int masaKonumSayisi = (int)selectMasaKonumuSayi.ExecuteScalar();
                ToolStripMenuItem[] items = new ToolStripMenuItem[masaKonumSayisi];

                SqlDataReader dr = selectMasaKonumu.ExecuteReader();
                /**
                 * Her bir masa konumu için yeni bir dropdown items oluşturuyoruz.
                 */
                while (dr.Read())
                {
                    string masaKonumuAd = dr["MasaKonumuAd"].ToString();
                    items[i] = new ToolStripMenuItem();
                    items[i].Name = $"dynamicItem{dr["MasaKonumuAd"].ToString()}";
                    items[i].Tag = $"{dr["MasaKonumuAd"].ToString()}-{i}";
                    items[i].Text = dr["MasaKonumuAd"].ToString();
                    items[i].Click += (sender, args) =>
                    {
                        // Dropdown item'a eventhandler atanıyor.
                        ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;
                        MasaOlustur(masaKonumuAd);
                    };
                    i++;
                }
                masaKonumuToolStripMenuItem.DropDownItems.AddRange(items);
                conn.Close();
                dr.Close();
            };
        }
    }
}

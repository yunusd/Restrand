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
        int masaAdet = 0;
        public MasaSecimi()
        {
            InitializeComponent();
            MasaOlustur();
        }

        public void MasaOlustur()
        {
            #region Masa Resimleri Tanımlama
            ImageList resimListesi = new ImageList();
            resimListesi.Images.Add("bos", Resources.masabos);
            resimListesi.Images.Add("dolu", Resources.masadolu);
            resimListesi.ImageSize = new Size(64, 64);
            lvwMasalar.LargeImageList = resimListesi;

            #endregion
            #region Masaları OLusturma
            ListViewItem lvi;
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = Utils.ConnectionString();
                conn.Open();
                using (SqlCommand selectCommand = new SqlCommand(Utils.SelectMasaBilgileri, conn))
                {
                    SqlDataReader dr = selectCommand.ExecuteReader();

                    while (dr.Read())
                    {
                        lvi = new ListViewItem($"{dr["MasaKonumu"]} {dr[1]}");

                        lvwMasalar.Items.Add(lvi);
                        lvi.ImageKey = MasaDoluMu((int)dr[0]) ? "dolu" : "bos";

                        lvi.Tag = dr[0];
                        masaAdet++;
                    }
                }
                conn.Close();
            }

            #endregion
        }

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
                        masaAdet++;
                        isFill = Convert.ToInt32(dr[2]) == 1;
                    }
                }
                conn.Close();
            }

            return isFill;
        }
    }
}

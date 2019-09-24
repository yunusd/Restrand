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

            // Restrand veritabanında ki MasaBilgileri tablosunu lstEklenenMasaya ekle
            using(SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = Utils.ConnectionString();
                conn.Open();
                using (SqlCommand selectCommand = new SqlCommand(Utils.SelectMasaBilgileri, conn))
                {
                    SqlDataReader dr = selectCommand.ExecuteReader();
                    while (dr.Read())
                    {
                        MasaBilgileri data = new MasaBilgileri
                        {
                            masaKonumu = dr[2].ToString(),
                            sandalyeSayisi = (int)dr[3]
                        };
                        lstEklenenMasa.Items.Add(data);
                    }
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            _ = new Masa().ShowDialog();

        }
    }
}

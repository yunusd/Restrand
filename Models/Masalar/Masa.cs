using Restrand.Models.Masalar;
using System;
using System.Collections;
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
    public partial class Masa : Form
    {
        public Masa()
        {
            InitializeComponent();
            using(SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = Utils.ConnectionString();
                conn.Open();
                using (SqlCommand selectCommand = new SqlCommand(Utils.SelectMasaKonumu, conn))
                {
                    SqlDataReader dr = selectCommand.ExecuteReader();
                    while (dr.Read())
                    {
                        cbMasaKonumu.Items.Add(dr[0]);
                    }
                }
            }
            new MasaSecimi().Show();
        }

        private void BtnMasaEkle_Click(object sender, EventArgs e)
        {
            if (cbMasaKonumu.SelectedIndex == -1)
            {
                MessageBox.Show("Masa eklemek için seçili bir masa konumu olması gerek");
                return;
            }

            if (txtSandSayi.Text.Trim() == "" || txtMasaNumarasi.Text.Trim() == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz");
                return;
            }

            MasaBilgileri masa = new MasaBilgileri()
            {
                masaKonumu = cbMasaKonumu.SelectedItem.ToString(),
                sandalyeSayisi = Convert.ToInt32(txtSandSayi.Text)
            };


            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = Utils.ConnectionString();
                conn.Open();

                using (SqlCommand insertCommand = new SqlCommand(Utils.InsertMasaBilgileri, conn))
                {
                    insertCommand.Parameters.AddWithValue("@masaNumarasi", txtMasaNumarasi.Text);
                    insertCommand.Parameters.AddWithValue("@masaKonumu", cbMasaKonumu.SelectedItem);
                    insertCommand.Parameters.AddWithValue("@sandalyeSayisi", txtSandSayi.Text);
                    insertCommand.ExecuteNonQuery();
                    MessageBox.Show("Masa Kaydedildi");
                }
                conn.Close();
            }

            lstEklenenMasalar.Items.Add(masa);
            txtSandSayi.Clear();
        }

        private void BtnMasaKonumuEkle_Click(object senders, EventArgs e)
        {
            Form KonumEkle = new Form()
            {
                Text = "Masa Konumu Ekle",
                Size = new Size(252, 473),
                StartPosition = this.StartPosition,
                TopMost = true
            };

            Label lblMasaKonumu = new Label
            {
                Text = "Masa Konumu",
                TextAlign = ContentAlignment.TopLeft,
                Location = new Point(28, 9),
                Size = new Size(75, 13),
            };

            TextBox txtMasaKonumu = new TextBox
            {
                Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left,
                Location = new Point(28, 25),
                Size = new Size(173, 20),
            };

            ListBox lstMasaKonumu = new ListBox
            {
                Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left,
                Location = new Point(28, 50),
                Size = new Size(173, 325)
            };

            Button btnKonumEkle = new Button
            {
                Text = "Ekle",
                Anchor = AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left,
                Location = new Point(29, 370),
                Size = new Size(172, 28)
            };

            Button btnKonumSil = new Button
            {
                Text = "Sil",
                Anchor = AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left,
                Location = new Point(29, 400),
                Size = new Size(172, 28)
            };
            KonumEkle.Controls.Add(lblMasaKonumu);
            KonumEkle.Controls.Add(txtMasaKonumu);
            KonumEkle.Controls.Add(lstMasaKonumu);
            KonumEkle.Controls.Add(btnKonumEkle);
            KonumEkle.Controls.Add(btnKonumSil);
            using(SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = Utils.ConnectionString();
                conn.Open();
                using(SqlCommand selectCommand = new SqlCommand(Utils.SelectMasaKonumu, conn))
                {
                    SqlDataReader dr = selectCommand.ExecuteReader();
                    while (dr.Read())
                    {
                        lstMasaKonumu.Items.Add(dr[0]);
                    }
                }
            }
            KonumEkle.Show();
            btnKonumEkle.Focus();
            btnKonumEkle.Click += (sender, args) =>
            {
                for (int i = 0; i < lstMasaKonumu.Items.Count; i++)
                {
                    if (lstMasaKonumu.Items[i].ToString() == txtMasaKonumu.Text.Trim())
                    {
                        MessageBox.Show("Zaten böyle bir konum var");
                        return;
                    }
                }
                if (!string.IsNullOrWhiteSpace(txtMasaKonumu.Text))
                {
                    using (SqlConnection conn = new SqlConnection())
                    {
                        conn.ConnectionString = Utils.ConnectionString();
                        conn.Open();
                        using (SqlCommand insertCommand = new SqlCommand(Utils.InsertMasaKonumu, conn))
                        {
                            insertCommand.Parameters.AddWithValue("@masaKonumuAd", txtMasaKonumu.Text);
                            insertCommand.ExecuteNonQuery();
                        }
                        conn.Close();
                    }
                    lstMasaKonumu.Items.Add(txtMasaKonumu.Text);
                    cbMasaKonumu.Items.Add(txtMasaKonumu.Text);
                    txtMasaKonumu.Clear();
                };
            };

            btnKonumSil.Click += (sender, args) =>
            {
                if (lstMasaKonumu.SelectedIndex != -1)
                {
                    using (SqlConnection conn = new SqlConnection())
                    {
                        conn.ConnectionString = Utils.ConnectionString();
                        conn.Open();
                        using (SqlCommand deleteCommand = new SqlCommand(Utils.DeleteMasaKonumu, conn))
                        {
                            deleteCommand.Parameters.AddWithValue("@masaKonumuAd", lstMasaKonumu.SelectedItem);
                            deleteCommand.ExecuteNonQuery();
                            cbMasaKonumu.Items.Remove(lstMasaKonumu.SelectedItem);
                            lstMasaKonumu.Items.Remove(lstMasaKonumu.SelectedItem);

                        }
                        conn.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Silmek için lütfen bir masa seçiniz!");
                }
            };

        }

        private void CbMasaKonumu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

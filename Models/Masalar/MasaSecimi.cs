using Restrand.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restrand.Models.Masalar
{
    public partial class MasaSecimi : Form
    {
        int masaAdet = 20;
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
            int masaNo;
            ListViewItem lvi;
            for (int i = 0; i < masaAdet; i++)
            {
                masaNo = i + 1;
                lvi = new ListViewItem("Masa" + masaNo);

                lvwMasalar.Items.Add(lvi);
                if (true)
                {
                    lvi.ImageKey = "bos";
                }

                lvi.Tag = masaNo;

            }

            #endregion
        }
    }
}

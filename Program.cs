using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restrand
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Veritabanı bağlantısı sağlanamazsa Exception mesajı döndür
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = Utils.ConnectionString();
                try
                {
                    conn.Open();
                    conn.Close();
                    Application.Run(new Restrand());
                }
                catch (Exception)
                {
                    MessageBox.Show("Veritabanı ile bağlantı sağlanamadı. " +
                        "Lütfen geliştiriciniz ile iletişime geçiniz", "VERİTABANI BAĞLANTI HATASI",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
        }
    }
}

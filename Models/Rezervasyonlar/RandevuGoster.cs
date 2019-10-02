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

namespace Restrand.Models.Rezervasyonlar
{
    public partial class RandevuGoster : Form
    {
        public RandevuGoster()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection(Utils.ConnectionString());
            con.Open();
            SqlCommand cmd = new SqlCommand(Utils.SelectRandevuBilgi, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

    }
}

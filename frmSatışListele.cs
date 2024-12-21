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
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace stoktakipapp
{
    public partial class frmSatışListele : Form
    {
        public frmSatışListele()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-RVTJMPA;Initial Catalog=Stok_Takip;Integrated Security=True");
        DataSet daset = new DataSet();
        private void satışlistele()
        {
            baglan.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from satis", baglan);
            adtr.Fill(daset, "sepet");
            dataGridView1.DataSource = daset.Tables["satis"];
          
            baglan.Close();

        }
        private void frmSatışListele_Load(object sender, EventArgs e)
        {
            satışlistele(); 

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmSatis ekle = new frmSatis();
            ekle.ShowDialog();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

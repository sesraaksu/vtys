using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AksuSirketi
{
    public partial class Form2 : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-HP02H6O;Initial Catalog=AksuSirketi;Integrated Security=True");
        SqlCommand komut;
        SqlDataAdapter da;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void linkcus_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            baglanti.Open();
            da = new SqlDataAdapter("Select * From MUSTERI", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void linksup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            baglanti.Open();
            da = new SqlDataAdapter("Select * From TEDARIKCI", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void linkpdct_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            baglanti.Open();
            da = new SqlDataAdapter("Select * From URUN", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {

        }
    }
}

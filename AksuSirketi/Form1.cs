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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-HP02H6O;Initial Catalog=AksuSirketi;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_lgn_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string sql = "Select * From LOGIN where kullaniciAdi=@adi AND kullaniciSifre=@sifresi";
                SqlParameter prm1 = new SqlParameter("adi", txt_user.Text.Trim());
                SqlParameter prm2 = new SqlParameter("sifresi", txt_pass.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    Form2 fr = new Form2();
                    fr.Show();
                    this.Hide();
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Hatalı giriş yaptınız.");
            }
        }

        private void btn_ext_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

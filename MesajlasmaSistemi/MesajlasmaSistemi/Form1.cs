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

namespace MesajlasmaSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ARDACIMEN\\SQLEXPRESS;Initial Catalog=MesajlasmaSistemi;Integrated Security=True;");

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from TBLKisiler where NUMARA=@p1 and Şifre=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", msknumara.Text);
            komut.Parameters.AddWithValue("@p2", txtsifre.Text);

            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmMesajPaneli fr = new FrmMesajPaneli();
                fr.numara = msknumara.Text;
                fr.Show();
            }
            else
            {
                MessageBox.Show("Hatalı Bilgi");

            }
            baglanti.Close();
        }
    }
}

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

namespace BankamatikSimulasyonu
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=ARDACIMEN\\SQLEXPRESS;Initial Catalog=BankamatikSimulasyon;Integrated Security=True;");

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Insert into TBLKISILER (AD,SOYAD,TC,TELEFON,HESAPNO,SIFRE) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3", mskkimlikno.Text);
            komut.Parameters.AddWithValue("@p4", msktelefon.Text);
            komut.Parameters.AddWithValue("@p5", mskhesapno.Text);
            komut.Parameters.AddWithValue("@p6", txtsifre.Text);

            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri Bilgileri sisteme kayıt edildi");
        }

        private void btnhesapno_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();

            int sayi = rastgele.Next(100000, 999999);
            mskhesapno.Text = sayi.ToString();  
        }
    }
}

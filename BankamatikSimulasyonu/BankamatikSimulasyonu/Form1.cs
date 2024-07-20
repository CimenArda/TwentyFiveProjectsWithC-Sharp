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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ARDACIMEN\\SQLEXPRESS;Initial Catalog=BankamatikSimulasyon;Integrated Security=True;");

        private void lnkKayıtOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from TBLKISILER WHERE HESAPNO=@p1 and SIFRE =@p2",baglanti);

            komut.Parameters.AddWithValue("@p1", mskhesapno.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);

            SqlDataReader dr = komut.ExecuteReader();   
            if (dr.Read())
            {
                Form2 fr =new Form2();
                fr.hesap =mskhesapno.Text;
                fr.Show();
            }
            else
            {
                MessageBox.Show("Hatalı Bilgi");
            }
        }
    }
}

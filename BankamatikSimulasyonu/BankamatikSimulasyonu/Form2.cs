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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string hesap;
        SqlConnection baglanti = new SqlConnection("Data Source=ARDACIMEN\\SQLEXPRESS;Initial Catalog=BankamatikSimulasyon;Integrated Security=True;");

        private void Form2_Load(object sender, EventArgs e)
        {
            lblhesapno.Text = hesap;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from TBLKISILER WHERE HESAPNO=@p1",baglanti);
            komut.Parameters.AddWithValue("@p1", hesap);
            SqlDataReader dr =komut.ExecuteReader();
            while (dr.Read())
            {
                lbladsoyad.Text = dr[1] + " " + dr[2];
                lbltckimlik.Text = dr[3].ToString();
                lbltelefon.Text= dr[4].ToString();


            }
            baglanti.Close();
        }

        private void btngonder_Click(object sender, EventArgs e)
        {
            //Gönderilen Hesabın Para Artısı
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update TBLHESAP SET BAKIYE=BAKIYE+@p1 where hesapno=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1",decimal.Parse(txttutar.Text));
            komut.Parameters.AddWithValue("@p2", mskhesapno.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("İşlem Gerçekleştirildi");


            //Gönderilen Hesabın Para azalısı

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Update TBLHESAP SET BAKIYE=BAKIYE-@k1 where hesapno=@k2", baglanti);
            komut2.Parameters.AddWithValue("@k1", decimal.Parse(txttutar.Text));
            komut2.Parameters.AddWithValue("@k2", hesap);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("İşlem Gerçekleştirildi");
        }
    }
}

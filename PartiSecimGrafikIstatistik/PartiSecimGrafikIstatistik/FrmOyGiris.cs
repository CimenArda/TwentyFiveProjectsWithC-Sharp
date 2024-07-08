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
namespace PartiSecimGrafikIstatistik
{
    public partial class FrmOyGiris : Form
    {
        public FrmOyGiris()
        {
            InitializeComponent();
        }
        //Data Source=ARDACIMEN\SQLEXPRESS;Initial Catalog=DbSecimProje;Integrated Security=True;Trust Server Certificate=True
        SqlConnection baglanti = new SqlConnection("Data Source=ARDACIMEN\\SQLEXPRESS;Initial Catalog=DbSecimProje;Integrated Security=True;");
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnoygiris_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("Insert into TBLILCE (IlceAd,AParti,BParti,CParti,DParti,EParti) values (@p1,@p2,@p3,@p4,@p5,@p6) ", baglanti);

            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txta.Text);
            komut.Parameters.AddWithValue("@p3", txtb.Text);
            komut.Parameters.AddWithValue("@p4", txtc.Text);
            komut.Parameters.AddWithValue("@p5", txtd.Text);
            komut.Parameters.AddWithValue("@p6", txte.Text);


            komut.ExecuteNonQuery();

            baglanti.Close();

            MessageBox.Show("Değerler Eklenmiştir.");
        }

        private void btngrafik_Click(object sender, EventArgs e)
        {
            FrmGrafikler fr =new FrmGrafikler();
            fr.Show();
        }

        private void FrmOyGiris_Load(object sender, EventArgs e)
        {

        }
    }
}

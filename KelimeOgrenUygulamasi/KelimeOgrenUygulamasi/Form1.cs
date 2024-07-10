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
namespace KelimeOgrenUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti =new SqlConnection("Data Source=ARDACIMEN\\SQLEXPRESS;Initial Catalog=KelimeOgren;Integrated Security=True;");
        Random rast =new Random();
        int sure = 90;
        int kelime = 0;



        void Getir()
        {

            int sayi;
            sayi = rast.Next(1, 48);
            lblCevap.Text = sayi.ToString();
            baglanti.Open();

            SqlCommand komut = new SqlCommand("Select * from Tbl_Kelimeler where Id=@p1", baglanti);

            komut.Parameters.AddWithValue("@p1", sayi);
            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {

                txtIngilizce.Text = dr[1].ToString();
                lblCevap.Text = dr[2].ToString();
                lblCevap.Text = lblCevap.Text.ToLower();
            }
            baglanti.Close();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Getir();
            timer1.Start();



        }

        private void txtTürkce_TextChanged(object sender, EventArgs e)
        {
            if (txtTürkce.Text ==lblCevap.Text)
            {
                kelime++;
                lblkelime.Text = kelime.ToString();
                Getir();

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure--;
            lblsure.Text = sure.ToString();
            if (sure== 0)
            {
                txtTürkce.Enabled =false;
                txtIngilizce.Enabled =false;
                timer1.Stop();
            }
        }
    }
}

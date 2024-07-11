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
    public partial class FrmMesajPaneli : Form
    {
        public FrmMesajPaneli()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=ARDACIMEN\\SQLEXPRESS;Initial Catalog=MesajlasmaSistemi;Integrated Security=True;");

        public string numara;

        void gelenKutusu()
        {
            SqlDataAdapter da1 =new SqlDataAdapter("Select * from TBLMESAJLAR Where ALICI ="+numara,baglanti);
            DataTable dt =new DataTable();

            da1.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void gidenKutusu()
        {
            SqlDataAdapter da2 = new SqlDataAdapter("Select * from TBLMESAJLAR Where GONDEREN =" + numara, baglanti);
            DataTable dt2 = new DataTable();

            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;
        }
        private void FrmMesajPaneli_Load(object sender, EventArgs e)
        {
         lblnumara.Text = numara;
            gelenKutusu();
            gidenKutusu();


            //ad soyadı çekme
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select AD,SOYAD from TBLKisiler where NUMARA =@P1", baglanti);
            komut.Parameters.AddWithValue("@P1", numara);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbladsoyad.Text = dr[0] + " " + dr[1];  

            }
            baglanti.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Insert into TBLMESAJLAR(GONDEREN,ALICI,BASLIK,ICERİK) values (@p1,@p2,@p3,@p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", numara);
            komut.Parameters.AddWithValue("@p2", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@p3", textBox1.Text);
            komut.Parameters.AddWithValue("@p4", richTextBox1.Text);

            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Mesaj Gönderildi");

            gidenKutusu();

        }
    }
}

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

namespace BiletRezervasyon_KayitSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void seferlistesi()
        {
            SqlDataAdapter da =new SqlDataAdapter("Select * from TBLSEFERBILGI",baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }



        SqlConnection baglanti = new SqlConnection("Data Source=ARDACIMEN\\SQLEXPRESS;Initial Catalog=BiletRezervasyon&KayitSistemi;Integrated Security=True;");
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut =new SqlCommand("Insert into TBLYOLCUBILGI (AD,SOYAD,TELEFON,TC,CINSIYET,MAIL) VALUES(@P1,@P2,@P3,@P4,@P5,@P6)",baglanti);

            komut.Parameters.AddWithValue("@P1", txtad.Text);
            komut.Parameters.AddWithValue("@P2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@P3", msktel.Text);
            komut.Parameters.AddWithValue("@P4", msktc.Text);
            komut.Parameters.AddWithValue("@P5", cmbcinsiyet.Text);
            komut.Parameters.AddWithValue("@P6", txtmail.Text);

            komut.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("Bilgileriniz Kaydedildi");

        }

        private void btnkaptan_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Insert into TBLKAPTAN (KAPTANNO,ADSOYAD,TELEFON) VALUES (@P1,@P2,@P3)", baglanti);
            komut.Parameters.AddWithValue("@P1", txtkaptanno.Text);
            komut.Parameters.AddWithValue("@P2", txtkaptanad.Text);
            komut.Parameters.AddWithValue("@P3", mskkaptantel.Text);

            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kaptan Bilgisi Sisteme Kaydedildi");


        }

        private void btnseferolustur_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Insert into TBLSEFERBILGI (KALKIS,VARIS,TARIH,SAAT,KAPTAN,FIYAT) VALUES (@P1,@P2,@P3,@P4,@P5,@P6)", baglanti);
            komut.Parameters.AddWithValue("@P1", txtkalkis.Text);
            komut.Parameters.AddWithValue("@P2", txtvaris.Text);
            komut.Parameters.AddWithValue("@P3", msktarih.Text);
            komut.Parameters.AddWithValue("@P4", msksaat.Text);
            komut.Parameters.AddWithValue("@P5", mskkaptan.Text);
            komut.Parameters.AddWithValue("@P6", txtfiyat.Text);

            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Sefer Bilgisi Sisteme Kaydedildi");
            seferlistesi();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            seferlistesi();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtrezervasyonseferno.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtkoltukno.Text = "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtkoltukno.Text = "2";

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtkoltukno.Text = "3";

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtkoltukno.Text = "4";

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtkoltukno.Text = "5";

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtkoltukno.Text = "6";

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtkoltukno.Text = "7";

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtkoltukno.Text = "8";

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtkoltukno.Text = "9";

        }

        private void btnrezervasyonyap_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Insert into TBLSEFERDETAY (SEFERNO,YOLCUTC,KOLTUK) VALUES (@P1,@P2,@P3)",baglanti);

            komut.Parameters.AddWithValue("@P1",txtrezervasyonseferno.Text);
            komut.Parameters.AddWithValue("@P3",txtkoltukno.Text);
            komut.Parameters.AddWithValue("@P2",mskrezervasyonyolcutc.Text);

            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Rezervasyon İşlemi tamamlandı");
        }
    }
}

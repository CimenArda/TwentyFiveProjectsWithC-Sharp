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

namespace Etut_DersKayitSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=ARDACIMEN\\SQLEXPRESS;Initial Catalog=Etut&DersKayitSistemi;Integrated Security=True;");

        void dersListesi()
        {
            SqlDataAdapter da =new SqlDataAdapter("Select * from TBLDERSLER",baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbDers.ValueMember = "DERSID";
            cmbDers.DisplayMember = "DERSAD";
            cmbDers.DataSource= dt;

            cmbOgretmenDers.ValueMember = "DERSID";
            cmbOgretmenDers.DisplayMember = "DERSAD";
            cmbOgretmenDers.DataSource = dt;
        }

        void etutListesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("Exec etutListesi", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource= dt;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dersListesi();
            etutListesi();
        }

        private void cmbDers_SelectedIndexChanged(object sender, EventArgs e)
        {



            SqlDataAdapter da2 =new SqlDataAdapter("Select * from TBLOGRETMEN WHERE BRANSID="+cmbDers.SelectedValue,baglanti);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            cmbOgretmen.ValueMember = "OGRTID";
            cmbOgretmen.DisplayMember = "AD";
            cmbOgretmen.DataSource= dt2;

            
        }

        private void btnEtutOlustur_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("Insert into TBLETUT (DERSID,OGRETMENID,TARIH,SAAT) VALUES (@P1,@P2,@P3,@P4)",baglanti);

            komut.Parameters.AddWithValue("@P1",cmbDers.SelectedValue);
            komut.Parameters.AddWithValue("@P2",cmbOgretmen.SelectedValue);
            komut.Parameters.AddWithValue("@P3",mskTarih.Text);
            komut.Parameters.AddWithValue("@P4",mskSaat.Text);

            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Etüt Oluşturuldu");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtetutId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
        }

        private void btnEtutVer_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update TBLETUT SET OGRENCIID=@P1,DURUM=@P2 WHERE ID=@P3", baglanti);
            komut.Parameters.AddWithValue("@P1", txtOgrenciId.Text);
            komut.Parameters.AddWithValue("@P2", "True");
            komut.Parameters.AddWithValue("@P3", txtetutId.Text);

            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Etüt Öğrenciye Verildi");


        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void btnOgrenciEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert into TBLOGRENCI (AD,SOYAD,FOTOGRAF,SINIF,TELEFON,MAIL) VALUES (@P1,@P2,@P3,@P4,@P5,@P6)", baglanti);
            komut.Parameters.AddWithValue("@P1", TXTAD.Text);
            komut.Parameters.AddWithValue("@P1", TXTSOYAD.Text);
            komut.Parameters.AddWithValue("@P1", pictureBox1.ImageLocation);
            komut.Parameters.AddWithValue("@P1", TXTSINIF.Text);
            komut.Parameters.AddWithValue("@P1", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@P1", TXTMAIL.Text);

            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci Sisteme Kayıt Edildi");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Insert into TBLOGRETMEN (AD,SOYAD,BRANSID) VALUES (@P1,@P2,@P3)", baglanti);
            komut.Parameters.AddWithValue("@P1", txtOgretmenAd.Text);
            komut.Parameters.AddWithValue("@P2", txtOgretmenSoyad.Text);
            komut.Parameters.AddWithValue("@P3", cmbOgretmenDers.SelectedValue);


            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğretmen Sisteme Kayıt Edildi");

        }

        private void cmbOgretmenDers_SelectedIndexChanged(object sender, EventArgs e)
        {
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Insert into TBLDERSLER (DERSAD) VALUES (@P1)", baglanti);
            komut.Parameters.AddWithValue("@P1", txtDersAd.Text);

            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ders Eklendi");
            
        }
    }
}

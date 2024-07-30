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

namespace PastahaneSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti =new SqlConnection("Data Source=ARDACIMEN\\SQLEXPRESS;Initial Catalog=PastahaneSistemi;Integrated Security=True;");

        void malzemeListe()
        {
            SqlDataAdapter da =new SqlDataAdapter("Select * from TBLMALZEMELER",baglanti);
            DataTable dt = new DataTable(); 
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void UrunListesi()
        {
            SqlDataAdapter da2 = new SqlDataAdapter("Select * from TBLURUNLER",baglanti);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView1.DataSource= dt2;
        }
        void kasa()
        {
            SqlDataAdapter da3 = new SqlDataAdapter("Select * from TBLKASA",baglanti);
            DataTable dt3 = new DataTable();

           da3.Fill(dt3);
            dataGridView1.DataSource= dt3;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            malzemeListe();
            urunler();
            malzemeler();
        }

        private void btnUrunListesi_Click(object sender, EventArgs e)
        {
            UrunListesi();
        }

        private void btnMalzemeListesi_Click(object sender, EventArgs e)
        {
            malzemeListe();
        }

        private void btnKasa_Click(object sender, EventArgs e)
        {
            kasa();
        }
        void urunler()
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBLURUNLER", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmburun.ValueMember = "URUNID";
            cmburun.DisplayMember = "AD";
            cmburun.DataSource = dt;    

            baglanti.Close();
        }
        void malzemeler()
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBLMALZEMELER", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbmalzeme.ValueMember = "ID";
            cmbmalzeme.DisplayMember = "AD";
            cmbmalzeme.DataSource = dt;
            baglanti.Close();
        }
        private void btnmalzemeekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut =new SqlCommand("Insert into TBLMALZEMELER(AD,STOK,FIYAT,NOTLAR) VALUES (@P1,@P2,@P3,@P4)",baglanti);
            komut.Parameters.AddWithValue("@P1", txtmalzemeAd.Text);
            komut.Parameters.AddWithValue("@P2", decimal.Parse(txtmalzemestok.Text));
            komut.Parameters.AddWithValue("@P3", decimal.Parse(txtmalzemefiyat.Text));
            komut.Parameters.AddWithValue("@P4", txtmalzemenotlar.Text);

            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Malzeme Eklendi");
        }

        private void btnurunekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Insert into TBLURUNLER(AD) VALUES (@P1)", baglanti);

            komut.Parameters.AddWithValue("@P1", txturunad.Text);

            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün  Eklendi");

            UrunListesi();

        }

        private void btnurunolustur_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Insert into TBLFIRIN(URUNID,MALZEMEID,MIKTAR,MALIYET) VALUES (@P1,@P2,@P3,@P4)", baglanti);
            komut.Parameters.AddWithValue("@P1", cmburun.SelectedValue);
            komut.Parameters.AddWithValue("@P2", cmbmalzeme.SelectedValue);
            komut.Parameters.AddWithValue("@P3", decimal.Parse(txtmiktar.Text));
            komut.Parameters.AddWithValue("@P4", decimal.Parse(txtmaliyet.Text));

            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Malzeme Eklendi");


            listBox1.Items.Add(cmbmalzeme.Text + "-" + txtmaliyet.Text);

        }

        private void txtmiktar_TextChanged(object sender, EventArgs e)
        {
            double maliyet;
            


            if (txtmiktar.Text=="")
            {
                txtmiktar.Text = "0";
            }

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from TBLMALZEMELER where ID=@p1",baglanti);
            komut.Parameters.AddWithValue("@p1", cmbmalzeme.SelectedValue);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtmaliyet.Text = (dr[3].ToString());
            }
            baglanti.Close();

            maliyet = Convert.ToDouble(txtmaliyet.Text) / 1000 * Convert.ToDouble(txtmiktar.Text);

            txtmaliyet.Text = maliyet.ToString();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txturunıd.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txturunad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select SUM(MALIYET) from TBLFIRIN where URUNID=@P1", baglanti);
            komut.Parameters.AddWithValue("@P1", txturunıd.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
               txturunmaliyetfiyat.Text = dr[0].ToString();

            }
            baglanti.Close();
        }
    }
}
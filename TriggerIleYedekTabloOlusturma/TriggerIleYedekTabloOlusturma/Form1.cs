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

namespace TriggerIleYedekTabloOlusturma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti =new SqlConnection("Data Source=ARDACIMEN\\SQLEXPRESS;Initial Catalog=YedekTabloOlusturmaProje16;Integrated Security=True;");

        void Listele()
        {
            SqlDataAdapter da =new SqlDataAdapter("Select * from TBLKITAPLAR",baglanti);
            DataTable dt = new DataTable(); 
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            
        }

        void sayac()
        {
            baglanti.Open();
            SqlCommand komut =new SqlCommand("SELECT * FROM TBLSAYAC",baglanti);

            SqlDataReader DR = komut.ExecuteReader();
            while (DR.Read())
            {
                lblKitapAdet.Text = DR[0].ToString();
            }
            baglanti.Close();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            Listele();
            sayac();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("Insert into TBLKITAPLAR (AD,YAZAR,SAYFA,YAYINEVI,TUR) VALUES (@P1,@P2,@P3,@P4,@P5)", baglanti);
            komut.Parameters.AddWithValue("@P1", txtAd.Text);
            komut.Parameters.AddWithValue("@P2", txtYazar.Text);
            komut.Parameters.AddWithValue("@P3", txtSayfa.Text);
            komut.Parameters.AddWithValue("@P4", TxtYayınevi.Text);
            komut.Parameters.AddWithValue("@P5", txtTur.Text);

            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Kitap Sisteme Eklendi");
            Listele();
            sayac();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtYazar.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtSayfa.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TxtYayınevi.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtTur.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete from TBLKITAPLAR WHERE ID=@P1", baglanti);

            komut.Parameters.AddWithValue("@P1",txtId.Text);
            komut.ExecuteNonQuery();

            baglanti.Close();

            MessageBox.Show("Kitap Sistemden Silindi");
        }
    }
}

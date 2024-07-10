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

namespace MailVeTelefonRehberKayitModulu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=ARDACIMEN\\SQLEXPRESS;Initial Catalog=DbRehber;Integrated Security=True;");


        void Listele()
        {
           DataTable dt = new DataTable();
            SqlDataAdapter da =new SqlDataAdapter("Select * from TBLKISILER",baglanti);

            da.Fill(dt);

            dataGridView1.DataSource = dt;



        }

        void temizle()
        {
            TXTID.Text = "";
            TXTAD.Text = "";
            TXTSOYAD.Text = "";
            TXTMAIL.Text = "";
            MSKTEL.Text = "";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Listele();
        }



        private void BTNEKLE_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Insert into TBLKISILER (AD,SOYAD,TELEFON,MAIL) VALUES (@p1,@p2,@p3,@p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", TXTAD.Text);
            komut.Parameters.AddWithValue("@p2", TXTSOYAD.Text);
            komut.Parameters.AddWithValue("@p3", MSKTEL.Text);
            komut.Parameters.AddWithValue("@p4", TXTMAIL.Text);

            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Ekleme İşlemi Başarılı");
            Listele();
            temizle();
        }
        private void BTNSIL_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete from TBLKISILER WHERE ID=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", TXTID.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Silme İşlemi Başarılı");
            Listele();
            temizle();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TXTID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();   
            TXTAD.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();   
            MSKTEL.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();   
            TXTMAIL.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();   
        }

        private void BTNGUNCELLE_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update TBLKISILER set AD=@P1,SOYAD=@P2,TELEFON=@P3,MAIL=@P4 WHERE ID=@P5", baglanti);
            komut.Parameters.AddWithValue("@P1", TXTAD.Text);
            komut.Parameters.AddWithValue("@P2", TXTSOYAD.Text);
            komut.Parameters.AddWithValue("@P3", MSKTEL.Text);
            komut.Parameters.AddWithValue("@P4", TXTMAIL.Text);

            komut.Parameters.AddWithValue("@P5", TXTMAIL.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("GÜNCELLEME İşlemi Başarılı");
            Listele();
            temizle();

        }
    }
}

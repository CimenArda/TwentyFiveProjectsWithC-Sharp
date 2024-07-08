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
namespace Not_KayitSistemi
{
    public partial class FrmOgretmenDetay : Form
    {
        public FrmOgretmenDetay()
        {
            InitializeComponent();
        }
        SqlConnection bgl = new SqlConnection("Data Source=ARDACIMEN\\SQLEXPRESS;Initial Catalog=DbNotKayit;Integrated Security=True;");

        private void FrmOgretmenDetay_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbNotKayitDataSet.TBLDERS' table. You can move, or remove it, as needed.
            this.tBLDERSTableAdapter.Fill(this.dbNotKayitDataSet.TBLDERS);

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand komut = new SqlCommand("Insert into TBLDERS(OGRNUMARA,OGRAD,OGRSOYAD) values (@p1,@p2,@p3)", bgl);
            komut.Parameters.AddWithValue("@p1", msknumara.Text);
            komut.Parameters.AddWithValue("@p2", txtAd.Text);
            komut.Parameters.AddWithValue("@p3", txtSoyad.Text);

            komut.ExecuteNonQuery();
            bgl.Close();
            MessageBox.Show("Öğrenci Sisteme Kaydedildi.");
            this.tBLDERSTableAdapter.Fill(this.dbNotKayitDataSet.TBLDERS);

        }

        private void btnNotGuncelle_Click(object sender, EventArgs e)
        {
            double ortalama, s1, s2, s3;

            string durum;

            s1 = Convert.ToDouble(txtSınav1.Text);
            s2= Convert.ToDouble(txtSınav2.Text);
            s3 = Convert.ToDouble(txtSınav3.Text);

            ortalama =(s1+ s2+s3) /3;

            lblortalama.Text = ortalama.ToString();

            if (ortalama>=50)
            {
                durum = "True";
            }
            else
            {
                durum = "False";
            }

            bgl.Open();

            SqlCommand komut = new SqlCommand("Update TBLDERS set OGRS1 =@P1,OGRS2=@P2,OGRS3=@P3,ORTALAMA=@P4,DURUM=@P5 WHERE OGRNUMARA =@P6", bgl);
            komut.Parameters.AddWithValue("@P1", txtSınav1.Text);
            komut.Parameters.AddWithValue("@P2", txtSınav2.Text);
            komut.Parameters.AddWithValue("@P3", txtSınav3.Text);
            komut.Parameters.AddWithValue("@P6", msknumara.Text);

            komut.Parameters.AddWithValue("@P4", decimal.Parse(lblortalama.Text));
            komut.Parameters.AddWithValue("@P5", durum);

            komut.ExecuteNonQuery();
            bgl.Close();
            MessageBox.Show("Notlar Güncellenmiştir");
            this.tBLDERSTableAdapter.Fill(this.dbNotKayitDataSet.TBLDERS);


        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtAd.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            msknumara.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();

            txtSınav1.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtSınav2.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtSınav3.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }
    }
}

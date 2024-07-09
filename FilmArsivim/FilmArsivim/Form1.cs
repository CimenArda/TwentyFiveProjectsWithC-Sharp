using CefSharp.WinForms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace FilmArsivim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=ARDACIMEN\\SQLEXPRESS;Initial Catalog=FilmArsivim;Integrated Security=True;");
        ChromiumWebBrowser tarayici;

        void filmler()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBLFILMLER", baglanti);
            DataTable dt = new DataTable();

            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            filmler();
            InitializeChromium();
        }

        private void InitializeChromium()
        {
            tarayici = new ChromiumWebBrowser("");
            this.webBrowser2.Controls.Add(tarayici);
            tarayici.Dock = DockStyle.Fill;
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Insert into TBLFILMLER (AD,KATEGORI,LINK) Values (@p1,@p2,@p3)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtfilmad.Text);
            komut.Parameters.AddWithValue("@p2", txtkategori.Text);
            komut.Parameters.AddWithValue("@p3", txtlink.Text);

            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Film Listenize Eklendi");
            filmler();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            string link = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            tarayici.Load(link);
        }

        private void btnhakkimizda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu Proje Arda Cimen Tarafından 09.07.2024 tarihinde kodlandı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnrenkdegistir_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Color[] renkler = { Color.Red, Color.Blue, Color.Green, Color.Yellow, Color.Orange };

            int index = rnd.Next(renkler.Length);
            this.BackColor = renkler[index];
        }
    }
}

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

namespace PartiSecimGrafikIstatistik
{
    public partial class FrmGrafikler : Form
    {
        public FrmGrafikler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ARDACIMEN\\SQLEXPRESS;Initial Catalog=DbSecimProje;Integrated Security=True;");

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmGrafikler_Load(object sender, EventArgs e)
        {

            //İlçe Adlarını cmbye çekme

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select IlceAd from TBLILCE", baglanti);
            SqlDataReader dr =komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);

            }
            baglanti.Close();


            //Grafiğe Toplam Sonuçları Getirme



        }
    }
}

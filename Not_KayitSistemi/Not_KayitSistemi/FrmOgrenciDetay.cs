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
    public partial class FrmOgrenciDetay : Form
    {
        public FrmOgrenciDetay()
        {
            InitializeComponent();
        }
        public string numara;
        //Data Source=ARDACIMEN\SQLEXPRESS;Initial Catalog=DbNotKayit;Integrated Security=True;Trust Server Certificate=True

        SqlConnection bgl = new SqlConnection("Data Source=ARDACIMEN\\SQLEXPRESS;Initial Catalog=DbNotKayit;Integrated Security=True;");

        private void FrmOgrenciDetay_Load(object sender, EventArgs e)
        {
            lblnumara.Text = numara;

            bgl.Open();
            SqlCommand komut = new SqlCommand("Select * from TBLDERS where OGRNUMARA =@p1",bgl);

            komut.Parameters.AddWithValue("@p1", numara);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbladsoyad.Text = dr[2].ToString() + " " + dr[3].ToString();
                lblsınav1.Text = dr[4].ToString();
                lblsınav2.Text = dr[5].ToString();
                lblsınav3.Text = dr[6].ToString();
                lblortalama.Text = dr[7].ToString();
                lbldurum.Text = dr[8].ToString();
            }
            bgl.Close();
        }
    }
}
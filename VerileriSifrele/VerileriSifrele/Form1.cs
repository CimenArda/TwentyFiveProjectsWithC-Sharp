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
namespace VerileriSifrele
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ARDACIMEN\\SQLEXPRESS;Initial Catalog=VeriTabaniSifrelemeProje13;Integrated Security=True;");

        private void button1_Click(object sender, EventArgs e)
        {
            string AD = txtAd.Text;
            byte[] ADdizi = ASCIIEncoding.UTF8.GetBytes(AD);

            string sifreliAD =Convert.ToBase64String(ADdizi);

            label6.Text = sifreliAD;


            string soyad =txtSoyad.Text;
            byte[] soyaddizi =ASCIIEncoding.UTF8.GetBytes(soyad);
            string sifrelisoyad = Convert.ToBase64String(soyaddizi);


            string mail = txtMail.Text;
            byte[] maildizi = ASCIIEncoding.UTF8.GetBytes(mail);
            string sifrelimail = Convert.ToBase64String(maildizi);


            string sifre = txtSifre.Text;
            byte[] sifredizi = ASCIIEncoding.UTF8.GetBytes(sifre);
            string sifrelisifre = Convert.ToBase64String(sifredizi);


            string hesapno = TxtHesapNo.Text;
            byte[] hesapnodizi = ASCIIEncoding.UTF8.GetBytes(hesapno);
            string sifrelihesapno = Convert.ToBase64String(hesapnodizi);


            baglanti.Open();
            SqlCommand komut = new SqlCommand("Insert into TBLVERILER(AD,SOYAD,MAIL,SIFRE,HESAPNO) values (@p1,@p2,@p3,@p4,@p5)",baglanti);

            komut.Parameters.AddWithValue("@p1", sifreliAD);
            komut.Parameters.AddWithValue("@p2", sifrelisoyad);
            komut.Parameters.AddWithValue("@p3", sifrelimail);
            komut.Parameters.AddWithValue("@p4", sifrelisifre);
            komut.Parameters.AddWithValue("@p5", sifrelihesapno);

            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("VERİLER EKLENDİ");












        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'veriTabaniSifrelemeProje13DataSet.TBLVERILER' table. You can move, or remove it, as needed.
            this.tBLVERILERTableAdapter.Fill(this.veriTabaniSifrelemeProje13DataSet.TBLVERILER);

        }
    }
}

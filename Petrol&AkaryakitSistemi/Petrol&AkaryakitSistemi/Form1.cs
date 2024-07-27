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

namespace Petrol_AkaryakitSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti =new SqlConnection("Data Source=ARDACIMEN\\SQLEXPRESS;Initial Catalog=Petrol&AkaryakitSistemi;Integrated Security=True;");

        void Liste()
        {
            //kursunsuz95

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from TBLBENZIN where PETROLTUR='Kurşunsuz95'", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblkursunsuz95.Text = dr[3].ToString();
                progressBar1.Value = int.Parse(dr[4].ToString());
                lblprogresskursunsuz95.Text = dr[4].ToString();
            }
            baglanti.Close();

            //Kursunsuz97
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select * from TBLBENZIN where PETROLTUR='Kurşunsuz97'", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                lblkursunsuz97.Text = dr2[3].ToString();
                progressBar2.Value = int.Parse(dr2[4].ToString());
                lblprogresskursuz97.Text = dr2[4].ToString();


            }
            baglanti.Close();

            //Euro/Dizel10
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Select * from TBLBENZIN where PETROLTUR='Euro/Dizel10'", baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                lbleurodizel10.Text = dr3[3].ToString();
                progressBar3.Value = int.Parse(dr3[4].ToString());
                lblprogresseurodizel.Text = dr3[4].ToString();


            }
            baglanti.Close();

            //YeniProDizel
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("Select * from TBLBENZIN where PETROLTUR='YeniProDizel'", baglanti);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                lblyeniprodizel.Text = dr4[3].ToString();
                progressBar4.Value = int.Parse(dr4[4].ToString());
                lblprogresyeniprodizel.Text = dr4[4].ToString();


            }
            baglanti.Close();

            //Gaz
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("Select * from TBLBENZIN where PETROLTUR='Gaz'", baglanti);
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                lblgaz.Text = dr5[3].ToString();
                progressBar5.Value = int.Parse(dr5[4].ToString());
                lblprogressgaz.Text = dr5[4].ToString();


            }
            baglanti.Close();


            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("SELECT * FROM TBLKASA", baglanti);
            SqlDataReader dr6 = komut6.ExecuteReader();
            while(dr6.Read())
            {
                lblkasa.Text = dr6[0].ToString();
            }
            baglanti.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Liste();

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            double kursunsuz95, litre, tutar;

            kursunsuz95 = Convert.ToDouble(lblkursunsuz95.Text);
            litre = Convert.ToDouble(numericUpDown1.Value);
            tutar = kursunsuz95 * litre;

            txtkursunsuz95fiyat.Text =tutar.ToString();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            double kursunsuz97, litre, tutar;

            kursunsuz97 = Convert.ToDouble(lblkursunsuz97.Text);
            litre = Convert.ToDouble(numericUpDown2.Value);
            tutar = kursunsuz97 * litre;

            txtkursunsuz97fiyat.Text = tutar.ToString();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            double eurodizel, litre, tutar;

            eurodizel = Convert.ToDouble(lbleurodizel10.Text);
            litre = Convert.ToDouble(numericUpDown3.Value);
            tutar = eurodizel * litre;

            txteurodizelfiyat.Text = tutar.ToString();

        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            double prodizel, litre, tutar;

            prodizel = Convert.ToDouble(lblyeniprodizel.Text);
            litre = Convert.ToDouble(numericUpDown4.Value);
            tutar = prodizel * litre;

            txttxtprodizelfiyat.Text = tutar.ToString();
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            double gaz, litre, tutar;

            gaz = Convert.ToDouble(lblgaz.Text);
            litre = Convert.ToDouble(numericUpDown5.Value);
            tutar = gaz * litre;

            txtgazfiyat.Text = tutar.ToString();
        }

        private void btnDepoDoldur_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value !=0)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Insert into TBLHAREKET(PLAKA,BENZINTURU,LITRE,FIYAT) VALUES (@P1,@P2,@P3,@P4)", baglanti);
                komut.Parameters.AddWithValue("@P1", txtplaka.Text);
                komut.Parameters.AddWithValue("@P2", "Kurşunsuz95");
                komut.Parameters.AddWithValue("@P3",numericUpDown1.Value);
                komut.Parameters.AddWithValue("@P4", Decimal.Parse(txtkursunsuz95fiyat.Text));
                komut.ExecuteNonQuery();

                baglanti.Close();


                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("Update TBLKASA SET MIKTAR =MIKTAR +@P1", baglanti);
                komut2.Parameters.AddWithValue("@P1",Decimal.Parse(txtkursunsuz95fiyat.Text));
                komut2.ExecuteNonQuery();
                baglanti.Close();



                baglanti.Open();
                SqlCommand komut3 = new SqlCommand("Update TBLBENZIN SET STOK=STOK-@P1 WHERE PETROLTUR='Kurşunsuz95'",baglanti);
                komut3.Parameters.AddWithValue("@P1", numericUpDown1.Value);
                komut3.ExecuteNonQuery();

                baglanti.Close();

                MessageBox.Show("Satış Gerçekleşti");

                Liste();


            }

            if (numericUpDown2.Value != 0)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Insert into TBLHAREKET(PLAKA,BENZINTURU,LITRE,FIYAT) VALUES (@P1,@P2,@P3,@P4)", baglanti);
                komut.Parameters.AddWithValue("@P1", txtplaka.Text);
                komut.Parameters.AddWithValue("@P2", "Kurşunsuz97");
                komut.Parameters.AddWithValue("@P3", numericUpDown2.Value);
                komut.Parameters.AddWithValue("@P4", Decimal.Parse(txtkursunsuz97fiyat.Text));
                komut.ExecuteNonQuery();

                baglanti.Close();


                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("Update TBLKASA SET MIKTAR =MIKTAR +@P1", baglanti);
                komut2.Parameters.AddWithValue("@P1", Decimal.Parse(txtkursunsuz97fiyat.Text));
                komut2.ExecuteNonQuery();
                baglanti.Close();



                baglanti.Open();
                SqlCommand komut3 = new SqlCommand("Update TBLBENZIN SET STOK=STOK-@P1 WHERE PETROLTUR='Kurşunsuz97'", baglanti);
                komut3.Parameters.AddWithValue("@P1", numericUpDown2.Value);
                komut3.ExecuteNonQuery();

                baglanti.Close();

                MessageBox.Show("Satış Gerçekleşti");

                Liste();


            }

            if (numericUpDown3.Value != 0)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Insert into TBLHAREKET(PLAKA,BENZINTURU,LITRE,FIYAT) VALUES (@P1,@P2,@P3,@P4)", baglanti);
                komut.Parameters.AddWithValue("@P1", txtplaka.Text);
                komut.Parameters.AddWithValue("@P2", "Euro/Dizel10");
                komut.Parameters.AddWithValue("@P3", numericUpDown3.Value);
                komut.Parameters.AddWithValue("@P4", Decimal.Parse(txteurodizelfiyat.Text));
                komut.ExecuteNonQuery();

                baglanti.Close();


                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("Update TBLKASA SET MIKTAR =MIKTAR +@P1", baglanti);
                komut2.Parameters.AddWithValue("@P1", Decimal.Parse(txteurodizelfiyat.Text));
                komut2.ExecuteNonQuery();
                baglanti.Close();



                baglanti.Open();
                SqlCommand komut3 = new SqlCommand("Update TBLBENZIN SET STOK=STOK-@P1 WHERE PETROLTUR='Euro/Dizel10'", baglanti);
                komut3.Parameters.AddWithValue("@P1", numericUpDown3.Value);
                komut3.ExecuteNonQuery();

                baglanti.Close();

                MessageBox.Show("Satış Gerçekleşti");

                Liste();


            }

            if (numericUpDown4.Value != 0)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Insert into TBLHAREKET(PLAKA,BENZINTURU,LITRE,FIYAT) VALUES (@P1,@P2,@P3,@P4)", baglanti);
                komut.Parameters.AddWithValue("@P1", txtplaka.Text);
                komut.Parameters.AddWithValue("@P2", "YeniProDizel");
                komut.Parameters.AddWithValue("@P3", numericUpDown4.Value);
                komut.Parameters.AddWithValue("@P4", Decimal.Parse(txttxtprodizelfiyat.Text));
                komut.ExecuteNonQuery();

                baglanti.Close();


                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("Update TBLKASA SET MIKTAR =MIKTAR +@P1", baglanti);
                komut2.Parameters.AddWithValue("@P1", Decimal.Parse(txttxtprodizelfiyat.Text));
                komut2.ExecuteNonQuery();
                baglanti.Close();



                baglanti.Open();
                SqlCommand komut3 = new SqlCommand("Update TBLBENZIN SET STOK=STOK-@P1 WHERE PETROLTUR='YeniProDizel'", baglanti);
                komut3.Parameters.AddWithValue("@P1", numericUpDown4.Value);
                komut3.ExecuteNonQuery();

                baglanti.Close();

                MessageBox.Show("Satış Gerçekleşti");

                Liste();


            }

            if (numericUpDown5.Value != 0)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Insert into TBLHAREKET(PLAKA,BENZINTURU,LITRE,FIYAT) VALUES (@P1,@P2,@P3,@P4)", baglanti);
                komut.Parameters.AddWithValue("@P1", txtplaka.Text);
                komut.Parameters.AddWithValue("@P2", "Gaz");
                komut.Parameters.AddWithValue("@P3", numericUpDown5.Value);
                komut.Parameters.AddWithValue("@P4", Decimal.Parse(txtgazfiyat.Text));
                komut.ExecuteNonQuery();

                baglanti.Close();


                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("Update TBLKASA SET MIKTAR =MIKTAR +@P1", baglanti);
                komut2.Parameters.AddWithValue("@P1", Decimal.Parse(txtgazfiyat.Text));
                komut2.ExecuteNonQuery();
                baglanti.Close();



                baglanti.Open();
                SqlCommand komut3 = new SqlCommand("Update TBLBENZIN SET STOK=STOK-@P1 WHERE PETROLTUR='Gaz'", baglanti);
                komut3.Parameters.AddWithValue("@P1", numericUpDown5.Value);
                komut3.ExecuteNonQuery();

                baglanti.Close();

                MessageBox.Show("Satış Gerçekleşti");

                Liste();


            }


        }
    }
}

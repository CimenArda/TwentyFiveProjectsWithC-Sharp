﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlSorgulariCalistirmaUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=ARDACIMEN\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True;");

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = richTextBox1.Text;


            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception)
            {

                MessageBox.Show("Sorgunuzu Kontrol Ediniz!");
                
            }




        }

        private void button2_Click(object sender, EventArgs e)
        {
          

            try
            {
                string sorgu = richTextBox1.Text;
                baglanti.Open();
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Tekrar Listeleyerek Değişiklikleri Görebilirsiniz.");
            }
            catch (Exception)
            {
                MessageBox.Show("Sorgunuzu Kontrol Ediniz!");


            }
        }
    }
}
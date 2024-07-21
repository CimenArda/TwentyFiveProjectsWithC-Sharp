using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResimUzerineYaziYazmaUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string resim;
        private void btnResimSec_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            resim = openFileDialog1.FileName;
            if (resim != "openFileDialog1")
            {
                MessageBox.Show("Resim Seçildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen resim seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        Color renk;
        private void btnRenkSec_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            renk = colorDialog1.Color;

        }

        Bitmap bmp;
        private void btnYazdır_Click(object sender, EventArgs e)
        {
            try
            {
                bmp = new Bitmap(resim);
                Graphics gr = Graphics.FromImage(bmp);
                gr.DrawString(txtMetin.Text, new Font("Microsoft Sans Serif", Convert.ToInt16(txtBoyut.Text), FontStyle.Bold), new SolidBrush(renk), 20, 30);
                pictureBox1.Image = bmp;
            }
            catch (Exception)
            {
                MessageBox.Show("Tüm Bilgiler Girilmelidir", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            
            saveFileDialog1.ShowDialog();
            bmp.Save(saveFileDialog1.FileName);
        }
    }
}

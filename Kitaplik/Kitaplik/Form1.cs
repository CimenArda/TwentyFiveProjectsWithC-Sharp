using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kitaplik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        KitapVT vtSinif = new KitapVT();

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = vtSinif.Liste();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kitap ktpsinif = new Kitap();
            ktpsinif.AD =txtKitap.Text;
            ktpsinif.YAZAR =txtYazar.Text;
            vtSinif.KitapEkle(ktpsinif);

        }
    }
}

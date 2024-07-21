using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListYapisiOgrenmeUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> karakterler = new List<string>();
            karakterler.Add("Mazhar");
            karakterler.Add("Ruhsar");
            karakterler.Add("Menkıbe");
            karakterler.Add("Ali");
            karakterler.Add("Müfit");
            karakterler.Add("Firdevs");

            foreach (var item in karakterler)
            {
                listBox1.Items.Add(item);

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<int> sayilar = new List<int>();
            sayilar.Add(1123);
            sayilar.Add(345);
            sayilar.Add(123);
            sayilar.Add(645);
            sayilar.Add(234);
            sayilar.Add(6567);
            sayilar.Add(1235634);

            foreach (var item in sayilar)
            {
                if (item%5 ==0)
                {
                    listBox2.Items.Add(item);
                }


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<Kisiler> kisi = new List<Kisiler>();

            kisi.Add(new Kisiler()
            {
                ADI="Arda",
                SOYADI="Cimen",
                MESLEKI="Yazılımcı"
            });
            foreach (var item in kisi)
            {
                listBox3.Items.Add(item.ADI + " " +item.SOYADI + " :"+item.MESLEKI);
            }
        }
    }
}

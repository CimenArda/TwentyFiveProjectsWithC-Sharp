using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
namespace RSSIleHaberBasliklariCekme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            XmlTextReader xmlOku = new XmlTextReader("https://www.hurriyet.com.tr/rss/anasayfa");

            while (xmlOku.Read())
            {
                if(xmlOku.Name == "title")
                {
                    listBox1.Items.Add(xmlOku.ReadString());
                }
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            XmlTextReader xmlOku2 = new XmlTextReader("https://www.milliyet.com.tr/rss/rssnew/dunyarss.xml");

            while (xmlOku2.Read())
            {
                if (xmlOku2.Name == "title")
                {
                    listBox1.Items.Add(xmlOku2.ReadString());
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassaParolaGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        int soruno = 0, dogru = 0, yanlis = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode ==Keys.Enter)
            {
                switch (soruno)
                {
                    //Cevap 1 
                    case 1:
                        if (textBox1.Text =="Akdeniz")
                        {
                            A.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                              A.BackColor =Color.Red;
                            yanlis++;
                            label4.Text =yanlis.ToString();
                        }
                        break;
                        //Cevap 2 
                        case 2:
                        if (textBox1.Text =="Bursa")
                        {
                            B.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();

                        }
                        else
                        {
                            B.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                        


                    case 3:
                        if (textBox1.Text == "Cuma")
                        {
                            C.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();

                        }
                        else
                        {
                            B.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;

                    case 4:
                        if (textBox1.Text == "Diyarkabır")
                        {
                            D.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();


                        }
                        else
                        {
                            D.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;

                    case 5:
                        if (textBox1.Text == "Eski")
                        {
                            E.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();


                        }
                        else
                        {
                            E.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;

                    case 6:
                        if (textBox1.Text == "Ferman")
                        {
                            F.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                            yanlis++;
                            label4.Text = yanlis.ToString();


                        }
                        else
                        {
                            F.BackColor = Color.Red;
                        }
                        break;

                    case 7:
                        if (textBox1.Text == "Güneş")
                        {
                            G.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                           


                        }
                        else
                        {
                            G.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;

                    case 8:
                        if (textBox1.Text == "Halı")
                        {
                            H.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            H.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();

                        }
                        break;

                    case 9:
                        if (textBox1.Text == "Isparta")
                        {
                            I.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            I.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;

                    case 10:
                        if (textBox1.Text == "Jandarma")
                        {
                            J.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            J.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;

                    case 11:
                        if (textBox1.Text == "Kayısı")
                        {
                            K.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            K.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;

                    case 12:
                        if (textBox1.Text == "Lale")
                        {
                            L.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            L.BackColor = Color.Red; yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;

                    case 13:
                        if (textBox1.Text == "Mart")
                        {
                            M.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            M.BackColor = Color.Red; yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;

                    case 14:
                        if (textBox1.Text == "Ozan")
                        {
                            O.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            O.BackColor = Color.Red; yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;

                    case 15:
                        if (textBox1.Text == "Pırasa")
                        {
                            P.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            P.BackColor = Color.Red; yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;

                    case 16:
                        if (textBox1.Text == "Ramazan")
                        {
                            R.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            R.BackColor = Color.Red; yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;

                    case 17:
                        if (textBox1.Text == "Tarkan")
                        {
                            T.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            T.BackColor = Color.Red; yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;

                    case 18:
                        if (textBox1.Text == "Umut")
                        {
                            U.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            U.BackColor = Color.Red; yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 19:
                        if (textBox1.Text == "Van")
                        {
                            V.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            V.BackColor = Color.Red; yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;

                    case 20:
                        if (textBox1.Text == "Yıldırım")
                        {
                            Y.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            Y.BackColor = Color.Red; yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;

                    case 21:
                        if (textBox1.Text == "Zeytin")
                        {
                            Z.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            Z.BackColor = Color.Red; yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;



                }



            }
        }

        private void button22_Click(object sender, EventArgs e)
        {

        }

        private void linklabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linklabel1.Text = "İlerle";
            soruno++;
            this.Text =soruno.ToString();

            if (soruno ==1)
            {
                richTextBox1.Text = "Ülkemizin güney kısmındaki kıyı bölgesi ?";
                A.BackColor = Color.Yellow;
            }
            if (soruno ==2)
            {
                richTextBox1.Text = "Yeşilliği ile ünlü Marmara ilimiz ?";
                B.BackColor =Color.Yellow;

            }
            if (soruno==3)
            {
                richTextBox1.Text = "Müslümanların kutsal günü ?";
                C.BackColor = Color.Yellow;

            }
            if (soruno == 4)
            {
                richTextBox1.Text = "Karpuzu İle Ünlü İlimiz ?";
                D.BackColor = Color.Yellow;

            }
            if (soruno == 5)
            {
                richTextBox1.Text = " Yeni Kelimesinin Zıt Anlamlaısı ?";
                E.BackColor = Color.Yellow;

            }
            if (soruno == 6)
            {
                richTextBox1.Text = "Padişahın Emirlerinin Yazılı Hali ?";
                F.BackColor = Color.Yellow;

            }
            if (soruno == 7)
            {
                richTextBox1.Text = "Dünyanın Isı Kaynağı ?";
                G.BackColor = Color.Yellow;

            }
            if (soruno == 8)
            {
                richTextBox1.Text = " Öğrencilerin Kötü Karne Getirince Bakıştıgı eşya ?";
                H.BackColor = Color.Yellow;

            }
            if (soruno == 9)
            {
                richTextBox1.Text = " Gülüyle ünlü ilimiz ?";
                I.BackColor = Color.Yellow;

            }
            if (soruno == 10)
            {
                richTextBox1.Text = " Askeri Bir topluluk ?";
                J.BackColor = Color.Yellow;

            }
            if (soruno == 11)
            {
                richTextBox1.Text = " Malatyanın meşhur meyvesi?";
                K.BackColor = Color.Yellow;

            }
            if (soruno == 12)
            {
                richTextBox1.Text = " Her yıl bahar aylarında  düzenlenen festivali ?";
                L.BackColor = Color.Yellow;

            }
            if (soruno == 13)
            {
                richTextBox1.Text = " Yılın 3. Ayı ?";
                M.BackColor = Color.Yellow;

            }
            if (soruno == 14)
            {
                richTextBox1.Text = " Halk Şairi ?";
                O.BackColor = Color.Yellow;

            }
            if (soruno == 15)
            {
                richTextBox1.Text = " Çocukların çok sevmediği pirinç havuç gibi sebzelerle yapılan yemek ?";
                P.BackColor = Color.Yellow;

            }
            if (soruno == 16)
            {
                richTextBox1.Text = "11 Ayın Sultanı  ?";
                R.BackColor = Color.Yellow;

            }
            if (soruno == 17)
            {
                richTextBox1.Text = " Türkiyenin Mega Starı ?";
                T.BackColor = Color.Yellow;

            }
            if (soruno == 18)
            {
                richTextBox1.Text = " Ümit kelimesinin eş anlamlısı  ?";
                U.BackColor = Color.Yellow;

            }
            if (soruno == 19)
            {
                richTextBox1.Text = "Kahvaltısı İle Ünlü İlimiz ?";
                V.BackColor = Color.Yellow;

            }
            if (soruno == 20)
            {
                richTextBox1.Text = " Şimşek Kelimesinin Eş Anlamlısı  ?";
                Y.BackColor = Color.Yellow;

            }
            if (soruno == 21)
            {
                richTextBox1.Text = "Ege Bölgesininen çok ağacı bulunan yağı da yapılan bir kahvaltı besini ?";
                Z.BackColor = Color.Yellow;

            }























        }
    }
}

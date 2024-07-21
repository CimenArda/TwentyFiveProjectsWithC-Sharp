using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Kitaplik
{
     class KitapVT
    {

        SqlConnection baglanti = new SqlConnection("Data Source=ARDACIMEN\\SQLEXPRESS;Initial Catalog=KitaplikProje24;Integrated Security=True;");



        public List<Kitap> Liste()
        {
            List<Kitap> ktp = new List<Kitap>();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from Kitaplar", baglanti);
            SqlDataReader dr = komut.ExecuteReader();   
            while (dr.Read())
            {
                Kitap k = new Kitap();
                k.ID = Convert.ToInt32(dr[0].ToString());
                k.AD = dr[1].ToString();
                k.YAZAR = dr[2].ToString();

                ktp.Add(k);

            }
            baglanti.Close();

            return ktp;

        }

        public void KitapEkle(Kitap kt)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Insert into Kitaplar(KitapAd,Yazar) values (@p1,@p2)", baglanti);
            komut.Parameters.Add("@p1", kt.AD);
            komut.Parameters.Add("@p2", kt.YAZAR);

            komut.ExecuteNonQuery();
            baglanti.Close();

        }




    }
}

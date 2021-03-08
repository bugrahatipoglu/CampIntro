using System;

namespace CampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety = tip güvenliği
            //do not repeat yourself

            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmiMi = true;
            double dolarDun = 7.55;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }

            if (sistemeGirisYapmiMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");

            }
            else
            {
                Console.WriteLine("Giris Yap Butonu");
            }


            Console.WriteLine(kategoriEtiketi);


        }
    }
}

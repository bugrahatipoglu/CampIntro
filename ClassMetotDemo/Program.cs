using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Sabahattin";
            musteri1.Soyadi = "Ali";
            musteri1.Yasi = 58;
            musteri1.MusteriNo = "111111";
            musteri1.SubeAdi = "Alsancak";

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Franz";
            musteri2.Soyadi = "Kafka";
            musteri2.Yasi = 45;
            musteri2.MusteriNo = "222222";
            musteri2.SubeAdi = "Akyazı";

            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Edip";
            musteri3.Soyadi = "Cansever";
            musteri3.Yasi = 79;
            musteri3.MusteriNo = "333333";
            musteri3.SubeAdi = "Muratpasa";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.Soyadi);
                Console.WriteLine(musteri.Yasi);
                Console.WriteLine(musteri.MusteriNo);
                Console.WriteLine(musteri.SubeAdi);
                Console.WriteLine("-------------");
            }

            Console.WriteLine("-------Metotlar-------");

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri1);
            musteriManager.Sil(musteri2);
            musteriManager.Listele(musteriler);

           
            
        }
    }
}

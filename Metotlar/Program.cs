using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            //type-safe -- tip güvenli
            foreach (Urun urun in urunler) //Urun yerine var da yazılabilir.
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("----------");

            }

            Console.WriteLine("---------Metotlar--------");
            //instance - örnek
            //encapsulation - kapsülleme - düzenli yapı oluşturma

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            //sepetManager.Ekle();
            //sepetManager.Ekle();
            //sepetManager.Ekle();

            sepetManager.Ekle2("Armut", "Yesil Armut", 12,10);
            sepetManager.Ekle2("Elma", "Yesil Elma", 16,9);
            sepetManager.Ekle2("Karpuz", "Beyaz Karpuz", 19,8);

        }
    }
}


// Do not repeat yourself - DRY - Clean Code - Best Practice 
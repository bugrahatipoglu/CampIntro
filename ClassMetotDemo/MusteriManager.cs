using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Musteri sisteme eklendi! : " + musteri.Adi + " " + musteri.Soyadi);
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Musteri sistemden silindi! : " + musteri.Adi + " " + musteri.Soyadi);
        }

        public void Listele(Musteri[] musteri)
        {
            foreach (var customer in musteri)
            {
                Console.WriteLine("Musteriler listelendi! : " + customer.MusteriNo);
            }
            
        }
    }
}

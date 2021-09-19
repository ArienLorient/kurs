using System;

namespace OdevUrunListesi
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.UrunAdi = "RTX 2070";
            urun1.UrunMarkasi = "Nvidia";
            urun1.UrunFiyati = 7500;

            Urun urun2 = new Urun();
            urun2.UrunAdi = "RTX 2080";
            urun2.UrunMarkasi = "Nvidia";
            urun2.UrunFiyati = 8500;

            Urun urun3 = new Urun();
            urun3.UrunAdi = "RTX 2090";
            urun3.UrunMarkasi = "Nvidia";
            urun3.UrunFiyati = 10500;

            Urun[] product = new Urun[] { urun1, urun2, urun3 };
            
            //For Döngüsü

            for (int i = 0; i < product.Length; i++)
            {
                Console.WriteLine(" Urun: " + product[i].UrunAdi + " Marka: " + product[i].UrunMarkasi + " Fiyat: " + product[i].UrunFiyati );
            }

            //Foreach döngüsü
            
            foreach (Urun urun in product)
            {
                Console.WriteLine(" ID: " + urun.UrunAdi + " Marka: " + urun.UrunMarkasi+ "  Fiyat: " + urun.UrunFiyati);
            }

            //while döngüsü

            int x = 0;
            while (x < product.Length)
            {
                Console.WriteLine(" ID: " + product[x].UrunAdi + " Marka: " + product[x].UrunMarkasi + "  Fiyat: " + product[x].UrunFiyati);
                x++;
            }
        }
    }

    class Urun
    {
        public string UrunAdi { get; set; }
        public string UrunMarkasi { get; set; }
        public int UrunFiyati { get; set; }
    }
}

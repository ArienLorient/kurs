using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Yasin";
            musteri1.SoyAdi = "Gül";
            musteri1.TcNo = "12345678910";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "kodlama.io";
            musteri2.VergiNo = "1234567890";

            Musteri musteri3 = new GercekMusteri();     //Musteri class'ı bellekte GercekMusteri class'ının referans numrasını tutabiliyor.
            Musteri musteri4 = new TuzelMusteri();      //Musteri class'ı bellekte TuzelMusteri class'ının referans numrasını tutabiliyor.

            MusteriManager musteriManager = new MusteriManager();   //musteri3 ve 4'üde ekleyebiliriz. Olay tamamen Ref. Tip ile alakalı.
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
        }
    }
}

using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //string = sözel veriler için kullanılır.
            //type safety = tip güvenliği demektir.
            //kategoriEtiketi bir değer tutucudur. Yani bir alias yani takma isimdir.
            //her satırın sonuna ; koyarız ki o satırın bittiğini belirtmiş oluruz.
            string kategoriEtiketi = "Kategori";
            //tam sayı verilerini tutmak için "int" kullanırız.
            int ogrenciSayısı = 32000;
            //double = ondalıklı sayılarımızı tuttuğumuz veri tipidir.
            double faizOrani = 1.57;

            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(ogrenciSayısı);
            Console.WriteLine(faizOrani);

            //bool = iki olasıklık durumlarda kullandığımız şart bloklarını ifade eder.
            //if-else kalıbıdır.
            //Örnek olarak; sisteme giriş  yapıp yapmadığımızı belirten veri tipidir.
            bool sistemeGirisYapmısMı = true;

            if (sistemeGirisYapmısMı == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Sisteme Giriş Yapınız!");
            }

            //bool kavramını 3 farklı durum olan olaylarda da kullanırız.
            double dolarDun = 7.85;
            double dolarBugun = 7.65;

            if (dolarDun>dolarBugun) 
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }
        }
    }
}

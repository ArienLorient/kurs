using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        //Naming convention: Kodlarda yazma kuralıdır.
        //bir yerde () bu parantezden varsa burada bir metod çalışıyor demektir.
        //Parametre: Bize ne ekleyeceğimizi metoda veren birime parametre denir.
        //Ekle'den sonra paranteze işlediğimiz şeylere parametre diyoruz.
        //Bu yazılan kısım metodun şablonudur.
        //void Ekle(Product product): Metodun imzasıdır.
        public void Ekle(Product product) 
        {
            Console.WriteLine("Tebrikler, Sepete Eklendi : " + product.Adi);
        }
        //Bir class içerisinde birden fazla metot tanımlayabiliriz.
        public void Ekle2(string productAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler, Sepete Eklendi : " + productAdi);
        }

        //ekle bu işin en kısa yolu, Ekle2 ise uzun yoludur. Bunu kullanma. Bu olaya encapsulation denir.
        //Encapsulation: Ayrı ayrı yazılan ve düzensiz olan yapıyı bir düzene sokmadır.
    }
}

using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Adi = "Elma";
            product1.Fiyati = 15;
            product1.Aciklama = "Amasya Elması";

            Product product2 = new Product();
            product2.Adi = "Karpuz";
            product2.Fiyati = 80;
            product2.Aciklama = "Diyarbakır Karpuzu";

            //Süslü parantez içinde yazan product1 ve product2nin bilgileri bir veri kaynağından gelir. Gerçek hayatta bunu tek tek yazmayız. Veri kaynağından alırız.
            //diziler çoğul isimlendirilir. Bu yüzden "products" ismini verdik. 
            
            Product[] products = new Product[] {product1, product2 };

            foreach (Product product in products)
            {
                //"in products" kısmında olan bütün elemanları tek tek gez demek.
                //product: Gezilen tüm elemanlara verilen takma isimdir.
                //en başta yazan Product ise veri tipidir. Type-safe bir program olduğu için çalışılan veri tipini belirtiriz.
                // Product yerine kalıpta bulunan "var" kalsa da olur.
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine("--------------");
                //e-ticaret sisteminde de aynı sistemle işleniyor. Sadece ek olarak görsellikler ekleniyor.
            }

            Console.WriteLine("---------------METOTLAR----------------"); //ayırmak için koyduk

            //instance - klas örneği oluşturuyoruz.
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);

            //Encapsulation: Ayrı ayrı yazılan ve düzensiz olan yapıyı bir düzene sokmadır.
            sepetManager.Ekle2("Armut", "Yeşil", 10, 89);
            sepetManager.Ekle2("Elma", "Sarı", 8, 54);
            sepetManager.Ekle2("Kiraz", "Kırmızı", 20, 155);
        }
    }
}

using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //bu şekilde listeleri tek tek yazmıyoruz!!
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya Başlangıç İçin Temel Kurs";
            string kurs3 = "Java Script Geliştirici Kursu";
            string kurs4 = "Python kursu";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);

            //array = dizi; liste yapmak istediğimizde kullandığımız değişken tipidir.

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya Başlangıç İçin Temel Kurs", "Java Script Geliştirici Kursu", "Python kursu", "C++" };
            
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For Bitti");

            //başka bir döngü çeşidi:
            //foreach dizi temelli yapıları tek tek dönmeye yarar. Dizilere uygulanır.
           
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            
            Console.WriteLine("Sayfa Sonu");
        }
    }
}

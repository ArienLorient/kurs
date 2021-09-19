using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //aşağıda tanımladığımız class'ın değişkenini (kurs1) ve değişkenin değerlerini tanımladık.
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmeni = "Yasin GÜL";
            kurs1.İzlenmeOrani = 95;

            //kurs1 ve kurs2 değişkenimizdir, farklı bir şeyde yazabiliriz ama anlamlı olsun diye kurs1/2 diye tanımladık.
            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Python";
            kurs2.Egitmeni = "Yasin GÜL";
            kurs2.İzlenmeOrani = 100;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "C++";
            kurs3.Egitmeni = "Said GÜL";
            kurs3.İzlenmeOrani = 100;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "Java";
            kurs4.Egitmeni = "Eren GÜL";
            kurs4.İzlenmeOrani = 97;

            //böyle yazarak içerisinde Kurs'ları tutabileceğiz.
            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3, kurs4 };      //listemiz burası. İçeriği veri kaynağından çekeriz elimizle işlemeyiz.
            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " - " + kurs.Egitmeni);
            }
        }
    }
    
    //Yeni bir class tanımladık.
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmeni { get; set; }
        public int İzlenmeOrani { get; set; }

    }
}

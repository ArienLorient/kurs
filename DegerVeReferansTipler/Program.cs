using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 40;
            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine(sayi1);

            //Veriler stack ve heap dediğimiz iki farklı yerde tutulur.
            //İlk örnekte verdiğimiz int yani değer tipli veriler stack kısmında saklanır.
            //Stack kısmında sakladığımız bu değerleri birbirine eşitlediğimizde sayi1=40 oldu. ve sayi2 ile işi bitti.
            //sayi2 = 65 dememizin sayi1 üzerinde bir etkisi kalmadı. İlk örneğimizin cevabı bu yüzden 40'tır.

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            Console.WriteLine(sayilar1[0]);

           

            //Referans tip olan arraylarde ise sayilar1 ve sayilar2'nin isimleri stackte depolanır ve "new" ile belirttiğimiz kod kümesi ile birer adet yerde saklanır.
            //Her stackte kayıtlı sayilar elemanının değerleri heap kısmında tutulur. sayilar1=sayilar2 dediğimizde ise heap kısmında sayilar2'ye denk gelen kısıma artık sayilar1'de erişmektedir ve sayilar1'in heap kısmında tutulan değerleri boşa çıkmış olur.
            //sayilar2 nin ilk değerini 999'a eşitlersek sayilar1'in ilk değeride 999 olur ve bu vesile ile ikinci örneğimizin cevabı da 999'dur.



        }
    }
}

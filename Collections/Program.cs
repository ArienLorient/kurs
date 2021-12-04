using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] names = new string[] { "Engin", "Yasin", "Kerem", "Ali" };   //arrayler oluşturduğumuz sınırlar içerisinde kalır. Dizilerde ki en büyük problem genişletilememesidir.
            //Console.WriteLine(names[0]);
            //Console.WriteLine(names[1]);
            //Console.WriteLine(names[2]);
            //Console.WriteLine(names[3]);

            //names = new string[5];  //new diyerek yeni bir 5 elemanlı boş bir liste oluşturduk burada.
            //names[4] = "İlker";
            //Console.WriteLine(names[4]);
            //Console.WriteLine(names[0]);
            ////Names array'ine 5. elemanı eklemek için böyle bir hareket yaptığımızda aslında yeni bir array oluşturmuş oluruz. 9. satırda yer alan listeyi bu yolla genişletemeyiz.

            List<string> names2 = new List<string> {"Engin", "Yasin", "Kerem", "Ali" };
            Console.WriteLine(names2[0]);
            Console.WriteLine(names2[1]);
            Console.WriteLine(names2[2]);
            Console.WriteLine(names2[3]);
            names2.Add("İlker");
            Console.WriteLine(names2[4]);
            Console.WriteLine(names2[0]);

            //collection - array gibi değerleri kaydetmemizi yarayan bir yapıya sahiptir.
        }
    }
}

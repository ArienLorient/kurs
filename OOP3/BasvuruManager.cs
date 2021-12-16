using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices)       //Parantezin içinde yaptığımız metoda Method Injection denir.
        {
            //Burada başvuru için gerekli çeşitli bilgileri alırız.
            //Buraya herhangi bir krediyi yazarsak yazdığımız o kredi türüne bağımlı hale getirmiş oluruz. Bu yüzden bir tane parametre tanımlarız.
            //Tanımladığımız parametre ile kod artık kredilerden bağımsız hale geldi ve kullanılabilirliği arttı.
            krediManager.Hesapla();     //tüm kredileri artık hesaplayabiliriz.
            foreach (var loggerService in loggerServices)   
            {
                loggerService.Log();    //Çoklu loglama yapabilceğiz.
            }        //sistemde hangi loglayıcı seçildiyse onu loglarız.
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            //Burada kredilerin toplu hesaplanmasını veya birbiri ile karşılaştırılmasını sağlıyor. Kaç adet seçeceğimiz belli olmayan durumlar için.
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}

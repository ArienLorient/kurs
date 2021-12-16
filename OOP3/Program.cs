using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bunlar kredilerin tekil olarak hesaplanma işlemi.

            //IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();        //bu komutların hepsinin birer sayfayı temsil ettiğini unutma.
            //ihtiyacKrediManager.Hesapla();
            //IKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();
            //IKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            //Burada ise tüm kredileri tek bir kod ile hesaplayabilmemizi sağlarız.
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            List<ILoggerService> loggers = new List<ILoggerService>() { databaseLoggerService };
            basvuruManager.BasvuruYap(tasitKrediManager, loggers);   //artık tümn kredileri bu kod ile hesaplayabiliriz.
            //basvuruManager.BasvuruYap(tasitKrediManager, new DatabaseLoggerService);  //29. kod basamağının alternatifi - 24 ve 25 kod bloğunu yazmamıza gerek kalmaz.

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, konutKrediManager };

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

            basvuruManager.BasvuruYap(new EsnafKrediManager() , new List<ILoggerService> {new DatabaseLoggerService(), new SmsLoggerService()});
            //new List<ILoggerService> {new DatabaseLoggerService(), new SmsLoggerService()} bunun yerine 28 satırda yazdığımız "loggers"ı da yazsak olurdu.

        }
    }
}

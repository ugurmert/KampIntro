using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Interface'ler de o interface'i implemente eden class'ın referans numarasını tutabiliyor
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService>() { new SmsLoggerService(), new DatabaseLoggerService() };

            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(tasitKrediManager, fileLoggerService);
            //basvuruManager.BasvuruYap(new EsnafKredisiManager(), new SmsLoggerService());
            basvuruManager.BasvuruYap(new EsnafKredisiManager(), loggers);

            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager };
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}

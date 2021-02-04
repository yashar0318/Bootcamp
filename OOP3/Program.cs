 using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager esnafKrediManager = new EsnafKredisiManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(esnafKrediManager,new List<ILoggerService> {databaseLoggerService,smsLoggerService });

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,tasitKrediManager};
            basvuruManager.KrediOnBilgilendirmesiYap(krediler);
           
                
                
                
              
                /*IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            ihtiyacKrediManager.Hesabla();

            TasitKrediManager tasitKrediManager = new TasitKrediManager();
            tasitKrediManager.Hesabla();

            KonutKrediManager konutKrediManager = new KonutKrediManager();
            konutKrediManager.Hesabla();*/

            // IKrediManager de yerine qoysaq olar.Ona gore ki referanslari saxlaya bilir. Interfaceler de o interfacei implement eden classin referans nomresini saxliya bilirmis
        }
    }
}

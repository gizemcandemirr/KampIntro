using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new İhtiyacKrediManager();

            IKrediManager tasitKrediManager = new TasitKrediManager(); //interface onu implament eden classı ref olrak tutabilir.

            IKrediManager evKrediManager = new EvKrediManager();

            ILoggerService dataloggerService = new DatabaseLoggerService();
            ILoggerService fileloggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(evKrediManager, dataloggerService);

            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager };

            //basvuruManager.KrediOnBilgilendirmeYap(krediler);
            
        }
    }
}

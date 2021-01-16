using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyat = 15;
            string Aciklama = "Amasya elması";

            Urun urun1 = new Urun();
            urun1.urunAdi = "Elma";
            urun1.Aciklama = "Amasya'nın";

            Urun urun2 = new Urun();
            urun2.urunAdi = "Karpuz";
            urun2.Fiyat = 80;
            urun2.Aciklama = "Diyarbakır'dan";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urunsecimi in urunler)
            {
                Console.WriteLine(urunsecimi.urunAdi);
                Console.WriteLine(urunsecimi.Aciklama);
            }

            SepetManager urun = new SepetManager();
            urun.Ekle(urun2);
        }
    }
}

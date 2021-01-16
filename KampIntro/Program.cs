using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = { "bu bir", "bu iki", "bu üç", "deneme son" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);

            }
            foreach (var item in kurslar)
            {
                Console.WriteLine(item);
            }
        }
    }
}

using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Halil" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler= new string[5];
            //isimler[4] = "ilker";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);
            //new dediğimiz için bellekte yeni bir alan açtı ve engini yazdırmadı.

            List<string> isimler2 = new List<string> { "Engin", "Murat", "İlker" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            isimler2.Add("Osman");
            Console.WriteLine(isimler2[3]);
            Console.WriteLine(isimler2[0]);

        }
    }
}

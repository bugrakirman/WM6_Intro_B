using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathStringDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            // sistem üzerinde ön tanımlı metodlar vardır en çok kullanılanları

            // matematik fonksiyonları

            Console.WriteLine(Math.Sin(Math.PI / 2));

            //tarih fonksiyonları
            DateTime tarih = DateTime.Now;
            DateTime sonraki = tarih.AddHours(3);
            sonraki = tarih.AddMinutes(new Random().Next());
            TimeSpan fark = sonraki - tarih;
            Console.WriteLine(fark);
            Console.WriteLine(tarih.AddDays(95));

            //metinsel fonksiyonlar
            string a = null;
            a = "5";
            string b = "10";
            a = b; // string ifadeler için immutable ifadesi kullanılır null değer alabilirler.
            b = "20";
            Console.WriteLine(a);

            string kelime = "wissen akademi";
            bool varMi = kelime.Contains("ss");
            //kelime.IndexOf('i');
            //Console.WriteLine(kelime.Remove(3)); 
            string baslik = "  çin hükümeti  ";
            baslik = baslik.ToLower();
            baslik = baslik.Replace(" ", "-");
            baslik = baslik.Replace("ç", "c");
            baslik = baslik.Replace("ü", "u");
            Console.WriteLine(baslik);

            string mailListesi = "asd@asd.com;afr@afr.com;bug@bug.com;";
            string[] mailler = mailListesi.Split(';');
            //baslik.Trim  yanları temizler arayı temizlemez

            Console.WriteLine(kelime.Substring(0,6));

        }
    }
}

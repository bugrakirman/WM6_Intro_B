using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KararYapilariVeDonguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //operatorler
            //matematiksel operatorler
            int sayi1 = 5;
            int sayi2 = 10;
            double sayi3=0;
            sayi1 = sayi1 + sayi2;
            sayi3 = sayi1 / Convert.ToDouble(sayi2); // ya da (sayi2+0d) ya da (double)sayi2

            string sonuc = "taplam:" + sayi3;

            //karşılaştırma operatörleri true ya da false döndürürler  
            bool cevap = sayi1 < sayi2;
            cevap = !cevap;
            //mantıksal operatorler
            bool dogruMu = sayi1 < sayi2 && sayi2 % 2 == 0;

            // if

            if (sayi1 % 2 == 0)
            {
                Console.WriteLine("sayı çifttir");
            }
            else
            {
                Console.WriteLine("sayı tektir");
            }

            int notOrtalama = 55;
            if (notOrtalama < 50)
            {
                Console.WriteLine("kaldın");
            }
            else if (notOrtalama<90)
            {
                Console.WriteLine("gectiniz");
            }
            else
            {
                Console.WriteLine("üstün başarı");
            }

            DayOfWeek bugun = DateTime.Now.DayOfWeek;
            Console.WriteLine(bugun);

            switch (bugun)
            {
                case DayOfWeek.Sunday:
                    Console.WriteLine("pazar");
                    break;
                case DayOfWeek.Monday:
                    Console.WriteLine("p.tesi");
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("salı");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("çarşamba");
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("perşembe");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("cuma");
                    break;
                case DayOfWeek.Saturday:
                    Console.WriteLine("c.tesi");
                    break;                                
            }

            //donguler
            //while (DateTime.Now.Second>30 && DateTime.Now.Second<32)
            //{
            //    //Console.WriteLine(DateTime.Now);
            //    break;
            //}

            //do
            //{
            //    //Console.WriteLine(DateTime.Now);
            //    if (DateTime.Now.Second > 30 && DateTime.Now.Second < 32)
            //        break;
            //} while (true);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            //program çalıştığında ekrana bir doktorun muayene saatlerini yazan program 15er dakikalık aralarla yazacak ve saat 09-16.30 arası olacak 12-13 arası öğle tatili.
            
            for (int saat=9;saat<=16;saat++)
            {
                if (saat == 12)
                    continue;
                for (int dakika = 0; dakika <= 45; dakika = dakika + 15)
                {
                    if (saat == 16 && dakika == 45) break;
                Console.WriteLine(saat.ToString("00")+"."+dakika.ToString("00"));
                }
            }

            DateTime baslangic = new DateTime(2018,11,27,9,0,0);
            do
            {
                if (baslangic.Hour == 12)
                {
                    Console.WriteLine("tatili");
                    baslangic = baslangic.AddHours(1);
                    continue;
                }
                Console.WriteLine(baslangic.ToLongTimeString());
                baslangic = baslangic.AddMinutes(15);
            } while (!(baslangic.Hour == 16 && baslangic.Minute == 45));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Selamlama();
            int toplam=Topla(5,5,5,5,5,5,5,5,5,5,55);
            Console.WriteLine(toplam);
            Console.WriteLine(Disc(1,4,3));
            string[] kisiler = {"kamil" , "karem" };
            Selamlama(kisiler);
        }

        static void Selamlama() //PascalCase
        {
            Console.WriteLine("merhaba");
        }

        static int Topla(int sayi1,int sayi2)
        {
            int toplam = sayi1 + sayi2;
            return toplam;
        }
        static int Topla(params int[] sayilar) //params
        {
            int toplam = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                toplam += sayilar[i];
            }
            return toplam;
        }
        /// <summary>
        /// diskriminant hesaplar
        /// </summary>
        /// <param name="a">a</param>
        /// <param name="b">b</param>
        /// <param name="c">c</param>
        /// <returns>diskrimşnant</returns>
        static string Disc(int a,int b,int c)
        {
            int sonuc = (b * b) - (4*a*c);
            if (sonuc<0)
            {
                return "reel kök yok";
            }
            else if (sonuc==0)
            {
                return "denklemin bir kökü var";
            }
            else
            {
                return "2 reel kökü var";
            }
        }

        static void Selamlama(string[] kisiler)
        {
            foreach (string kisi in kisiler)
            {
                Console.WriteLine("hosgeldin " + kisi); 
            }
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZarOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Random rnd = new Random();
                int giris = 0;
                int sayac = 0;
                int zar1 = 0, zar2 = 0;
                bool dogruMu = false;
                Console.WriteLine("1-6 arasında bir giriş yapın");
                try
                {
                    
                    giris = int.Parse(Console.ReadLine());
                    if (giris<1 || giris>6)
                    {
                        throw new ArgumentException("lütfen 1-6 arası bir giriş yapınız");
                        dogruMu = true;
                        
                        
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
               while (true)
                {
                    sayac++;
                    zar1 = rnd.Next(1, 7);
                    zar2 = rnd.Next(1, 7);
                    Console.WriteLine(sayac + ". denemede: " + zar1 + "-" + zar2);
                    if (zar1 == zar2 && zar1 == giris)
                    {
                        break;
                    }
                }
                if (dogruMu)
                {
                    Console.WriteLine(sayac + ". denemede bulundu");
                }
                

                Console.WriteLine("tekrar oynamak için e ye basınız");
                string cevap = Console.ReadLine();
                if (cevap.ToLower()!="e")
                {
                    break;
                }
            } while (true);
        }
    }
}

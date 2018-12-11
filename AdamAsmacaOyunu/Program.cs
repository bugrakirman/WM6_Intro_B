using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamAsmacaOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                string[] sorular = {"zeytinburnu","kahramanmaraş","çanakkale","hayrabolu" };
                int hak = 6,bilinen=0;
                Random rnd = new Random();
                string seciliSoru = sorular[rnd.Next(sorular.Length)];
                double puan = seciliSoru.Length * 100;
                char[] ekran = new char[seciliSoru.Length];
                for (int i = 0; i < seciliSoru.Length; i++)
                {
                    ekran[i] = '_';
                }
                do
                {
                    foreach (char ee in ekran)
                        Console.Write(ee+" ");
                    string a = string.Format("\n {0}  harf. puan:  {1}. kalan hak:  {2}",seciliSoru.Length,puan,hak);
                    string ozet = $"\n--> {seciliSoru.Length} harf. puan: {puan}. kalan hak: {hak}";
                    Console.WriteLine(ozet);
                    Console.WriteLine("tahmininizi giriniz");
                    string tahmin = Console.ReadLine().ToLower();
                    if (tahmin.Length==1)
                    {
                        bool bildiMi = false,girildiMi=false;
                        for (int j = 0; j < ekran.Length; j++)
                        {
                            if (ekran[j] == tahmin[0])
                            {
                                girildiMi = true;
                                break;
                            }
                        }
                        if(!girildiMi)
                        for (int i = 0; i < seciliSoru.Length; i++)
                        {
                           
                            if (seciliSoru[i]==tahmin[0])
                            {
                                bildiMi = true;
                                ekran[i] = tahmin[0];
                                bilinen++;
                            }
                        }
                        if (!bildiMi)
                        {
                            hak--;
                            puan *= 0.85;
                        }
                    }
                    else
                    {
                        if (tahmin == seciliSoru)
                            break;
                        hak--;
                        puan *= 0.85;
                    }
                } while (hak>0 && bilinen!=seciliSoru.Length);
                if (hak>0)
                {
                    Console.WriteLine("tebrikler bildiniz");
                }
                else
                {
                    Console.WriteLine("bilemediniz");
                }
                Console.WriteLine("tekrar oynamak için e ye basınız");
                if (Console.ReadLine().ToLower() != "e") 
                    break;
            } while (true);
        }
    }
}

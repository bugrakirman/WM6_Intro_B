using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[5];
            sayilar[0] = 5;
            sayilar[1] = 55;
            sayilar[2] = 45;
            sayilar[3] = 15;
            sayilar[4] = 52;

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);
            }

            foreach (int gelen in sayilar)
            {
                Console.WriteLine(gelen);
            }

            string[] kisiler = {"ahmet","kamil","fatma","fisun"};

            double[,] matris = { { 3.14, 5.4 }, { 3, 2 } }; //new double[2,2];
            matris[0, 0] = 3.14;
            matris[0, 1] = 5.4;
            matris[1, 0] = 3;
            matris[1, 1] = 2;

            for (int i = 0; i < matris.GetLength(0); i++)
            {
                for (int j = 0; j < matris.GetLength(1); j++)
                {
                    Console.Write(matris[i,j]+"  ");
                }
                Console.WriteLine();
            }

            string isim = "kamil";
            char aa = isim[0]; 

            Random rnd = new Random();

            matris = new double[10,4];
            for (int i = 0; i < matris.GetLength(0); i++)
            {
                for (int j = 0; j < matris.GetLength(1); j++)
                {
                    matris[i, j] = rnd.NextDouble();
                }
            }
            
            for (int i = 0; i < matris.GetLength(0); i++)
            {
                for (int j = 0; j < matris.GetLength(1); j++)
                {
                    Console.Write(matris[i, j] + " - ");
                }
                Console.WriteLine();
            }

            ArrayList liste = new ArrayList();
            liste.Add(5);
            liste.Add("kamil");
            liste.Add(true);
            liste.Add(3.14);

            //int a = liste[0];

            List<int> listem = new List<int>() { 3,2,5,4};
            listem.Add(5);
            listem.Add(6);

            listem.Remove(0);

            /*
             önceden tanımlı kelimelerin bulunduğu adam asmaca oyunu
             6hak üzerinden oynayacak
             sorudaki harf sayısı * 100 = max puan;
             her yanlış cevap puanın %15i azalacak 
             2çesit kullanıcı girişi olacak 1-harf 2-kelime tahmini
             2cesit oyun bitirme olacak 1-harfleri tek tek bilerek 2.kelime tahmini ile
             ekrana _ _ _ _ _ _ _ _ şeklinde yazacak
             */
        }
    }
}

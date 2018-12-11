using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornekler
{
    class Program
    {
        static void Main(string[] args)
        {

            ////dışarıdan girilen saayı kadar * karakteri kullanarak kare şekli çizme
            //while (true)
            //{
            //    try
            //    {
            //        Console.WriteLine("bir sayı giriniz");
            //        int sayi = Convert.ToInt32(Console.ReadLine());
            //        if (sayi < 1)
            //        {
            //            throw new ArgumentException();
            //        }
            //        for (int i = 0; i < sayi; i++)
            //        {
            //            for (int j = 0; j < sayi; j++)
            //            {
            //                if (i == 0 || i == sayi-1)
            //                {
            //                    Console.Write("* ");
            //                }
            //                else if (j == 0 || j== sayi-1)
            //                {
            //                    Console.Write("* ");
            //                }
            //                else
            //                {
            //                    Console.Write("  ");
            //                }
            //            }
            //            Console.WriteLine();
            //        }
            //        Console.WriteLine("devam etmek istiyorsanız 'D' ye basın");
            //        string harf = Console.ReadLine();
            //        while (true)
            //        {
            //            try
            //            {

            //                if (harf == "D") break;
            //                throw new Exception();
            //            }
            //            catch (Exception)
            //            {
            //                Console.WriteLine("tekrar çizmek için 'D' ye basın");
            //                harf = Console.ReadLine();
            //            }
            //        }
            //        if (harf != "D") break;
            //    }
            //    catch (ArgumentException ex)
            //    {
            //        Console.WriteLine("0 dan büyük bir sayı gir");
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine("lütfen bir sayı giriniz");
            //    }
            //}

            do
            {
                string secim = string.Empty;
                Console.Clear();
                do
                {
                    
                    Console.WriteLine("seçenekler");
                    Console.WriteLine("1-kare çizimi");
                    Console.WriteLine("2-içi boş kare çizimi");
                    Console.WriteLine("3-üçgen çizimi");
                    secim = Console.ReadLine();
                    if (secim == "1" || secim =="2" || secim=="3")
                    {
                        break;
                    }
                    Console.WriteLine("lütfen 1-2-3 seçeneklerinden birini seçiniz");
                } while (true);

                int x = 0;
                Console.WriteLine("uzunluğu giriniz");
                do
                {
                    try
                    {
                        x = int.Parse(Console.ReadLine());
                        if (x<=0)
                        {
                            throw new Exception("pozitif sayı gir");
                        }
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    } 
                } while (true);

                switch (secim)
                {
                    case "1":
                        //kare
                        for (int i = 0; i < x; i++)
                        {
                            for (int j = 0; j < x; j++)
                            {
                                Console.Write("* ");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case "2":
                        //içi boş kare
                        for (int i = 0; i < x; i++)
                        {
                            for (int j = 0; j < x; j++)
                            {
                                if (i==0 || i==x-1 || j == 0 || j == x - 1)
                                {
                                    Console.Write("* ");
                                }
                                else
                                {
                                    Console.Write("  ");
                                }
                            }
                            Console.WriteLine();
                        }
                        break;
                    default:
                        //üçgen
                        for (int i = 1; i <= x; i++)
                        {
                            for (int j = 1; j <= x+i-1; j++)
                            {
                                if (x-i<j)
                                {
                                    Console.Write("* ");
                                }
                                else
                                {
                                    Console.Write("  ");
                                }   
                            }
                            Console.WriteLine();
                        }
                        break;
                }
                Console.WriteLine("tekrar etmek için e tuşuna basınız");
                string cevap = Console.ReadLine();
                if (cevap.ToLower() != "e")
                    break;
            } while (true);
            // üçgenin içini boş yap üçgenin
            // baklava ve içi boşunu 
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputIslemleri
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *    1 dışarıdan bir veri girişi olduğunda (kullancı girişi)
             *    2 dosya okuma şilemi yapıldığında
             *    3 veritabanı işlemlerinde
             *    4 webisteklerde
             *    try-cacth kullanmak zorundasınız
             *    error handling - hata yönetimi
             */

            Console.Write("adınız nedir? :");
            string ad = Console.ReadLine();
            Console.WriteLine("hoşgeldin "+ad);
            Console.Write("yaşnızı girin: ");
            //byte yas = Convert.ToByte(Console.ReadLine());
            try
            {
                byte yas = Convert.ToByte(Console.ReadLine());
                if (yas < 18) Console.WriteLine("güle güle");
                else Console.WriteLine("devam edebilirsin");
            }
            catch (Exception)
            {

                Console.WriteLine("yaşınınz sayı olmalı"); ;
            }

            Console.WriteLine("0-100 arasında sayı gir");
            try
            {
                int girilen = int.Parse(Console.ReadLine());

                if (girilen < 0 || girilen > 100)
                {
                    throw new Exception("0-100 arası gir");
                }
                if (girilen % 2 == 1)
                {
                    throw new ArgumentException();
                }
                Console.WriteLine("girilen sayi " + girilen);
                double sonuc = girilen / girilen;

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("girilen sayı çift olmalı");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("sıfır girme");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           finally
            {
                Console.WriteLine("ben her zaman çalışırım");
            }

            
        }
    }
}

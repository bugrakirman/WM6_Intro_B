using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayiTahmin
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Random rnd = new Random();
                int rastgele = rnd.Next(1, 101) , tahmin = 0 , sayac=0;
                Console.WriteLine("1-100 arası tahmin et");
                do
                {
                    try
                    {
                        tahmin = int.Parse(Console.ReadLine());
                        sayac++;
                        if (tahmin < 1 || tahmin > 100)
                        {
                            throw new ArgumentException("lütfen 1-100 arası bir giriş yapınız");
                        }
                        if (rastgele<tahmin)
                        {
                            Console.WriteLine("aşağı");
                        }
                        else if (rastgele>tahmin)
                        {
                            Console.WriteLine("yukarı");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("tebrikler "+sayac+". denemede buldunuz");
                        }
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                } while (true);

                Console.WriteLine("tekrar oynamak için e ye basınız");
                string cevap = Console.ReadLine();
                if (cevap.ToLower() != "e")
                {
                    break;
                }
            } while (true);
        }
    }
}

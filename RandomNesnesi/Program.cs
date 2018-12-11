using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNesnesi
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(rnd.Next(-10,11)); //-10 dahil 11 hariç
            }

            //dışarıdan 1-6 arasında girilen sayı üzerinden bir zar oyunu oynanacak
            // 5 girildi diyelim 5-5 gelene kadar zar atılacak kaç deneede gelecek
            //
            // 0-100 arası sayı aklından tutacak ve kullanıcıdan bilmesini isteyecek yukarı aşağı bildin 


        }
    }
}

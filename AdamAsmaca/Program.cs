using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamAsmaca
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {

                string[] sorular = { "istanbul", "mercimek", "bilgisayar", "ornitorenk" };
                

                Random rnd = new Random();
                int rastgele = rnd.Next(0, 4);
                char[] kelime = sorular[rastgele].ToCharArray();
                char[] cevap2 = new char[sorular[rastgele].Length];
                for (int i = 0; i < sorular[rastgele].Length; i++)
                {
                    Console.Write("_ ");
                }
                Console.WriteLine();

                try
                {
                    Console.WriteLine("Harf veya kelime giriniz her yanlış max puanınızın %15ini götürür");
                    
                    do
                    {
                        string girilen = Console.ReadLine();
                        for (int i = 0; i < sorular[rastgele].Length; i++)
                        {
                            if (girilen == Convert.ToString(kelime[i]))
                            {
                                cevap2[i] = kelime[i];
                                Console.WriteLine("teb");
                            }
                            

                        }
                    } while (true);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
               


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

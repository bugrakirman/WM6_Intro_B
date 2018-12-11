using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            //PascalCase
            //camelCase

            //isimlendirme kuralları
            //isimler rakam ile başlayamaz ama bulundurabilir
            //özel karakter barındıramaz _ hariç
            //tanımlı komutların ismi kullanılamaz
            //aynı namespace üzerinde tanımlanmış aynı değişken ismi bir daha kullanılama

            //tamsayı tipler
            byte degiskenByte = 255; //8bit
            sbyte degiskensByte = -128;
            short degiskenShort = 32000; //16bit
            ushort degiskeUshort= 65535;
            int degiskenInt = 2147483647; //32bit
            uint degiskenUint = 4147483647;
            long degiskenLong = long.MaxValue; //64bit
            ulong degiskenUlong = ulong.MaxValue;

            //degiskenInt = degiskenShort;
            //degiskenShort = Convert.ToInt16(degiskenLong);
            //Console.WriteLine(degiskenShort);

            //ondalıklı tipler
            float degiskenFloat = 3.14f;
            double degiskenDouble = 3.14;
            decimal degiskenDecimal = 3.14m;

            degiskenInt = 0b1011;
            degiskenInt = 0x2e;
            degiskenDouble = 3.01e10;
            Console.WriteLine(degiskenInt);

            //metinsel tipler
            char degiskenChar = '3';
            string degiskenString = "Hello World";

            //mantıksal ifade
            bool dogruMu = false;

            DateTime suan = DateTime.Now;
            suan = new DateTime(2018,11,26);

            object degiskenObject = suan;
            degiskenObject = degiskenInt;

            var query = degiskenInt * degiskenDouble;
        }
    }
}

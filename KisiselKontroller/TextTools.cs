using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisiselKontroller
{
    public static class TextTools // class static yapılırsa new alınamaz ve içine yazdığınız her şey static olmalı
    {
        public static string OkunusuGetir(this int sayi) // satatic metodda this yazınca extension olarak ekliyor
        {
            if (sayi < 0 || sayi > 9999)
                throw new Exception("sayi 0-9999 arası olmalı");

            if (sayi == 0)
                return "sifir";

            string[] basamak1 = { "","bir", "iki", "uc", "dort", "bes", "altı", "yedi", "sekiz", "dokuz" };
            string[] basamak10 = { "","on", "yirmi", "otuz", "kirk", "elli", "altmıs", "yetmis", "seksen", "doksan" };

            string basamak100 = "yüz";
            string basamak1000 = "bin";

            int birler, onlar, yuzler, binler = 0;
            birler = sayi % 10;
            onlar = ((sayi % 100) - birler) / 10;
            yuzler = ((sayi % 1000) - onlar - birler) / 100;
            binler = ((sayi % 10000) - yuzler - onlar - birler) / 1000;

            string okunus = string.Empty;
            if (binler > 1)
                okunus += basamak1[binler] + basamak1000;
            else if (binler == 1)
                okunus += basamak1000;

            if(yuzler>1)
                okunus += basamak1[yuzler] + basamak100;
            else if (yuzler == 1)
                okunus += basamak100;

            okunus += basamak10[onlar];
            okunus += basamak1[birler];
            return okunus;
        }
    }
}

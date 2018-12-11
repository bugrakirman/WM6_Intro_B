using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodlar2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2cm olan karenin alanı: "+AlanHesapla(2));
            Console.WriteLine();
            float r = 5;
            Console.WriteLine(AlanHesapla(r));
        }
        // method overloading
        static int AlanHesapla(int a)
        {
            return a * a;
        }

        static int AlanHesapla(int a,int b)
        {
            return a * b;
        }

        static double AlanHesapla(double a,double b)
        {
            return a * b;
        }

        static double AlanHesapla(int a, double b)
        {
            return a * b;
        }

        static double AlanHesapla(float r, double pi=Math.PI)
        {
            double rr = Convert.ToDouble(r*r);
            return rr * pi;
        }

        //ref out parametlerini araştır.
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soyut.Lib
{
    public abstract class Sekil
    {
        public double X { get; set; }
        // abstract nesnelerin örnegi(instance) alinamaz
        //icerisinde abstract olmayan nesneler aynen aktarılır.
        public abstract double CevreHesapla(); // sekil den kalıtım alanlar mutlaka soyutlaştırılmış CevreHesapla 
        //metodunun uygun halini yazmalı
        public abstract double AlanHesapla();
        public abstract double KosegenHesapla();
    }
}

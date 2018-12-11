using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri.Lib
{
    public class Dikdortgen : Sekil
    {
        public int Y { get; set; }

        public override double AlanHesapla()
        {
            return X * Y;
        }
        public override double CevreHesapla()
        {
            return 2*(X+Y);
        }
        public override double KosegenHesapla()
        {
            return Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2)); 
        }
    }
}

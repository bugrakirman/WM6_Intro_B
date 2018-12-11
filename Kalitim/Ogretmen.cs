using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
{
    public class Ogretmen : Kisi
    {
        public Branslar Brans { get; set; } // { get; set; } şeklinde yazınca arkada field var ama araya giremiyoruz
        public decimal Maas { get; set; } 

        private int falan = 0;

        public Ogretmen()
        {
            instanceDate = DateTime.Now;
        }
        public Ogretmen(string ad) : base(ad)
        {
            instanceDate = DateTime.Now;
        }
    }
}

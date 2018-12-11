using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
{
    class SefOgretmen : Ogretmen
    {
        public double KatSayi { get; set; }

        public SefOgretmen()
        {
            instanceDate = DateTime.Now;
        }
    }
}

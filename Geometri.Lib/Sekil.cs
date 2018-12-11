using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri.Lib
{
    public abstract class Sekil
    {
        /*
         kalıtım olarak taşınmasını istiyoruz ama ulaşılabilmesini istemiyorsak abstract olarak tanımlarız
        */
        public double X { get; set; }
        /*
         * virtual keywordu override edebilmemizi saglamakta eger override edilmezse base classda yazıldığı gibi
         * çalışır override edildikten sonra override edilmis classdan kalitim alinirsa kalitim alan class override
         * edilmis halini kalitim alır. iisterse kendisi tekrar override eder.
         */
        public virtual double CevreHesapla()
        {
            return 4 * X;
        }
        public virtual double AlanHesapla()
        {
            return Convert.ToInt32(Math.Pow(X,2));
        }
        public virtual double KosegenHesapla()
        {
            return Math.Sqrt(2) * X;
        }
    }
}

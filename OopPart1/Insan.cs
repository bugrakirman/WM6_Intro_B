using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPart1
{
    class Insan
    {
        /*
         *erişim belirleyiciler Access Modifiers
         *alanlar Fields
         *yapıcı metodlar Constructor
         *özellikler Properties
         *methodlar
         * delege
         * event
         * destructors yıkıcılar
         * *kalıtım- inheritance
         * *polimorphism çok biçiçmlilik
         * 
         */

        //erişim belirleyiciler
        /*
         * private - aynı scope ve alt scope iiçinde erişm yapılan nesneler
         * tanımlanan tüm degisken ve metodlar onune yazılmasa dahi private olarak çalışır
         * internal - aynı namespace içerisinden erisime açıktır. class interface enum(private olamaz) default deger internldır
         * public -  farklı namespacelerden erişim için kullanılır
         * 
         * *protected
         * *protected internal
         */

        //fields
        /* 
         * bir nesnenin içerisinde veri tutan alanlardır
         * 
         */

        private int _yas;
        private DateTime _dogumTarihi;

        public Insan(int yas)
        {
            this._yas = yas; // this bulunduğu sınıfı temsil eder o anki referansa erişimde kullanılır
        }

        public Insan()
        {
            DateTime date = DateTime.Now;
            
        }
        // encapsulation oldschool (daha kolay yolu aşağıda get-set)
        public void setYas(int yas)
        {
            if (yas<=0)
                throw new Exception("yas 0dan buyuk olmali");
            
            this._yas = yas;
        }

        public int getYas()
        {
            return this._yas;
        }
        // property (ft. encapsulation)
        public int Yas
        {
            get  // Ya da get { return DateTime.Now.Year- _dogumTarihi.Year;} 
                //ya da { return this.YasHesapla(_dogumTarihi.Year)}
            {
                return this._yas;
            }
            set
            {
                if (value <= 0)
                    throw new Exception("yas 0dan buyuk olmali");
                this._yas = value;
            }
        }

        public DateTime DogumTarihi
        {
            set
            {
                if (DateTime.Now.Year-value.Year<18)
                {
                    throw new Exception("18 yaşından küçüksün");
                    this._yas = DateTime.Now.Year - value.Year;
                    this._dogumTarihi = value;
                }
            }
        }

        private void YasHesapla(int year) => DateTime.Now.Year - year;




    }
}

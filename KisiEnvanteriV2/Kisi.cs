using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace KisiEnvanteriV2
{
    public class Kisi
    {
        private string _ad, _soyad, _telefon, _email, _tckn;

        public string Ad
        {
            get
            {
                return this._ad;
            }
            set
            {
                NameValid(value, "Ad");
                this._ad = value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower();
            }
        }

        public string Soyad
        {
            get
            {
                return this._soyad;
            }
            set
            {
                NameValid(value, "Soyad");
                this._soyad = value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower();
            }
        }

        public string Telefon
        {
            get
            {
                return this._telefon;
            }
            set
            {
                if (!value.StartsWith("0"))
                    throw new Exception("hata");
                if (value.Length != 11)
                    throw new Exception("hata");
                foreach (char harf in value)
                {
                    if (!char.IsDigit(harf))
                    {
                        throw new Exception("hata");
                    }
                }
                this._telefon = value;
            }
        }

        public string Email
        {
            get
            {
                return this._email;
            }
            set
            {
                Regex rgx = new Regex(@"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$");
                if (!rgx.IsMatch(value))
                {
                    throw new Exception("hata");
                }
                this._email = value;
            }
        }
        public string TCKN
        {
            get
            {
                return this._tckn;
            }
            set
            {
                if (value.Length != 11)
                {
                    throw new Exception("hata");
                }
                foreach (char harf in value)
                {
                    if (!char.IsDigit(harf))
                    {
                        throw new Exception("hata");
                    }
                }
                this._tckn = value;
            }
        }

        public byte[] Fotograf { get; set; }
        private void NameValid(string value, string propertyName)
        {
            foreach (char harf in value)
            {
                if (!(char.IsLetter(harf) || char.IsWhiteSpace(harf)))
                {
                    throw new Exception($"{propertyName} sadece harf ve bosluklarla yapılmalıdır");
                }
            }
        }

        public override string ToString()
        {
            return $"{this.Ad} {this.Soyad}";
        }
    }
}


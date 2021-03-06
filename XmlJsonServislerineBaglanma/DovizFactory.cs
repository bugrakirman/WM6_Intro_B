﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XmlJsonServislerineBaglanma
{
    public class DovizFactory
    {
        private static List<Doviz> _dovizler;
        public static List<Doviz> Dovizler
        {
            get
            {
                _dovizler = new List<Doviz>();
                XElement xElement;
                try
                {
                    xElement = XElement.Load("https://www.tcmb.gov.tr/kurlar/today.xml");
                }
                catch (Exception ex)
                {

                    throw ex;
                }

                //IEnumerable<XElement> currencies = from k in xElement.Elements()
                //                 where k.Element("CurrencyName") != null &&
                //                       k.Attribute("Kod").Value != "XDR"
                //                 select k;
                // ya da --> kurlar

                var kurlar = xElement.Elements().Where(k => k.Element("CurrencyName") != null && k.Attribute("Kod").Value != "XDR").Select(k => k);

                foreach (XElement element in kurlar)
                {
                    _dovizler.Add(new Doviz()
                    {
                        Ad = element.Element("Isim").Value,
                        Kod = element.Attribute("Kod").Value,
                        Birim = int.Parse(element.Element("Unit").Value),
                        Alis = decimal.Parse(element.Element("ForexBuying").Value.Replace('.',',')),
                        Satis = decimal.Parse(element.Element("ForexBuying").Value.Replace('.', ','))
                    }); //anonim nesne
                }
                return _dovizler;
            }
        }
    }
}

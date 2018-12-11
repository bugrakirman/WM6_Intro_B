using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace XmlJsonServislerineBaglanma
{
    class FourFactory
    {
        public const string clientID = "ME13CKX4CQ0LABKGF4GHQDRAQK33KOZ15ZCR3HD1YVZJMXPF";
        public const string clientSecret = "URB4PQ1UDDRBP0FLNLURSODTVCREQ52A1EOENZDT2FTJKKTC";
        public const string apiUrl = "https://api.foursquare.com/v2/venues/search?";
        public string categoryCode = "4f04af1f2fb6e1c99f3db0bb";
        public int radius = 2000;
        public string latitude = "41.0446062";
        public string longitude = "29.0063537";

        string queryUrl = string.Empty;
        public string JsonString = string.Empty;
        public FourFactory()
        {
            queryUrl = apiUrl;
            queryUrl += "client_id=" + clientID;
            queryUrl += "&client_secret=" + clientSecret;
            queryUrl+="&v="+$"{DateTime.Now:yyyyMMdd}";
            queryUrl += $"&ll={latitude},{longitude}";
            queryUrl += "&radius=" + radius;
            queryUrl += "&categoryId=" + categoryCode;
            GetVenues(queryUrl);
        }
        private async void GetVenues(string query)
        {
            HttpClient client = new HttpClient();
            try
            {
                JsonString = await client.GetStringAsync(query);
                // ya da await ve async i sil ve client.GetStringAsync(query).Result kullan
            }
            catch (Exception ex)
            {
                throw ex;
            }

            
        }
        public List<Four.Venue> Firmalar { get => FirmalariDoldur(); }

        private List<Four.Venue> FirmalariDoldur()
        {
            Four sonuc = JsonConvert.DeserializeObject<Four>(JsonString);
                return sonuc.response.venues.ToList();
        }
    }
}

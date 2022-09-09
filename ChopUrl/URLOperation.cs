using ChopUrl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace ChopUrl
{
    public class URLOperation
    {
        // public static URL ShortenURL(string strLngURL)
        //{
        //    Uri lngUrl = new Uri(strLngURL);
        //    string host = lngUrl.Host;
        //    URL urlToShort = new URL();
        //    try
        //    {
        //        StringBuilder sbURL = new StringBuilder(host + "/" + UrlToken(strLngURL));
        //        urlToShort.LongUri = lngUrl;
        //        urlToShort.ShortUri = sbURL.ToString();

        //        dbOpration.Add(urlToShort);
        //    }
        //    catch (Exception ex)
        //    {
                
        //    }
        //    return urlToShort;
        //}

        public string GenerateShortURL(int seed)
        {
            throw new NotImplementedException();
        }

        public int RestoreSeedFromString(string str)
        {
            throw new NotImplementedException();
        }
    }
}
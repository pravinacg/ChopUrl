using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace ChopUrl
{
    // WORK in PRogreess
    //This will created short URL and also returns same when decoded.
    public class GenerateFix : IShortenerService
    {
        public static readonly string Alphabet = "abcdefghijklmnopqrstuvwxyz0123456789";
        public static readonly int Base = Alphabet.Length;
        
        public  string RestoreURLFromString(string strUrl)
        {
            double i=0;
            foreach (var c in strUrl)
            {
                i = Char.GetNumericValue(c);
            }

            if (i == 0) return Alphabet[0].ToString();

            var s = string.Empty;

            while (i > 0)
            {
                //s += Alphabet[int (i % Base)];
                //i = i / Base;
            }

            return string.Join(string.Empty, s.Reverse());
        }

        public string GenerateShortURL(string strUrl)
        {
            StringBuilder sbURL = new StringBuilder();
            var i = 0;

            foreach (var c in strUrl)
            {
                i = (i * Base) + Alphabet.IndexOf(c);
            }

            sbURL.Append(i.ToString());
            return sbURL.ToString();
        }
    }
}
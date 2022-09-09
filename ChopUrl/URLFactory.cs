using ChopUrl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace ChopUrl
{
    public class URLFactory
    {
        public static IShortenerService ShortenURL(int type)
        {
            IShortenerService typ = null;
            if (type == 0)
            {
                typ = new GenerateRandom();
                    
                
            }
            else
            {
                typ = new GenerateFix();
            }
            return typ;
        }
    }
}
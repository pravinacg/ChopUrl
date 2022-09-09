using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChopUrl
{
    public interface IShortenerService
    {
        string RestoreURLFromString(string strUrlToRestore);
        string GenerateShortURL(string strUrlToShorten);

    }
}
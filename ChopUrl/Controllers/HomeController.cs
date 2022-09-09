using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using ChopUrl.Models;
using LiteDB;
using HttpPostAttribute = System.Web.Mvc.HttpPostAttribute;

namespace ChopUrl.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string longUriStr)
        {
            URL urlToShort = new URL();
            IList<URL> lstURL = new UrlController().GetALLURL();
            ViewBag.listUrl = lstURL;
            if (longUriStr != null)
            {
                urlToShort = new UrlController().GetShorten(longUriStr);
               
                
            }
            return View(urlToShort);

        }

        
        

        
    }
}

using ChopUrl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace ChopUrl.Controllers
{
    public class UrlController : ApiController
    {
        // GET api/<controller>
        //API GetShorten method 

        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/ URL to shorten
        //Shorts URL and add save it in db if not exists
        public URL GetShorten(string strLngURL)
        {
          
            URL urlToShort = new URL();
            IShortenerService ClsUrlToShort = URLFactory.ShortenURL(0);
            urlToShort.ShortUri = ClsUrlToShort.GenerateShortURL(strLngURL);
            urlToShort.LongUri = new Uri(strLngURL); ;
            if (dbOpration.Add(urlToShort) != true)
            {
                ModelState.AddModelError(nameof(urlToShort.LongUri), "URI Already exists");
            }
            return urlToShort;
        }

        // GET api/<controller>/ URL to shorten
        //REturns all URL added by user , Now it will show all the URL
        public List<URL> GetALLURL()
        {

            List<URL> lstURL = dbOpration.GetAll();
            return lstURL;
        }




        // POST api/<controller>
        public void Post([FromBody] string value)
        {
           // ShortenURL(value);
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }

       


    }
}
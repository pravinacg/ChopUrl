using ChopUrl.Models;
using LiteDB;
using LiteDB.Engine;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace ChopUrl
{
    // This Can be middleware in future 
    //Adds records in DB

    public class dbOpration
    {
        private static string strcon = ConfigurationManager.ConnectionStrings["LiteDB"].ConnectionString;

        public static bool Add(URL urlToInsert)
        {
           
            bool isSuccess = false;
            try
            {
                using (var db = new LiteDatabase(strcon))
                {
                    var collection = db.GetCollection<URL>("URL");
                    var urlExist = collection.Find(x => x.LongUri == urlToInsert.LongUri);
                    if (urlExist.Count() == 0)
                    {
                        collection.Insert(urlToInsert);
                        isSuccess = true;
                    }

                }
            }
            catch(Exception ex)
            {

            }
            return isSuccess;
        }

        public static List<URL> GetAll()
        {
            var URLToReturn = new List<URL>();
            using (var db = new LiteDatabase(strcon))
            {
                var URLs = db.GetCollection<URL>("URL");
                var results = URLs.FindAll();
                foreach (URL url in results)
                {
                    URLToReturn.Add(url);
                }
                return URLToReturn;
            }
        }

        public static List<URL> FindById(string urlToFind)
        {
            var URLToReturn = new List<URL>();
            using (var db = new LiteDatabase(strcon))
            {
                var URLs = db.GetCollection<URL>("URL");
                var results = URLs.Find(urlToFind);
                   foreach (URL url in results)
                    {
                        URLToReturn.Add(url);
                    }
                
                return URLToReturn;
            }
        }
    }
}
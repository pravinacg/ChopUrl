using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LiteDB;



namespace ChopUrl.Models
{
    public class URL
    {
        [BsonId]
        public int Id { get; set; }
        public Uri LongUri { get; set; }
        public string ShortUri { get; set; }
        public string UserName { get; set; }

    }
}

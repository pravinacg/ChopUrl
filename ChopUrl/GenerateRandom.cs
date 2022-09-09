using ChopUrl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace ChopUrl
{
    //This class genertes random token of 
     class GenerateRandom : IShortenerService
    {
        public static readonly string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        public static readonly int Base = Alphabet.Length;

        private static List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
        private static List<char> characters = new List<char>()
            {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n',
            'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B',
            'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P',
            'Q', 'R', 'S',  'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '-', '_'};
        
        public string RestoreURLFromString(string strURL)
        {
            string URLToReturn = "";
            var results = dbOpration.GetAll();
            foreach (URL url in results.Take(1))
            {
                URLToReturn = url.LongUri.ToString();
            }
            return URLToReturn;
        }

        public string GenerateShortURL(string strLngURL)
        {
            StringBuilder sbURL = new StringBuilder();
            Random rand = new Random();
            // run the loop till I get a string of 10 characters  
            for (int i = 0; i < 11; i++)
            {
                // Get random numbers, to get either a character or a number...  
                int random = rand.Next(0, 3);
                if (random == 1)
                {
                    // use a number  
                    random = rand.Next(0, numbers.Count);
                    sbURL.Append(numbers[random].ToString());

                }
                else
                {
                    random = rand.Next(0, characters.Count);
                    sbURL.Append(characters[random].ToString());

                }
            }
            return sbURL.ToString();
        }
    }
}
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace PizzaShop.Infrastructure.Data
{
    public class Client
    {
        public List<Dictionary<string, List<string>>> GetToppings()
        {
            var url = "http://files.olo.com/pizzas.json";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";

            try
            {
                using WebResponse response = request.GetResponse();
                using Stream strReader = response.GetResponseStream();
                if (strReader == null) return null;
                using StreamReader objReader = new StreamReader(strReader);
                string toppings = objReader.ReadToEnd();
                var myDetails = JsonConvert.DeserializeObject<List<Dictionary<string, List<string>>>>(toppings);

                return myDetails;
            }
            catch (WebException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

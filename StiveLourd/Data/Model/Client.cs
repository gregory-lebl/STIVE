using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StiveLourd.Data.Model
{
    public class Client
    {
        public string id { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string phoneNumber { get; set; }
        public string address { get; set; }
        public string cp { get; set; }
        public string city { get; set; }
        public string customerReference { get; set; }

        public Client() { }
        public bool PostNewCustomer()
        {
            var client = new RestClient("https://localhost:44395");
            var request = new RestRequest("/customer​/new", Method.Post);

            string json = JsonConvert.SerializeObject(this);
            request.AddParameter("application/json; charset=utf-8", json, ParameterType.RequestBody);
            request.AddJsonBody(json);
            request.RequestFormat = DataFormat.Json;
            try
            {
                client.ExecuteAsync(request);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }

    
}

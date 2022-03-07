using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StiveLourd.Pages//StiveLourd.Model
{

    public class Article
    {
        public string id { get; set; }
        public string anneeId { get; set; }
        public int? annee { get; set; }
        public string capacityId { get; set; }
        public string capacity { get; set; }
        public string cepageId { get; set; }
        public string cepage { get; set; }
        public string familyId { get; set; }
        public string family { get; set; }
        public string supplierId { get; set; }
        public string supplier { get; set; }
        public string name { get; set; }
        public string Ref { get; set; }
        public string description { get; set; }
        public double unitPrice { get; set; }
        public string picture { get; set; }
        public string StockId { get; set; }

        public string stock { get; set; }




        public Article() { }
        public bool PostNewProduct()
        {
            var client = new RestClient("https://localhost:44395");
            var request = new RestRequest("/article​/new", Method.Post);

            string json = JsonConvert.SerializeObject(this);
            request.AddParameter("application/json; charset=utf-8", json, ParameterType.RequestBody);
            request.AddJsonBody(json);
            request.RequestFormat = DataFormat.Json;
            try
            {
                client.Execute(request);
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace STIVE_API.Helpers
{
    public class PurchaseHelper
    {
        public static async Task<string> PurchasePostRequest(Guid id, int Quantity, int Limit, int Provision)
        {
            if(Quantity < Limit)
            {

                var values = new Dictionary<string, string>
                {
                    {"id", id.ToString() },
                    {"Quantity", Quantity.ToString() },
                };
                var content = new FormUrlEncodedContent(values);
                HttpClient client = new HttpClient();
                string endpoint = "https://localhost:44395/api/purchaseOrder";
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = await client.PostAsync(endpoint, content);


                return await response.Content.ReadAsStringAsync();
            } else
            {
                return "false";
            }

        }
    }
}

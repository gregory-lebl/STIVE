using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using STIVE_WEB.Models.Articles;
using STIVE_WEB.Models.Orders;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace STIVE_WEB.Controllers
{
    public class CartController : Controller
    {
        static HttpClient client = new HttpClient();
        private string BaseUrl = "https://localhost:44395";

        /// <summary>
        /// Affiche le panier contenant tous les articles
        /// </summary>
        public async Task<IActionResult> CheckoutAsync()
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("Cart")))
            {
                return View();
            }
            else
            {
                string[] articlesId = HttpContext.Session.GetString("Cart").Split(",");
                List<Article> articlesList = new List<Article>();

                foreach (var id in articlesId)
                {
                    string endpoint = BaseUrl + "/api/article/" + id;

                    HttpResponseMessage response = await client.GetAsync(endpoint);

                    if (response.IsSuccessStatusCode)
                    {
                        Article article = await response.Content.ReadAsAsync<Article>();

                        articlesList.Add(article);
                    }


                }

                return View(articlesList);
            }
        }
        /// <summary>
        /// Supprime un article du panier via son ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public RedirectResult DeleteItemFromCheckout(string id)
        {
            var session = HttpContext.Session.GetString("Cart");
            var toto = id;

            return Redirect("/Cart/Checkout");
        }
        /// <summary>
        /// Créer une nouvelle commande en base de données
        /// </summary>
        public void ConfirmOrder(string jsonOrder)
        {

            List<TestOrder> orderList = JsonConvert.DeserializeObject<List<TestOrder>>(jsonOrder);

            string endpoint = BaseUrl + "";

            foreach (TestOrder order in orderList)
            {
                
            }

            //List<TestOrder> toto = JsonSerializer.Deserialize<List<TestOrder>>();

            var session = HttpContext.Session.GetString("customerId");
            

        }


    }
}

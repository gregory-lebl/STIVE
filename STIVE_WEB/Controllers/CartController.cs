using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using STIVE_WEB.Models.Articles;
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

                    Article article = await response.Content.ReadAsAsync<Article>();
                    
                    articlesList.Add(article);
                }

                return View(articlesList);
            }
        }
    }
}

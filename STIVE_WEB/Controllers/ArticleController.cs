using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using STIVE_WEB.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace STIVE_WEB.Controllers
{
    public class ArticleController : Controller
    {
        static HttpClient client = new HttpClient();
        private string BaseUrl = "https://localhost:44395";

        /// <summary>
        /// Liste tous les articles
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> All()
        {
            string endpoint = BaseUrl + "/api/article";

            HttpResponseMessage response = await client.GetAsync(endpoint);

            List<Article> articles = await response.Content.ReadAsAsync<List<Article>>();

            return View(articles);
        }
        /// <summary>
        /// Ajoute un produit dans la session
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ViewResult AddToCart(string id)
        {
            //Penser à supprimer la vue, elle sert que pour les test
            HttpContext.Session.SetString("Cart", id);

            var session = HttpContext.Session.Get("Cart");

            var data = HttpContext.Session.GetString("Cart");

            return View(session);

                //@objectinfo.print
            
        }


    }
}

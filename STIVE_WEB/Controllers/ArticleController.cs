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
        /// Ajoute un produit dans la session Cart qui gère le panier
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public RedirectResult AddToCart(string id)
        {

            if (string.IsNullOrEmpty(HttpContext.Session.GetString("Cart")))
            {
                //Création de la session "Cart" contenant l'id des articles ajoutés au panier
                HttpContext.Session.SetString("Cart", id);
            }
            else
            {
                //Si elle existe, ajouter l'id à la suite avec une "," comme separateur
                var currentSessionValue = HttpContext.Session.GetString("Cart");
                var currentId = id;
                var newSessionValue = currentSessionValue + "," + id; //Récupération de l'ancienne string de la session et ajout du nouvelle id dans la session

                HttpContext.Session.Clear(); //Je supprime la session actuelle
                HttpContext.Session.SetString("Cart", newSessionValue); //Je recrée nouvelle session contenant la nouvelle string d'id
            }

            return Redirect("/article/All");
        }
    }
}

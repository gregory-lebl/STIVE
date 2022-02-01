using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using STIVE_WEB.Models.Articles;
using STIVE_WEB.Models.Orders;
using System;
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

            articles.ForEach(
                async (article) => await CompleteArticleAsync(article)
            );

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

        /// <summary>
        /// Récupère les données qui manquent pour créer un article complet
        /// - annee
        /// - capacity
        /// - cepage
        /// - family
        /// - supplier
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public async Task<Article> CompleteArticleAsync(Article Article)
        {
            var anneeId = Article.AnneeId;
            var capacityId = Article.CapacityId;
            var cepageId = Article.CepageId;
            var familyId = Article.FamilyId;
            var supplierId = Article.SupplierId;

            //Récupération de l'année de l'article
            var endpointAnnee = BaseUrl + "/api/annee/" + anneeId;
            HttpResponseMessage responseAnnee = await client.GetAsync(endpointAnnee);
            Annee annee = await responseAnnee.Content.ReadAsAsync<Annee>();
            Article.Annee = annee;

            //Récupération de la capacité de l'articlesdsd

            //Récupération Cepage de l'article
            var endpointCepage = BaseUrl + "/api/cepage/" + cepageId;
            HttpResponseMessage responseCepage = await client.GetAsync(endpointCepage);
            Cepage cepage = await responseCepage.Content.ReadAsAsync<Cepage>();
            Article.Cepage = cepage;

            //Récupération Family de l'article - la route n'existe pas encore
            /*
                var endpointFamily = BaseUrl + "/api/family/" + familyId;
                HttpResponseMessage responseFamily = await client.GetAsync(endpointFamily);
                Family family = await responseFamily.Content.ReadAsAsync<Family>();
                Article.Family = family;
             */

            //Récupération du fournisseur de l'article - la route n'existe pas encore
            /*
                var endpointSupplier = BaseUrl + "/api/supplier/" + supplierId;
                HttpResponseMessage responseSupplier = await client.GetAsync(endpointSupplier);
                Supplier supplier = await responseSupplier.Content.ReadAsAsync<Supplier>();
                Article.Supplier = supplier;
             */

            return Article;
        }
    }
}

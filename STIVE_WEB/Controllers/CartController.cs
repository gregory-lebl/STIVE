using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace STIVE_WEB.Controllers
{
    public class CartController : Controller
    {
        /// <summary>
        /// Affiche le panier contenant tous les articles
        /// </summary>
        public IActionResult Checkout()
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("Cart")))
            {
                return View();
            }
            else
            {
                var sessionData = HttpContext.Session.GetString("Cart");


                return View();
            }
        }
    }
}

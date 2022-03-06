using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using STIVE_WEB.Models.Users;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace STIVE_WEB.Controllers
{
    public class UserController : Controller
    {
        static HttpClient client = new HttpClient();
        private string BaseUrl = "https://localhost:44395";
        
        public ActionResult LoginForm()
        {
            return View();
        }

        public ActionResult RegisterForm()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateNewCustomerAsync(IFormCollection collection, Customer customer)
        {
            Customer newCustomer = customer;

            if(customer.Password != customer.PasswordVerify)
            {
                ViewData["errorMessage"] = "Les mots de passe ne correspondent pas";
                return View("RegisterForm");
            }
            else
            {

                if (await CheckIfCustomerExistAsync(customer.Email) == false)
                {
                    string endpointApi = BaseUrl + "/api/customer/new2";
                    var client = new HttpClient();

                    await client.PostAsJsonAsync(endpointApi, newCustomer);

                    ViewData["successMessage"] = "Votre compte a bien été créé, vous pouvez vous connecter";
                }
                else
                {
                    ViewData["errorMessage"] = "Un utilisateur avec cette adresse email existe déjà.";
                }

                return View("RegisterForm");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> GetUserAsync(string email, string password)
        {

            string endpoint = BaseUrl + "/api/customer";

            HttpResponseMessage response = await client.GetAsync(endpoint);

            List<Customer> customers = await response.Content.ReadAsAsync<List<Customer>>();

            if (customers.Find(o => o.Email == email) != null)
            {
                Customer customer = customers.Find(o => o.Email == email);
                HttpContext.Session.SetString("customerId", customer.Id);

            }
            else
            {
                ViewData["errorMessage"] = "Utilisateur introuvable";
                return View("loginForm","User");
            }

            return RedirectToAction("Index", "Home");
        } 
        /// <summary>
        /// Vérifie si un utilisateur existe déjà en base de données
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public async Task<bool> CheckIfCustomerExistAsync(string email)
        {
            string endpoint = BaseUrl + "/api/customer";

            HttpResponseMessage response = await client.GetAsync(endpoint);

            List<Customer> customers = await response.Content.ReadAsAsync<List<Customer>>();

            if (customers.Find(o => o.Email == email) != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

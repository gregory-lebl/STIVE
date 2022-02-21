using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using STIVE_WEB.Models.Users;
using System;
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
                string endpointApi = BaseUrl + "/api/customer/new2";
                var client = new HttpClient();

                await client.PostAsJsonAsync(endpointApi, newCustomer);

                ViewData["successMessage"] = "Votre compte a bien été créé, vous pouvez vous connecter";
                return View("RegisterForm");
            }
        }


        // GET: UserController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UserController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

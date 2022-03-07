using Microsoft.AspNetCore.Mvc;
using STIVE_WEB.Models.Orders;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace STIVE_WEB.Controllers
{
    public class SupplierController : Controller
    {
        private string BaseUrl = "https://localhost:44395";

        // GET: SupplierController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SupplierController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateAsync(Supplier supplier)
        {
            Supplier newSupplier = supplier;
            string endpointApi = BaseUrl + "/api/supplier/new2";
            var client = new HttpClient();

            await client.PostAsJsonAsync(endpointApi, newSupplier);

            return View();
        }

    }
}

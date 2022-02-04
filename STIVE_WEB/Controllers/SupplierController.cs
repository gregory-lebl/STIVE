﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using STIVE_WEB.Models.Orders;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace STIVE_WEB.Controllers
{
    public class SupplierController : Controller
    {
        private string BaseUrl = "https://localhost:44395";

        // GET: SupplierController
        public ActionResult Index()
        {
            return View();
        }

        // GET: SupplierController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SupplierController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SupplierController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public Boolean Create(Supplier supplier)
        {
            Supplier newSupplier = supplier;
            string jsonSupplier = JsonSerializer.Serialize(newSupplier);
            string endpointApi = BaseUrl + "/api/supplier/new";
            endpointApi += "&Name=" + supplier.Name;
            endpointApi += "&Address=" + supplier.Adress;
            endpointApi += "&Cp=" + supplier.Cp;
            endpointApi += "&City=" + supplier.City;
            endpointApi += "&Siret=" + supplier.Siret;
            endpointApi += "&PhoneNumber=" + supplier.PhoneNumber;
            

            endpointApi = endpointApi.Replace(" ", "%20");
            var client = new HttpClient();

            //client.PostAsJsonAsync(endpointApi, new StringContent(jsonSupplier, Encoding.UTF8, "application/json"));
            var response = client.GetAsync(endpointApi);

            return true;
        }

            // GET: SupplierController/Edit/5
            public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SupplierController/Edit/5
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

        // GET: SupplierController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SupplierController/Delete/5
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

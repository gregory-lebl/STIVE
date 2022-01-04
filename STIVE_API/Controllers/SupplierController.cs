using Microsoft.AspNetCore.Mvc;
using STIVE_API.Data;
using STIVE_API.Data.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;

namespace STIVE_API.Controllers
{
    [Route("api/supplier")]
    [ApiController]
    public class SupplierController : Controller
    {
        
        [HttpGet]
        public IEnumerable<Supplier> Get()
        {
            using (var db = new StiveDbContext())
            {
                var suppliers = db.Supplier.ToList();
                return suppliers;
            }
        }
        [HttpGet("{id}")]
        public Supplier GetAll(Guid id)
        {
            using(var db = new StiveDbContext())
            {
                var supplier = db.Supplier.Single(o => o.SupplierId == id);
                return supplier;

            }
        }

        [HttpPost("new")]
        public ActionResult Post(string Name, string Address, string Cp, string City, string Siret, string PhoneNumber)
        {

            var supplier = new Supplier(Name, Address, Cp, City, Siret, PhoneNumber);
            using (var db = new StiveDbContext())
            {
                db.Supplier.Add(supplier);
                try
                {
                    db.SaveChanges();
                    return Ok();
                }
                catch (System.Exception)
                {
                    throw;
                }
            }
        }
    }
}

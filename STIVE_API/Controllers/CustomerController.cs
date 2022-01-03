using Microsoft.AspNetCore.Mvc;
using STIVE_API.Data;
using STIVE_API.Data.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace STIVE_API.Controllers
{
    [Route("api/customer")]
    [ApiController]
    public class CustomerController : Controller
    {
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            using (var db = new StiveDbContext())
            {
                var customers = db.Customers.ToList();
                return customers;

            }
        }

        [HttpGet("{id}")]

        public Customer Get(Guid id)
        {
            using (var db = new StiveDbContext())
            {
                var customer = db.Customers.Single(o => o.Id == id);
                return customer;
            }

        }

        [HttpPost("new")]
        public ActionResult Post(string LastName, string FirstName, string Address, string Cp, string City, string Email, string PhoneNumber, string Password)
        {

            var customer = new Customer(LastName, FirstName, Email, Password, PhoneNumber, Address, Cp, City);

            using (var db = new StiveDbContext())
            {
                db.Customers.Add(customer);
                try
                {
                    db.SaveChanges();
                    return Ok();
                }
                catch (System.Exception ex)
                {
                    Console.WriteLine(ex);
                    throw;
                }
            }
        }

        [HttpPut("{id}")]
        public ActionResult UpdateAccountElements(Customer elem)
        {
            try
            {
                using (var db = new StiveDbContext())
                {
                    var customer = db.Customers.Single(o => o.Id == elem.Id);
                    if (customer != null)
                    {
                        if(elem.LastName != null) customer.LastName = elem.LastName ;
                        if (elem.FirstName != null) customer.FirstName = elem.FirstName;
                        if (elem.PhoneNumber != null) customer.PhoneNumber = elem.PhoneNumber;
                        if (elem.Email != null) customer.Email = elem.Email;
                        if (elem.Address != null) customer.Address = elem.Address;
                        if (elem.City != null) customer.City = elem.City;
                        if (elem.Cp != null) customer.Cp = elem.Cp;

                        db.SaveChanges();
                        return Ok();
                    }
                    return NotFound();
                }
            }
            catch (System.Exception)
            {
                throw;
            }

        }
        [HttpPut("{id}/password")]
        public ActionResult UpdatePassword(Customer elem)
        {
            try
            {
                using (var db = new StiveDbContext())
                {
                    var customer = db.Customers.Single(o => o.Id == elem.Id);
                    if (customer != null)
                    {

                        Console.WriteLine(elem);

                        return Ok();
                    }
                    return NotFound();
                }
            }
            catch (System.Exception)
            {
                throw;
            }

        }
    }
}

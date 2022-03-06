using Microsoft.AspNetCore.Mvc;
using STIVE_API.Data;
using STIVE_API.Data.Models.Users;
using STIVE_API.Helpers;
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
        public ActionResult Post(string LastName, string FirstName, string Address, string Cp, string City, string Email, string PhoneNumber, string Password, string PasswordVerify)
        {

            var customer = new Customer(LastName, FirstName, Email, Password, PhoneNumber, Address, Cp, City);

            if(!PasswordHelper.CheckPasswordVerify(Password, PasswordVerify)) return BadRequest("Les mot de passe sont différents. Veuillez recommencer.");

            using (var db = new StiveDbContext())
            {
                db.Customers.Add(customer);
                try
                {
                    db.SaveChanges();
                    return Ok("Le client a bien été ajouté. Sa Référence est : " + customer.CustomerReference);
                }
                catch (System.Exception)
                {
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
                        return Ok("Les informations ont bien été modifiées.");
                    }
                    return NotFound("Aucune correspondance. Veuillez réessayer.");
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

                        return Ok("Le mot de passe a bien été changé.");
                    }
                    return NotFound("Aucune correspondance. Veuillez Réessayer");
                }
            }
            catch (System.Exception)
            {
                throw;
            }

        }

        [HttpDelete("{id}")]
        public ActionResult DeleteCustomer(Guid id)
        {

            using (var db = new StiveDbContext())
            {
                try
                {
                    var customer = db.Customers.Single(o => o.Id == id);
                    if (customer != null)
                    {
                        db.Customers.Remove(customer);
                        db.SaveChanges();
                        return Ok("L'élement a bien été supprimé.");

                    }
                    return NotFound("Aucune correpondance. Veuillez Réessayer.");

                }
                catch (System.Exception)
                {
                    throw;
                }
            }

        }
    }
}

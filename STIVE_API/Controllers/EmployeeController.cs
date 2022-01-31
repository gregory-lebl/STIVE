
using Microsoft.AspNetCore.Mvc;
using STIVE_API.Data;
using STIVE_API.Data.Models.Users;
using STIVE_API.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace STIVE_API.Controllers
{
    [Route("api/employee")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            using(var db = new StiveDbContext())
            {
                var employees = db.Employee.ToList();
                return employees;
            }

        }

        [HttpGet("{id}")]
        public Employee Get(Guid id)
        {
            using (var db = new StiveDbContext())
            {
                var employee = db.Employee.Find(id);
                return employee;
            }
        }

        [HttpPost("new")]
        public ActionResult Post(string LastName, string FirstName, string Email, string Password, string PhoneNumber, string Address, string Cp, string City, string PasswordVerify)
        {
            var employee = new Employee(LastName, FirstName, Email, Password, PhoneNumber, Address, Cp, City);

            if (!PasswordHelper.CheckPasswordVerify(Password, PasswordVerify)) return BadRequest();

            using (var db = new StiveDbContext())
            {
                db.Employee.Add(employee);
                try
                {
                    db.SaveChanges();
                    return Ok("Le nouvel employé a bien été créé.");
                }
                catch (System.Exception)
                {
                    throw;
                }
            }
        }

        [HttpPut("{id}")]
        public ActionResult UpdateAccountElements(Employee elem)
        {
            try
            {
                using (var db = new StiveDbContext())
                {
                    var employee = db.Employee.Single(o => o.Id == elem.Id);
                    if (employee != null)
                    {
                        if (elem.LastName != null) employee.LastName = elem.LastName;
                        if (elem.FirstName != null) employee.FirstName = elem.FirstName;
                        if (elem.PhoneNumber != null) employee.PhoneNumber = elem.PhoneNumber;
                        if (elem.Email != null) employee.Email = elem.Email;
                        if (elem.Address != null) employee.Address = elem.Address;
                        if (elem.City != null) employee.City = elem.City;
                        if (elem.Cp != null) employee.Cp = elem.Cp;

                        db.SaveChanges();
                        return Ok("Les informations ont bien été changées.");
                    }
                    return NotFound("L'employé recherché n'a pas été trouvé");
                }
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteEmployee(Guid id)
        {

            using (var db = new StiveDbContext())
            {
                try
                {
                    var employee = db.Employee.Single(o => o.Id == id);
                    if (employee != null)
                    {
                        db.Employee.Remove(employee);
                        db.SaveChanges();
                        return Ok("L'employé a bien été supprimé");

                    }
                    return NotFound("L'employé recherché n'a pas été trouvé");

                }
                catch (System.Exception)
                {
                    throw;
                }
            }

        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using STIVE_API.Data;
using STIVE_API.Data.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
    }
}

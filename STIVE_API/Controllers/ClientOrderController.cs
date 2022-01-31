using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using STIVE_API.Data;
using STIVE_API.Data.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace STIVE_API.Controllers
{
    [Route("api/clientOrder")]
    [ApiController]
    public class ClientOrderController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<ClientOrder> Get()
        {
            using (var db = new StiveDbContext())
            {
                var clientOrders = db.ClientOrder.ToList();
                return clientOrders;
            }
        }

        [HttpGet("{id}")]
        public ClientOrder Get(Guid id)
        {

            using (var db = new StiveDbContext())
            {
                var clientOder = db.ClientOrder.Single(o => o.ClientOrderId == id);
                return clientOder;
            }

        }

        [HttpPost("new")]
        public ActionResult Post()
        {
            using (var db = new StiveDbContext())
            {

                // Create Status of Order

                // Create Client Order 

                // Foreach article Create one row 
                return NotFound();
            }

            
        }

       

    }
}

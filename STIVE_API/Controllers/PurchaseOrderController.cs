using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using STIVE_API.Data;
using STIVE_API.Data.Models.Orders;
using STIVE_API.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace STIVE_API.Controllers
{
    [Route("api/purchaseOrder")]
    [ApiController]
    public class PurchaseOrderController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<PurchaseOrder> Get()
        {
            using (var db = new StiveDbContext())
            {
                var orders = db.PurchaseOrder.ToList();
                return orders;
            }
           
        }

        [HttpGet("{id}")]
        public PurchaseOrder Get(Guid id)
        {
            using (var db = new StiveDbContext())
            {
                var query = db.Set<PurchaseOrder>().Include(o => o.SupplierId);
                var order = query.Single(o => o.PurshaseOrderId == id);
                return order;
            }

        }

    }
}

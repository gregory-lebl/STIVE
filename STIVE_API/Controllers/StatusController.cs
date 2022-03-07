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
    [Route("api/status")]
    [ApiController]
    public class StatusController : ControllerBase
    {

        [HttpPost("new")]
        public Status Post(Status status)
        {
            using (var db = new StiveDbContext())
            {
                db.Status.Add(status);
                try
                {
                    db.SaveChanges();
                    return status;
                }
                catch (System.Exception)
                {
                    throw;
                }
            }

        }

    }

    
}

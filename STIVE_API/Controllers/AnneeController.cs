using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using STIVE_API.Data;
using STIVE_API.Data.Models.Articles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace STIVE_API.Controllers
{
    [Route("api/annee")]
    [ApiController]
    public class AnneeController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Annee> Get()
        {
            using (var db = new StiveDbContext())
            {
                var annees = db.Annee.ToList();
                return annees;
            }
        }

        [HttpGet("{id}")]
        public Annee Get(Guid id)
        {
            using (var db = new StiveDbContext())
            {
                var annees = db.Annee.Find(id);
                return annees;

            }
        }

        [HttpPost("new")]
        public Annee Post(Annee annee)
        {
            using (var db = new StiveDbContext())
            {
                db.Annee.Add(annee);
                try
                {
                    db.SaveChanges();
                    return annee;
                }
                catch (System.Exception)
                {
                    throw;
                }
            }
        }


         [HttpDelete("{id}")]
        public ActionResult Delete(Guid id)
        {
            using (var db = new StiveDbContext())
            {
               try
               {
                   var annee = db.Annee.Single(o => o.AnneeId == id);
                    Console.WriteLine(annee);
                   if(annee != null)
                   {
                       db.Annee.Remove(annee);
                       db.SaveChanges();
                       return Ok("L'élement a bien été supprimé.");
                   }
                   return BadRequest("L'élement recherché n'existe pas.");
               }
               catch (System.Exception)
               {
                    throw;
               }  
            }
        }
    }
}

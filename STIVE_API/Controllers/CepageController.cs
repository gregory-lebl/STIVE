using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using STIVE_API.Data;
using STIVE_API.Data.Models.Articles;
using System;
using System.Collections.Generic;
using System.Linq;


namespace STIVE_API.Controllers
{
    [Route("api/cepage")]
    [ApiController]
    public class CepageController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<Cepage> Get()
        {
            using(var db = new StiveDbContext())
            {
                var cepages = db.Cepage.ToList();
                return cepages;
            }
        }

        [HttpGet("{id}")]
        public Cepage Get(Guid id)
        {

            using(var db = new StiveDbContext())
            {
                var cepages = db.Cepage.Single(o => o.CepageId == id);
                return cepages;
            }

        }

        [HttpPost("new")]
        public Cepage Post(Cepage cepage)
        {
            using (var db = new StiveDbContext())
            {
                db.Cepage.Add(cepage);
                try
                {
                    db.SaveChanges();
                    return cepage;
                }
                catch (System.Exception)
                {
                    throw;
                }
            }
            
        }

        [HttpPut("{id}")]
        public ActionResult Put(Cepage elem)
        {
            try
            {
                using (var db = new StiveDbContext())
                {
                    var cepage = db.Cepage.Single(o => o.CepageId == elem.CepageId);
                    if(cepage != null)
                    {
                        cepage.Name = elem.Name;
                        cepage.Origin = elem.Origin;

                        db.SaveChanges();
                        return Ok("Les informations ont bien été changées");
                    }
                    return NotFound("Aucun Cépage correspondant n'a été trouvé. Veuillez Réessayer.");
                }
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(Guid id)
        {
            using (var db = new StiveDbContext())
            {
                try
                {
                  
                    var family = db.Family.Single(o => o.FamilyId == id);
                    if(family != null)
                    {
                        db.Family.Remove(family);
                        db.SaveChanges();
                        return Ok("L'élement à bien été supprimé.");

                    }
                    return NotFound("Aucune famille correspondante n'a été trouvé. Veuillez réessayer.");
                
                }
                catch (System.Exception)
                {
                    throw;
                }
            }
        }

    }

}

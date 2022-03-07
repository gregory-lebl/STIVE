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
    [Route("api/family")]
    [ApiController]
    public class FamilyController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Family> Get()
        {
            using (var db = new StiveDbContext())
            {
                var families = db.Family.ToList();
                return families;
            }
        }

        [HttpGet("{id}")]
        public Family Get(Guid id)
        {

            using (var db = new StiveDbContext())
            {
                var family = db.Family.Single(o => o.FamilyId == id);
                return family;
            }

        }

        [HttpPost("new")]
        public Family Post(Family family)
        {
            using (var db = new StiveDbContext())
            {
                db.Family.Add(family);
                try
                {
                    db.SaveChanges();
                    return family;
                }
                catch (System.Exception)
                {
                    throw;
                }
            }

        }

        [HttpPut("{id}")]
        public ActionResult Put(Family elem)
        {
            try
            {
                using (var db = new StiveDbContext())
                {
                    var family = db.Family.Single(o => o.FamilyId == elem.FamilyId);
                    if (family != null)
                    {
                        family.Name = elem.Name;

                        db.SaveChanges();
                        return Ok("Les informations ont bien été changées");
                    }
                    return NotFound("Aucune famille correspondante n'a été trouvé. Veuillez Réessayer.");
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
                    if (family != null)
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

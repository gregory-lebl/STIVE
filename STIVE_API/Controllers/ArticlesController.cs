using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using STIVE_API.Data;
using STIVE_API.Data.Models.Articles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace STIVE_API.Controllers
{
    [Route("api/article")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {
        // GET: api/article
        [HttpGet]
        public IEnumerable<Article> Get()
        {
            using (var db = new StiveDbContext())
            {
                var articles = db.Article.ToList();
                return articles;

            }
        }

        [HttpGet("{id}")]
        public Article Get(Guid id)
        {
            using (var db = new StiveDbContext())
            {

                /*var query = from article in db.Set<Article>()
                            join cepage in db.Set<Cepage>()
                                on article.Id equals cepage.CepageId
                            join family in db.Set<Family>()
                                on article.Id equals family.FamilyId
                            join annee in db.Set<Annee>()
                                on article.Id equals annee.AnneeId
                            join capacity in db.Set<Capacity>()
                                on article.Id equals capacity.CapacityId
                            select new { article, cepage, family, annee, capacity };*/

                var query = db.Set<Article>().Include(o => o.Cepage).Include(i => i.Family).Include(o => o.Annee).Include(o => o.Capacity);

                //var singleArticle = db.Article.FromSqlRaw("Select * from Article").Single(o => o.Id == id);

                // var singleArticle = query.Where(o => o.article.Id == id);
                var singleArticle = query.Single(o => o.Id == id);
                return singleArticle;
            }

        }

        [HttpDelete("{id}")]
        public ActionResult Delete(Guid id)
        {
            try
            {
                using (var db = new StiveDbContext())
                {
                    var article = db.Article.Single(o => o.Id == id);
                    if(article != null)
                    {
                        db.Article.Remove(article);
                        db.SaveChanges();
                        return Ok();
                    }
                    return Problem("L'élement recherché n'existe pas.");
                    
                }

            }
            catch(System.Exception)
            {
                throw;
            }

        }
  }

}

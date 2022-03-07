using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using STIVE_API.Data;
using STIVE_API.Data.Models.Articles;
using System;
using System.Collections.Generic;
using System.Linq;
using STIVE_API.Helpers;

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
                var query = db.Set<Article>().Include(o => o.Cepage).Include(o => o.Supplier).Include(i => i.Family).Include(o => o.Annee).Include(o => o.Capacity);
                var articles = query.ToList();
                return articles;

            }
        }

        [HttpGet("{id}")]
        public Article Get(Guid id)
        {
            using (var db = new StiveDbContext())
            {

                var query = db.Set<Article>().Include(o => o.Cepage).Include(o => o.Supplier).Include(i => i.Family).Include(o => o.Annee).Include(o => o.Capacity);

                var singleArticle = query.Single(o => o.Id == id);
                return singleArticle;
            }

        }

        [HttpPost("{new}")]
        public ActionResult NewArticle(string Name, string Description, double UnitPrice, int Annee, string CepageName, string CepageOrigin, double Capacity, string FamilyName, string SupplierName, int Quantity, int Limit, int Provision)
        {
            using( var db = new StiveDbContext())
            {
                var Ref = GenerationHelper.NumberGeneration();
                Guid IdAnnee ;
                Guid IdCepage;
                Guid IdCapacity;
                Guid IdFamily;
                Guid IdSupplier;
                Guid IdStock;

                // SUPPLIER EXIST ? 
                var existingSupplier = db.Supplier.Where(o => o.Name == SupplierName).FirstOrDefault();
                if(existingSupplier == null)
                {
                    return BadRequest();
                } else
                {
                    IdSupplier = existingSupplier.SupplierId;
                }
                
                // IF ANNEE DBSET NO EXIST CREATE ONE
                try
                {
                    var existingAnnee = db.Annee.Where(o => o.Number == Annee).FirstOrDefault();
                    if (existingAnnee == null)
                    {
                        var NewAnnee = new Annee(Annee);
                        db.Annee.Add(NewAnnee);
                        IdAnnee = NewAnnee.AnneeId;
                    }
                    else
                    {
                        IdAnnee = existingAnnee.AnneeId;
                    }

                } catch (System.Exception)
                {
                    throw new Exception("Une erreur s'est produite lors de la création de l'année.");
                }
                

                // IF CEPAGE DBSET NO EXIST CREATE ONE
                try
                {
                    var existingCepage = db.Cepage.Where(o => o.Name == CepageName && o.Origin == CepageOrigin).FirstOrDefault();
                    if (existingCepage == null)
                    {
                        var NewCepage = new Cepage(CepageName, CepageOrigin);
                        db.Cepage.Add(NewCepage);
                        IdCepage = NewCepage.CepageId;
                    }
                    else
                    {
                        IdCepage = existingCepage.CepageId;
                    }

                }
                catch (System.Exception)
                {
                    throw new Exception("Une erreur s'est produite lors de la création du cépage");
                }
                

                // IF CAPACITY DBSET NO EXIST CREATE ONE
                try
                {
                    var existingCapacity = db.Capacity.Where(o => o.BottleCapacity == Capacity).FirstOrDefault();
                    if (existingCapacity == null)
                    {
                        var NewCapacity = new Capacity(Capacity);
                        db.Capacity.Add(NewCapacity);
                        IdCapacity = NewCapacity.CapacityId;
                    }
                    else
                    {
                        IdCapacity = existingCapacity.CapacityId;
                    }

                }
                catch (System.Exception)
                {
                    throw new Exception("Une erreur s'est produite lors de la création de la capacité.");
                }
                

                // IF FAMILY DBSET NOT EXIST CREATE ONE
                try
                {
                    var existingFamily = db.Family.Where(o => o.Name == FamilyName).FirstOrDefault();
                    if (existingFamily == null)
                    {
                        var NewFamily = new Family(FamilyName);
                        db.Family.Add(NewFamily);
                        IdFamily = NewFamily.FamilyId;
                    }
                    else
                    {
                        IdFamily = existingFamily.FamilyId;
                    }

                }
                catch (System.Exception)
                {
                    throw new Exception("Une erreur s'est produite lors de la création de la famille.");
                }
                

                // CREATE STOCK REFERENCE 

                var NewStock = new Stock(Quantity, Limit, Provision);
                db.Stock.Add(NewStock);
                IdStock = NewStock.StockId;


                // INSERT NEW ARTICLE
                try
                {
                    Article NewArticle = new Article(Name, Ref, Description, UnitPrice, IdAnnee, IdCapacity, IdCepage, IdFamily, IdSupplier, IdStock);
                    db.Article.Add(NewArticle);
                    db.SaveChanges();
                    return Ok("Création d'article réussie. La référence de votre article est : " + Ref);

                }
                catch (System.Exception)
                {
                    throw;
                }
            }  
        }

        [HttpPut("{id}")]
        public ActionResult Put(Guid id, string Name, string Description, double UnitPrice, int Quantity, int Limit, int Provision)
        {
            try
            {
                using (var db = new StiveDbContext())
                {
                    // Modifications article table
                    var article = db.Article.Single(o => o.Id == id);
                    if (article != null)
                    {
                        if (Name != null && Name != article.Name) article.Name = Name;
                        if (Description != null) article.Description = Description;
                        if (UnitPrice > 0) article.UnitPrice = UnitPrice;


                        // STOCK TABLE
                        var stock = db.Stock.Where(o => o.StockId == article.StockId).Single();
                        if(stock != null)
                        {
                            if (Quantity > 0) stock.Quantity = Quantity;
                            if (Limit > 0) stock.Limit = Limit;
                            if (Provision > 0) stock.Provision = Provision;
                        }
                       
                        db.SaveChanges();
                        return Ok("Les informations de l'article " + article.Ref + " ont bien été modifiées");
                    }
                    return NotFound("Aucun article correspondant.");
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
            try
            {
                using (var db = new StiveDbContext())
                {
                    var article = db.Article.Single(o => o.Id == id);
                    if(article != null)
                    {
                        db.Article.Remove(article);
                        db.SaveChanges();
                        return Ok("Article bien supprimé");
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

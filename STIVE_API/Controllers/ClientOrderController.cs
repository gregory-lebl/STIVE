using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using STIVE_API.Data;
using STIVE_API.Data.Models.Articles;
using STIVE_API.Data.Models.Orders;
using STIVE_API.Helpers;
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
        public IEnumerable<ClientOrderReturn> Get()
        {
            using (var db = new StiveDbContext())
            {
                var clientOrders = db.ClientOrder.ToList();
                List<ClientOrderReturn> clientOrdersReturn = new List<ClientOrderReturn>();
                foreach(ClientOrder order in clientOrders)
                {
                    var client = db.Customers.Single(o => o.Id == order.CustomerId);
                    var status = db.Status.Single(o => o.StatusId == order.StatusId);
                    List<ArticleRow> articles = db.ArticleRow.Where(o => o.ClientOrderId == order.ClientOrderId).ToList();

                    List<ArticleRowReturn> returnArticles = new List<ArticleRowReturn>();

                    foreach (ArticleRow article in articles)
                    {
                        var query = db.Set<Article>().Include(o => o.Cepage).Include(o => o.Supplier).Include(i => i.Family).Include(o => o.Annee).Include(o => o.Capacity);
                        Article article1 = query.Single(o => o.Id == article.ArticleId);
                        ArticleRowReturn newArtcile = new ArticleRowReturn(article.ArticleId, article.ClientOrderId, article.Quantity, article1);
                        returnArticles.Add(newArtcile);

                    }
                    ClientOrderReturn singleOrderReturn = new ClientOrderReturn(order.ClientOrderId, order.Reference, order.HTPrice, order.TTCPrice, order.Date, client.CustomerReference, status.Name, returnArticles);

                    clientOrdersReturn.Add(singleOrderReturn);
                }
                return clientOrdersReturn;
            }
        }

        [HttpGet("{id}")]
        public ClientOrderReturn Get(Guid id)
        {

            using (var db = new StiveDbContext())
            {
                try
                {

                
                var clientOrder = db.ClientOrder.Single(o => o.ClientOrderId == id);
                var client = db.Customers.Single(o => o.Id == clientOrder.CustomerId);
                var status = db.Status.Single(o => o.StatusId == clientOrder.StatusId);
                List<ArticleRow> articles = db.ArticleRow.Where(o => o.ClientOrderId == clientOrder.ClientOrderId).ToList();

                List<ArticleRowReturn> returnArticles = new List<ArticleRowReturn>();

                foreach (ArticleRow article in articles)
                {
                    var query = db.Set<Article>().Include(o => o.Cepage).Include(o => o.Supplier).Include(i => i.Family).Include(o => o.Annee).Include(o => o.Capacity);
                    Article article1 = query.Single(o => o.Id == article.ArticleId);
                    ArticleRowReturn newArtcile = new ArticleRowReturn(article.ArticleId, article.ClientOrderId, article.Quantity, article1);
                    returnArticles.Add(newArtcile);

                }

                ClientOrderReturn res = new ClientOrderReturn(clientOrder.ClientOrderId, clientOrder.Reference, clientOrder.HTPrice, clientOrder.TTCPrice, clientOrder.Date, client.CustomerReference, status.Name, returnArticles);
                return res;
                }
                catch (Exception)
                {
                    return null;
                }
            }

        }

        [HttpPost("new")]
        public ActionResult Post(Guid customerId, double HTPrice, double TTCPrice, List<BasketOrder> Articles)
        {
            if (Articles == null)
            {
                return NotFound("Pas d'articles dans le panier");
            }
            using (var db = new StiveDbContext())
            {
                try
                {
                    var status = new Status("Vérification en cours.");

                    try
                    {
                        db.Status.Add(status);
                        db.SaveChanges();
                    }
                    catch (System.Exception)
                    {
                        throw;
                    }
                    var Reference = GenerationHelper.NumberGeneration();
                    var order = new ClientOrder(Reference, HTPrice, TTCPrice, customerId, status.StatusId);
                    try
                    {
                        db.ClientOrder.Add(order);
                        db.SaveChanges();

                    }
                    catch (System.Exception)
                    {
                        throw;
                    }

                    // Foreach article Create one row 
                    foreach (BasketOrder article in Articles)
                    {
                        try
                        {
                            var newRowArticle = new ArticleRow(article.ArticleId, order.ClientOrderId, article.Quantity);

                            var articleDB = db.Article.Single(o => o.Id == article.ArticleId);
                            var articleDBStock = db.Stock.Single(o => o.StockId == articleDB.StockId);
                            if (articleDBStock.Limit > (articleDBStock.Quantity - article.Quantity))
                            {
                                // PASSER UNE COMMANDE AU FOURNISSEUR
                                PurchaseOrder newpurchase = new PurchaseOrder(article.ArticleId, articleDB.Stock.Provision, articleDB.SupplierId);
                                db.PurchaseOrder.Add(newpurchase);
                            }
                            var newStock = (articleDB.Stock.Quantity - article.Quantity);

                            //CHANGER LE STOCK
                            if (articleDB != null)
                            {
                                articleDB.Stock.Quantity = newStock;
                            }
                            db.ArticleRow.Add(newRowArticle);
                            db.SaveChanges();


                        }
                        catch (System.Exception)
                        {
                            throw;
                        }
                    }

                    return Ok("Votre commande a bien été créée");
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
                    var order = db.ClientOrder.Single(o => o.ClientOrderId == id);
                    if (order != null)
                    {
                        // GET ALL ARTICLE ROW FK
                        var articleRow = db.ArticleRow.Where(o => o.ClientOrderId == order.ClientOrderId).ToList();
                        /// RESTOCK ARTICLES 
                        
                        foreach (ArticleRow row in articleRow)
                        {
                            
                            var article = db.Article.Single(o => o.Id == row.ArticleId);
                            var articleRowStock = db.Stock.Single(o => o.StockId == article.StockId);
                             articleRowStock.Quantity = (articleRowStock.Quantity + row.Quantity);
                             db.SaveChanges();


                            db.ArticleRow.Remove(row);
                            db.SaveChanges();
                        }
                        

                        db.ClientOrder.Remove(order);
                        db.SaveChanges();
                        return Ok("L'élement à bien été supprimé.");
                    }
                    return NotFound("Aucune commande correspondante n'a été trouvé. Veuillez réessayer.");
                }
                catch (System.Exception)
                {
                    throw;
                }
            }
        }




    }
}

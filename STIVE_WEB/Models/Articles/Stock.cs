using System;
using System.ComponentModel.DataAnnotations;

namespace STIVE_WEB.Models.Articles
{
    public class Stock
    {
        [Key] public Guid StockId { get; set; }
        public int Quantity { get; set; }
        public Guid ArticleId { get; set;  }
        public virtual Article Article { get; set; } 
        public int Limit { get; set; }
        public int Provision { get; set; }

        public Stock(Guid ArticleId, int Quantity, int Limit, int Provision)
        {
            StockId = Guid.NewGuid();
            this.ArticleId = ArticleId;
            this.Quantity = Quantity;
            this.Limit = Limit;
            this.Provision = Provision;

        }
    }
}

using STIVE_WEB.Models.Articles;
using System;
using System.ComponentModel.DataAnnotations;

namespace STIVE_WEB.Models.Orders
{
    public class ArticleRow
    {
        [Key] public Guid ArticleRowId { get; set; }
        public int Quantity { get; set; }
        public Guid ClientOrderId { get; set; }
        public virtual ClientOrder ClientOrder { get; set; }

        public Guid ArticleId { get; set; }
        public virtual Article Article { get; set; }

        public ArticleRow(Guid ArticleId, Guid ClientOrderId, int Quantity )
        {

            ArticleRowId = Guid.NewGuid();
            this.ArticleId = ArticleId;
            this.ClientOrderId = ClientOrderId;
            this.Quantity = Quantity;

        }

        
    }
}

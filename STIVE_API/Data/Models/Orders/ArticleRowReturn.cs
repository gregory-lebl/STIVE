using STIVE_API.Data.Models.Articles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace STIVE_API.Data.Models.Orders
{
    public class ArticleRowReturn
    {
        public Guid ArticleRowId { get; set; }
        public int Quantity { get; set; }
        public Guid ArticleId { get; set; }
        public Article Article { get; set; }

        public ArticleRowReturn(Guid ArticleId, Guid ClientOrderId, int Quantity, Article Article)
        {

            ArticleRowId = Guid.NewGuid();
            this.ArticleId = ArticleId;
            this.Quantity = Quantity;
            this.Article = Article;

        }
    }
}

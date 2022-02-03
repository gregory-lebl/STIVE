using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace STIVE_API.Data.Models.Orders
{
    public class BasketOrder
    {
        public Guid ArticleId { get; set; }
        public int Quantity { get; set; }

        public BasketOrder(Guid ArticleId, int Quantity)
        {
            this.Quantity = Quantity;
            this.ArticleId = ArticleId;

        }
    }
}

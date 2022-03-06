using System;

namespace STIVE_WEB.Models.Orders
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

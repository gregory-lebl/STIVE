using System;

namespace STIVE_WEB.Models.Orders
{
    public class TestOrder
    {
        public Guid ArticleId { get; set; }
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }
    }
}

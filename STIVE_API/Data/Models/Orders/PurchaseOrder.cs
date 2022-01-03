using STIVE_API.Data.Models.Articles;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace STIVE_API.Data.Models.Orders
{
    public class PurchaseOrder
    {
        // PK
        [Key] public Guid PurshaseOrderId { get; set; }

        // OTHER DATA
        public int Quantity { get; set; }
        public double TTCPrice { get; set; }
        public double HTPrice { get; set; }

        // FK
        public Guid? ArticleId { get; set; }
        public virtual Article Article { get; set; }

        public Guid? SupplierId { get; set; }
        public virtual Supplier Supplier { get; set; }

        public PurchaseOrder(Guid? ArticleId, int Quantity, Guid? SupplierId)
        {
            PurshaseOrderId = Guid.NewGuid();
            this.ArticleId = ArticleId;
            this.Quantity = Quantity;
            this.SupplierId = SupplierId;

        }


    }
}

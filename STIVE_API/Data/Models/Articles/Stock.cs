using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace STIVE_API.Data.Models.Articles
{
    public class Stock
    {
        [Key] public Guid StockId { get; set; }
        public int Quantity { get; set; }
        public int Limit { get; set; }
        public int Provision { get; set; }

        public Stock( int Quantity, int Limit, int Provision)
        {
            StockId = Guid.NewGuid();
            this.Quantity = Quantity;
            this.Limit = Limit;
            this.Provision = Provision;
        }


    }
}

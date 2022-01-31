using STIVE_API.Data.Models.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace STIVE_API.Data.Models.Orders
{
    public class ClientOrder
    {
        [Key] public Guid ClientOrderId { get; set; }
        public string Reference { get; set; }

        public double HTPrice { get; set; }
        public double TTCPrice { get; set; }
        public DateTime Date { get; set; }
        public Guid CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public Guid StatusId { get; set; }
        public virtual Status Status { get; set; }
        // public List<ArticleRow> ArticleRow { get; set; }

        public ClientOrder(string Reference, double HTPrice, double TTCPrice, Guid CustomerId, Guid StatusId)
        {
            ClientOrderId = Guid.NewGuid();
            this.Reference = Reference;
            this.HTPrice = HTPrice;
            this.TTCPrice = TTCPrice;
            this.CustomerId = CustomerId;
            this.StatusId = StatusId;
            Date = DateTime.UtcNow;
        }

    }
}

using STIVE_API.Data.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace STIVE_API.Data.Models.Orders
{
    public class ClientOrderReturn
    {
        public Guid ClientOrderId { get; set; }
        public string Reference { get; set; }
        public double HTPrice { get; set; }
        public double TTCPrice { get; set; }
        public DateTime Date { get; set; }
        public string CustomerReference { get; set; } // REF
        public string Status { get; set; } // STRING
        public List<ArticleRowReturn> Articles { get; set; }

        public ClientOrderReturn(Guid ClientOrderId, string Reference, double HTPrice, double TTCPrice, DateTime Date, string CustomerReference, string Status, List<ArticleRowReturn> Articles )
        {
            this.ClientOrderId = ClientOrderId;
            this.Reference = Reference;
            this.HTPrice = HTPrice;
            this.TTCPrice = TTCPrice;
            this.Date = Date;
            this.CustomerReference = CustomerReference;
            this.Status = Status;
            this.Articles = Articles;

        }
    }
}

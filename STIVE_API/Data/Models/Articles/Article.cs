using STIVE_API.Data.Models.Orders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace STIVE_API.Data.Models.Articles
{
    public class Article
    {
        //PK
        [Key] public Guid Id { get; set; }

        //FK
        public Guid? AnneeId { get; set; }
        public virtual Annee Annee { get; set; } // Variable de navigation entre les tables
        public Guid? CapacityId { get; set; }
        public virtual Capacity Capacity { get; set; } // Variable de navigation entre les tables
        public Guid? CepageId { get; set; }
        public virtual Cepage Cepage { get; set; } // Variable de navigation entre les tables
        public Guid? FamilyId { get; set; }
        public virtual Family Family { get; set; } // Variable de navigation entre les tables
        public Guid? SupplierId { get; set; }
        public virtual Supplier Supplier { get; set; } // Variable de navigation entre les tables
        public Guid? StockId { get; set; }
        public virtual Stock Stock { get; set; } // Variable de navigation entre les tables


        //NO KEY
        public string Name { get; set; }
        public string Ref {get ;set ;}
        public string Description { get; set; }
        public double UnitPrice { get; set; }
        public byte[] Picture { get; set; }

        public Article(string Name, string Ref, string Description, double UnitPrice, Guid? AnneeId, Guid? CapacityId, Guid? CepageId, Guid? FamilyId, Guid? SupplierId, Guid? StockId)
        {

            Id = Guid.NewGuid();
            this.Name = Name;
            this.Ref = Ref;
            this.Description = Description;
            this.UnitPrice = UnitPrice;
            this.AnneeId = AnneeId;
            this.CapacityId = CapacityId;
            this.CepageId = CepageId;
            this.FamilyId = FamilyId;
            this.SupplierId = SupplierId;
            this.StockId = StockId;
        }


    }
}

using STIVE_WEB.Models.Orders;
using System;
using System.ComponentModel.DataAnnotations;

namespace STIVE_WEB.Models.Articles
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


        //NO KEY
        public string Name { get; set; }
        public string Ref {get ;set ;}
        public string Description { get; set; }
        public double UnitPrice { get; set; }

        public byte[] Picture { get; set; }

        public Article(Guid id, Guid anneeId, Annee annee,Guid capacityId,Capacity capacity,Guid cepageId, Cepage cepage,Guid familyId, Family family,Guid supplierId, Supplier supplier, string name,string @ref,string description, double unitPrice, byte[] picture)
        {
            this.Id = id;
            this.AnneeId = anneeId;
            this.Annee = annee;
            this.CapacityId = capacityId;
            this.Capacity = capacity;
            this.CepageId = cepageId;
            this.Cepage = cepage;
            this.FamilyId = familyId;
            this.Family = family;
            this.SupplierId = supplierId;
            this.Supplier = supplier;
            this.Name = name;
            this.Ref = @ref;
            this.Description = description;
            this.UnitPrice = unitPrice;
            this.Picture = picture;
        }


    }
}

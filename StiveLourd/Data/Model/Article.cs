using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StiveLourd.Pages//StiveLourd.Model
{
    
    public class Article
    {
        public string id { get; set; }
        public string anneeId { get; set; }
        public int? annee { get; set; }
        public string capacityId { get; set; }
        public string capacity { get; set; }
        public string cepageId { get; set; }
        public string cepage { get; set; }
        public string familyId { get; set; }
        public string family { get; set; }
        public string supplierId { get; set; }
        public string supplier { get; set; }
        public string name { get; set; }
        public string Ref { get; set; }
        public string description { get; set; }
        public double unitPrice { get; set; }
        public string picture { get; set; }

        /*public Article(string id, string yearId, int? year, string capacityId, string capacity, string cepageId, string cepage, string familyId, string family, string supplierId, string supplier, string name, string @ref, string description, double unitPrice)
        {
            Id = id;
            YearId = yearId;
            Year = year;
            CapacityId = capacityId;
            Capacity = capacity;
            CepageId = cepageId;
            Cepage = cepage;
            FamilyId = familyId;
            Family = family;
            SupplierId = supplierId;
            Supplier = supplier;
            Name = name;
            Ref = @ref;
            Description = description;
            UnitPrice = unitPrice;
        }*/

        public Article()
        {
        }

        public string getMonTest()
        {
           String monText = "Bonne nouvelle ça fonctionne !";
            return monText;
        }
    }


}

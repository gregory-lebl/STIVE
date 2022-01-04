using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace STIVE_WEB.Models.Orders
{
    public class Supplier
    {
        [Key] public Guid SupplierId { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Cp { get; set; }
        public string City { get; set; }
        public string Siret { get; set; }
        public string PhoneNumber { get; set; }

        public Supplier(string Name, string Adress, string Cp, string City, string Siret, string PhoneNumber)
        {

            SupplierId = Guid.NewGuid();
            this.Name = Name;
            this.Adress = Adress;
            this.Cp = Cp;
            this.City = City;
            this.Siret = Siret;
            this.PhoneNumber = PhoneNumber;


        }
    }
}

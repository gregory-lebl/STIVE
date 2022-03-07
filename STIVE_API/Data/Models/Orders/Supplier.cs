using System;
using System.ComponentModel.DataAnnotations;

namespace STIVE_API.Data.Models.Orders
{
    public class Supplier
    {
        [Key] public Guid SupplierId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Cp { get; set; }
        public string City { get; set; }
        public string Siret { get; set; }
        public string PhoneNumber { get; set; }

        public Supplier(string Name, string Address, string Cp, string City, string Siret, string PhoneNumber)
        {

            SupplierId = Guid.NewGuid();
            this.Name = Name;
            this.Address = Address;
            this.Cp = Cp;
            this.City = City;
            this.Siret = Siret;
            this.PhoneNumber = PhoneNumber;


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StiveLourd.Data.Model
{
    class Fournisseur
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Cp { get; set; }
        public string City { get; set; }
        public string Siret { get; set; }
        public string PhoneNumber { get; set; }

        public Fournisseur() { }
    }
    
}

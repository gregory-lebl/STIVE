using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace STIVE_API.Data.Models.Articles
{
    public class Cepage
    {
        
        [Key] public Guid CepageId { get; set; }
        public string Name { get; set; }
        public string Origin { get; set; }

        public Cepage(string Name, string Origin)
        {
            CepageId = Guid.NewGuid();
            this.Name = Name;
            this.Origin = Origin;

        }
    }
}

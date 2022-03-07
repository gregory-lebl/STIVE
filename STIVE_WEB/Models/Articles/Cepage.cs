using System;
using System.ComponentModel.DataAnnotations;

namespace STIVE_WEB.Models.Articles
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

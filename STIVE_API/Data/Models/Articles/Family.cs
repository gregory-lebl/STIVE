using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace STIVE_API.Data.Models.Articles
{
    public class Family
    {
        [Key] public Guid FamilyId { get; set; }
        public string Name { get; set; }

        public Family(string Name)
        {
            FamilyId = Guid.NewGuid();
            this.Name = Name;

        }
    }
}

using System;
using System.ComponentModel.DataAnnotations;

namespace STIVE_WEB.Models.Articles
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

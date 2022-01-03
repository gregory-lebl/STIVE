using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace STIVE_API.Data.Models.Articles
{
    public class Annee
    {
        [Key] public Guid AnneeId { get; set; }
        public int Number { get; set; }

        public Annee(int Number)
        {
            AnneeId = Guid.NewGuid();
            this.Number = Number;

        }

    }
}

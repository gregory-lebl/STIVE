using System;
using System.ComponentModel.DataAnnotations;

namespace STIVE_WEB.Models.Articles
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

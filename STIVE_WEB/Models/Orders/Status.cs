using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace STIVE_WEB.Models.Orders
{
    public class Status
    {
        [Key] public Guid StatusId { get; set; }
        public string Name { get; set; }

        public Status(string Name)
        {
            this.StatusId = Guid.NewGuid();
            this.Name = Name;

        }
    }
}

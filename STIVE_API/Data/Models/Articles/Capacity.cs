using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace STIVE_API.Data.Models.Articles
{
    public class Capacity
    {
        [Key] public Guid CapacityId { get; set; }
        public double BottleCapacity { get; set; }

        public Capacity(double BottleCapacity)
        {
            this.BottleCapacity = BottleCapacity;
            CapacityId = Guid.NewGuid();

        }
    }
}

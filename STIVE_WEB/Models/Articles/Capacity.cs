using System;
using System.ComponentModel.DataAnnotations;

namespace STIVE_WEB.Models.Articles
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

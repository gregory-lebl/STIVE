using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StiveLourd.Data.Model
{
    class Order
    {
        public string reference { get; set; }
        public string htprice { get; set; }
        public string ttcprice { get; set; }
        public string date { get; set; }
        public string customerReference { get; set; }
        public string status { get; set; }

        public Order() { }

    }
}

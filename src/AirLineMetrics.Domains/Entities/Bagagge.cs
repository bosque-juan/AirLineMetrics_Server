using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLineMetrics.Domain.Models
{
    public class Bagagge
    {
        public int BagaggeId { get; set; }
        public decimal Price { get; set; }
        public decimal Weight { get; set; }
        public int BaggeTypeId { get; set; }
    }
}

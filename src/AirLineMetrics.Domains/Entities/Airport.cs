using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLineMetrics.Domain.Models
{
    public class Airport
    {
        public int AirportId { get; set; }
        public string AirportName { get; set; }
        public int StateId { get; set; }
        public State State { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLineMetrics.Domain.Entities
{
    public class BaggageReservation
    {
        public int BaggageId { get; set; }
        public decimal Price { get; set; }
        public decimal Weight { get; set; }
        public int BaggageTypeId { get; set; }
        public int FlightDetailId { get; set; }
        public BaggageType BaggageTypeNavigation { get; set; } = null!;
        public FlightDetail FlightDetailNavigation { get; set; } = null!;
    }
}

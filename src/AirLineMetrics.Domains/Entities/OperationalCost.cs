using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLineMetrics.Domain.Entities
{
    public class OperationalCost
    {
        public int Id { get; set; }
        public decimal FuelCost { get; set; }
        public decimal MaintenanceCost { get; set; }
        public decimal CrewCost { get; set; }
        public decimal AirportFees { get; set; }
        public DateTime OperationalDate { get; set; }
        public int FlightId { get; set; }
        public Flight FlightNavigation { get; set; } = null!;
    }
}

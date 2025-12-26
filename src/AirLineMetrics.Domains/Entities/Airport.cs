using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLineMetrics.Domain.Entities
{
    public class Airport
    {
        public int AirportId { get; set; }
        public string Name { get; set; } = string.Empty;
        public int StateId { get; set; }
        public State StateNavigation { get; set; } = null!;

        public ICollection<Flight> OriginAirportNavigation { get; set; } = new List<Flight>();
        public ICollection<Flight> DestinationAirportNavigation { get; set; } = new List<Flight>();

    }
}

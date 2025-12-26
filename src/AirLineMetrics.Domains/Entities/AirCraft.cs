using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLineMetrics.Domain.Entities
{
    public class AirCraft
    {
        public int AirCraftId { get; set; }
        public string AirCraftName { get; set; } = string.Empty;
        public int PassengerCapacity { get; set; }
        public ICollection<Flight> FlightsNavigation { get; set; } = new List<Flight>();
    }
}

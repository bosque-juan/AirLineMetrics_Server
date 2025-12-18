using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLineMetrics.Domain.Models
{
    public class Flight
    {
        public int FlightId { get; set; }
        public string FlightCode { get; set; } = string.Empty;
        public int OriginAirportId { get; set; }
        public int DestinationAirportId { get; set; }
        public int AirCraftId { get; set; }
        public string ScheduledDeparture { get; set; } = string.Empty;
        public string ScheduledArrival { get; set; } = string.Empty;
        public string ActualDeparture { get; set; } = string.Empty;
        public string ActualArrival { get; set; } = string.Empty;
        public bool IsCancelled { get; set; }
        public Airport OriginAirport { get; set; } = null!;
        public Airport DestinationAirport { get; set; } = null!;
        public AirCraft AirCraft { get; set; } = null!;

        public ICollection<FlightDetail> FlightDetails { get; set; } = null!;
        public ICollection<FlightPromotion> FlightPromotions { get; set; } = null!;

        public ICollection<OperationalCost> operationalCosts { get; set; } = null!;

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLineMetrics.Domain.Entities
{
    public class Flight
    {
        public int FlightId { get; set; }
        public string FlightCode { get; set; } = string.Empty;
        public string ScheduledDeparture { get; set; } = string.Empty;
        public string ScheduledArrival { get; set; } = string.Empty;
        public string ActualDeparture { get; set; } = string.Empty;
        public string ActualArrival { get; set; } = string.Empty;
        public bool IsDeleted { get; set; }
        public int AirCraftId { get; set; }
        public int OriginAirportId { get; set; }
        public int DestinationAirportId { get; set; }
        public int StateId { get; set; }

        public AirCraft AirCraftNavigation { get; set; } = null!;
        public Airport OriginAirportNavigation { get; set; } = null!;
        public Airport DestinationAirportNavigation { get; set; } = null!;
        public State StateNavigation { get; set; } = null!;
        
        public ICollection<FlightDetail> FlightDetailsNavigation { get; set; } = null!;
        public ICollection<OperationalCost> OperationalCostsNavigation { get; set; } = new HashSet<OperationalCost>();
        public ICollection<FlightPromotion> FlightPromotionsNavigation { get; set; } = null!;
    }
}

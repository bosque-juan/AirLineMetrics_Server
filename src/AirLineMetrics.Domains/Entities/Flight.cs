using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLineMetrics.Domain.Models
{
    public class Flight
    {
        public int FlightId {  get; set; }
        public string FlightCode { get; set; }
        public int OriginAirportId { get; set; }
        public int DestinationAirportId { get; set; }
        public int AirCraftId {  get; set; }
        public int StateId { get; set; }
        public string ScheduledDeparture { get; set; }
        public string ScheduledArrival { get; set; }
        public string ActualDeparture { get; set; }
        public string ActualArrival { get; set; }
        public bool IsDeleted { get; set; }
        public State StateNavigation { get; set; }

    }
}

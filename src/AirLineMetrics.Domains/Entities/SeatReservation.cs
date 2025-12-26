using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLineMetrics.Domain.Entities
{
    public class SeatReservation
    {
        public int SeatId { get; set; }
        public int Number { get; set; }
        public bool IsBussy { get; set; }
        public int SeatTypeId { get; set; }
        public int FlighDetailtId { get; set; }
        public SeatType SeatTypeNavigation { get; set; } = null!;
        public FlightDetail FlightDetailNavigation { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLineMetrics.Domain.Models
{
    public class Seat
    {
        public int SeatId { get; set; }
        public int Number {  get; set; }
        public bool IsBussy { get; set; }
        public int SeatTypeId { get; set; }
        public int FlightId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLineMetrics.Domain.Models
{
    public class SeatType
    {
        public int SeatTypeId { get; set; }
        public string SeatName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public double AddedSeatTypePrice { get; set; }

        public ICollection<Seat> Seats { get; set; } = null!;
    }
}

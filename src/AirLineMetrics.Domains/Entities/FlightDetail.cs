using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLineMetrics.Domain.Models
{
    public class FlightDetail
    {
        public int FlightDetailId { get; set; }
        public decimal FinlaPrice { get; set; }
        public string Description { get; set; }

        public int PassengerId { get; set; }
        public int FlightId { get; set; }
        public int SeatId { get; set; }

    }
}

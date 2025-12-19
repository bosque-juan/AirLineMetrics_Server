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
        public decimal FinalPrice { get; set; }
        public string Description { get; set; } = string.Empty;

        public int PassengerId { get; set; }
        public int FlightId { get; set; }
        public int SeatId { get; set; }

        public bool BookCancelled { get; set; }
        public Passenger Passenger { get; set; } = null!;
        public Flight Flight { get; set; } = null!;
        public Seat Seat { get; set; } = null!;

        public ICollection<InvoiceDetail> InvoiceDetails { get; set; } = null!;

    }
}

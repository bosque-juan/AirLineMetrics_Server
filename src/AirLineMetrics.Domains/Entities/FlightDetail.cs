using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLineMetrics.Domain.Entities
{
    public class FlightDetail
    {
        public int FlightDetailId { get; set; }
        public DateTime Date { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; } = string.Empty;
        public bool IsCancelled { get; set; }
        public int PassengerId { get; set; }
        public int FlightId { get; set; }

        public Passenger PassengerNavigation { get; set; } = null!;
        public Flight FlightNavigation { get; set; } = null!;
        public ICollection<SeatReservation> SeatReservationNavigation { get; set; } = new List<SeatReservation>();
        public ICollection<BaggageReservation> BaggageNavigation { get; set; } = new List<BaggageReservation>();
        public ICollection<InvoiceDetail> InvoiceDetailNavigation { get; set; } = new List<InvoiceDetail>();

    }
}

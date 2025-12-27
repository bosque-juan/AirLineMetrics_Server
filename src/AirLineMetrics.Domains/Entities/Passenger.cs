using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLineMetrics.Domain.Entities
{
    public class Passenger
    {
        public int PassengerId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public string Street { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public int MobileNumber { get; set; }
        public bool IsActive { get; set; } = true;
        public int DocumentTypeId { get; set; }
        public int PassengerTypeId { get; set; }
        public int StateId { get; set; }

        public DocumentType DocumentTypeNavigation { get; set; } = null!;
        public PassengerType PassengerTypeNavigation { get; set; } = null!;
        public State StateNavigation { get; set; } = null!;
        public ICollection<Invoice> InvoiceNavigation { get; set; } = null!;
        public ICollection<FlightDetail> FlightDetailsNavigation { get; set; } = null!;
    }
}

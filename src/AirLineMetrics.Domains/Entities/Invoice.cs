using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLineMetrics.Domain.Entities
{
    public class Invoice
    {
        public int InvoiceId { get; set; }
        public DateTime Date { get; set; }
        public int PassengerId { get; set; }
        public Passenger PassengerNavigation { get; set; } = null!;
        public ICollection<InvoicePayment> InvoicePaymentNavigation { get; set; } = new List<InvoicePayment>();
        public ICollection<InvoiceDetail> InvoiceDetailNavigation { get; set; } = new List<InvoiceDetail>();

    }
}

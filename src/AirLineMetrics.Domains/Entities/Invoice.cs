using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLineMetrics.Domain.Models
{
    public class Invoice
    {
        public int InvoiceId { get; set; }
        public DateTime Date {  get; set; }
        public int PassengerId { get; set; }

        public ICollection<InvoiceDetail> InvoiceDetails { get; set; } = new List<InvoiceDetail>();

        public ICollection<Cancellation> Cancellations { get; set; } = new List<Cancellation>();
        public Passenger Passenger { get; set; } = null!;
        public ICollection<Payment> Payments { get; set; } = new List<Payment>();
    }
}

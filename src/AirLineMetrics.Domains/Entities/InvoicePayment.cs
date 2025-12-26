using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLineMetrics.Domain.Entities
{
    public class InvoicePayment
    {
        public int PaymentId { get; set; }
        public double PaymentAmount { get; set; }
        public DateTime PaymentDate { get; set; }

        public int PaymentMethodId { get; set; }
        public int InvoiceId { get; set; }
        public PaymentMethod PaymentMethodNavigation { get; set; } = null!;
        public Invoice InvoiceNavigation { get; set; } = null!;
    }
}

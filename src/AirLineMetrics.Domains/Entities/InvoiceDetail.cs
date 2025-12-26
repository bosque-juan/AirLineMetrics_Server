using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLineMetrics.Domain.Entities
{
    public class InvoiceDetail
    {
        public int InvoiceDetailId { get; set; }
        public decimal Price { get; set; }
        public int InvoiceId { get; set; }
        public int FlightDetailId { get; set; }

        public Invoice InvoiceNavigation { get; set; } = null!;
        public FlightDetail FlightDetailNavigation { get; set; } = null!;
        public ICollection<PurchaseCancellation> PurchaseCancellationNavigation { get; set; } = new List<PurchaseCancellation>();
        public ICollection<InvoiceDetail> InvoiceDetailNavigation { get; set; } = new List<InvoiceDetail>();

    }
}

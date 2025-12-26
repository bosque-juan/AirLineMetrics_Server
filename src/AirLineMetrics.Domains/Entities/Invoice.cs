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
        public int PassenerId { get; set; }
        public int PaymentId {  get; set; }
        public int PaymentMethodId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLineMetrics.Domain.Models
{
    public class InvoiceDetail
    {
        public int InvoiceDetailId { get; set; }
        public int InvoiceId { get; set; }
        public  int FlightDetailId { get; set; }
    }
}

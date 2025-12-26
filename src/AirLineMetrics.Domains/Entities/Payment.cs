using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLineMetrics.Domain.Models
{
    public class Payment
    {
        public int PaymentId { get; set; }

        public double PaymentAmount { get; set; }
        public DateTime PaymentDate { get; set; }
        public int PaymentMethodId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLineMetrics.Domain.Models
{
    public class CancellationReason
    {
        public int CancellationReasonId { get; set; }
        public string CancellationDescription {  get; set; }

        public ICollection<Cancellation> Cancellations { get; set; } = new List<Cancellation>();
    }
}

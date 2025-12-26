using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLineMetrics.Domain.Entities
{
    public class CancellationReason
    {
        public int CancellationReassonId { get; set; }
        public string Description { get; set; } = string.Empty;
        public ICollection<PurchaseCancellation> PurchaseCancellationNavigation { get; set; } = new List<PurchaseCancellation>();

    }
}

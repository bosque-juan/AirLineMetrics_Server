using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLineMetrics.Domain.Entities
{
    public class BaggageType
    {
        public int BaggageTypeId { get; set; }
        public string BaggageName { get; set; } = string.Empty;
        public ICollection<BaggageReservation> BaggageNavigation { get; set; } = new List<BaggageReservation>();
    }
}

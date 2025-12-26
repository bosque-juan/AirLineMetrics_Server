using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLineMetrics.Domain.Entities
{
    public class PassengerType
    {
        public int PassengerTypeId { get; set; }
        public string Description { get; set; } = string.Empty;
        public ICollection<Passenger> PassengerNavigation { get; set; } = null!;

    }
}

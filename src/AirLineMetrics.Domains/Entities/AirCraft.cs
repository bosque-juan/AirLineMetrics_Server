using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLineMetrics.Domain.Models
{
    public class AirCraft
    {
        public int AirCraftId { get; set; }
        public string AirCraftName { get; set; } = string.Empty;
        public int PassengerCapacity { get; set; }

    }
}

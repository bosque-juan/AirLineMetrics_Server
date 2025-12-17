using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLineMetrics.Domain.Models
{
    public class FlightPromotion
    {
        public int FlightPromotionId { get; set; }
        public int PromotionId { get; set; }
        public int FlightId { get; set; }
    }
}

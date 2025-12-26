using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLineMetrics.Domain.Entities
{
    public class FlightPromotion
    {
        public int FlightPromotionId { get; set; }
        public int PromotionId { get; set; }
        public int FlightId { get; set; }

        public Promotion PromotionNavigation { get; set; } = null!;
        public Flight FlightNavigation { get; set; } = null!;


    }
}

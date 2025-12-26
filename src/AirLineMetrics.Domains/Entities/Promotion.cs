using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLineMetrics.Domain.Entities
{
    public class Promotion
    {
        public int PromotionId { get; set; }
        public string Description { get; set; } = string.Empty;
        public DateTime PromotionStart { get; set; }
        public DateTime PromotionEnd { get; set; }
        public double PromotionDiscount { get; set; }
        public ICollection<FlightPromotion> FlightPromotionsNavigation { get; set; } = null!;

    }
}

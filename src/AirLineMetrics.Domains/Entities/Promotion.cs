using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLineMetrics.Domain.Models
{
    public class Promotion
    {
        public int PromotionId { get; set; }
        public string Description { get; set; } = string.Empty;
        public string PromotionStart { get; set; } = string.Empty;
        public string PromotionEnd { get; set; }    =   string.Empty;
        public double PromotionDiscount { get; set; }

        public ICollection<FlightPromotion> FlightPromotions { get; set; } = null!;


    }
}

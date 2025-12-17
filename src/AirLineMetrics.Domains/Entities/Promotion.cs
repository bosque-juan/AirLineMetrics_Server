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
        public string Description { get; set; }
        public string PromotionStart { get; set; }
        public string PromotionEnd { get; set; }
        public double PromotionDiscount { get; set; }


    }
}

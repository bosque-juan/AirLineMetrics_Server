using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLineMetrics.Domain.Models
{
    public class CancellationReasson
    {
        public int CancellationReassonId { get; set; }
        public string CancellationDescription {  get; set; }
    }
}

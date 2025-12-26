using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLineMetrics.Domain.Models
{
    public class Country
    {
        public int CountryId { get; set; }
        public string Name { get; set; } = string.Empty;
        //public ICollection<State> States { get; set; } = new List<State>();
    }
}

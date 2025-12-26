using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLineMetrics.Domain.Models
{
    public class State
    {
        public int IdState { get; set; }
        public string StateName { get; set; }

        public int IdCountry { get; set; }

        public Country CountryNavigation { get; set; }

        public ICollection<Passenger> Passengers { get; set; } = new List<Passenger>();
        public ICollection<Airport> Aiports { get; set; }    
    }
}

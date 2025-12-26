using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLineMetrics.Domain.Entities
{
    public class State
    {
        public int StateId { get; set; }
        public string StateName { get; set; } = string.Empty;
        public int CountryId { get; set; }
        public Country CountryNavigation { get; set; } = new Country();
        public ICollection<Passenger> PassengersNavigation { get; set; } = new List<Passenger>();
        public ICollection<Flight> FlightNavigation { get; set; } = new List<Flight>();
        public ICollection<Airport> AiportsNavigation { get; set; } = new List<Airport>();
    }
}

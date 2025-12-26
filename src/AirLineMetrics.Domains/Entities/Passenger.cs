//using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLineMetrics.Domain.Models
{
   public class Passenger
    {
        public int PassengerId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; } 
        public int DocumentTypeId { get; set; }
        public int ClientTypeId {  get; set; }
        public string Street {  get; set; }
        public string Email { get; set; }
        public int MobileNumber { get; set; }

        public int StateId { get; set; }
    }
}

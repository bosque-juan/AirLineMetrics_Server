using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirLineMetrics.Domain.Models;

namespace AirLIneDbContext.Models
{
    public class DocumentType
    {
        public int DocumentTypeId { get; set; }

        public string DocumentTypeName { get; set; } = string.Empty;

        public virtual ICollection<Passenger> passengers {get;set;} = new List<Passenger>();
    }
}

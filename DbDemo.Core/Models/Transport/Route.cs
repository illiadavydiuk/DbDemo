using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbDemo.Core.Models.Transport
{
    public class Route
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RouteId { get; set; }

        [Required] public string Name { get; set; }
        [Required] public string Number { get; set; }
        [Required] public string Type { get; set; }

        public virtual ICollection<RouteStop> RouteStops { get; set; } = new HashSet<RouteStop>();
        public virtual ICollection<Trip> Trips { get; set; } = new HashSet<Trip>();
    }
}

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DbDemo.Core.Models.Common;

namespace DbDemo.Core.Models.Transport
{
    public class Passenger
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PassengerId { get; set; }

        [ForeignKey(nameof(Resident))] public int ResidentId { get; set; }
        public virtual Resident Resident { get; set; }

        public string TicketNumber { get; set; }
        public string Category { get; set; }

        public virtual ICollection<PassengerTrip> PassengerTrips { get; set; } = new HashSet<PassengerTrip>();
    }
}

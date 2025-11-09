using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbDemo.Core.Models.Transport
{
    public class Trip
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TripId { get; set; }

        [ForeignKey(nameof(Route))] public int RouteId { get; set; }
        public virtual Route Route { get; set; }

        [ForeignKey(nameof(Vehicle))] public int VehicleId { get; set; }
        public virtual Vehicle Vehicle { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public virtual ICollection<Schedule> Schedules { get; set; } = new HashSet<Schedule>();
        public virtual ICollection<PassengerTrip> PassengerTrips { get; set; } = new HashSet<PassengerTrip>();
    }
}
